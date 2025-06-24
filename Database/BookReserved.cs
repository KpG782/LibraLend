using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FInalLibrarySystem.Database
{
    public class BookReservedModel
    {
        public string ISBN { get; set; }
        public string UserID { get; set; }
        public string Username { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }

        public string UserFullName { get; set; }

        public string Status { get; set; }
        public DateTime Reserved { get; set; }
        public byte[] Picture { get; set; }
    }

    internal class BookReserved
    {
        private MyDB db;

        public BookReserved()
        {
            db = new MyDB();
        }

        // New method to add reserved books
        public bool AddReservedBook(string userId, string isbn, string title, string author,byte[] picture, DateTime Reserved, string Status, string UserFullName )
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    //// You may want to get the username of the user making the reservation
                    //string username = GetUsername(userId);

                    // Insert the reserved book into the bookreserved table
                    string query = "INSERT INTO bookreserved (username, status, isbn, title, author, picture, reservedate, userFullName) " +
                                   "VALUES (@username, @status, @isbn, @title, @author, @picture, @reservedate, @userFullName )";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@username", userId);
                        cmd.Parameters.AddWithValue("@isbn", isbn);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@author", author);
                        cmd.Parameters.AddWithValue("@picture", picture);
                        cmd.Parameters.AddWithValue("@reservedate", Reserved);
                        cmd.Parameters.AddWithValue("@status", Status);
                        cmd.Parameters.AddWithValue("@userFullName", UserFullName);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Display a message box based on the success of the operation
                        if (rowsAffected > 0)
                        {


                            return true; // Indicates success
                        }
                        else
                        {
                            MessageBox.Show("Failed to reserve the book. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false; // Indicates failure
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error adding reserved book: {ex.Message}");
                MessageBox.Show("An error occurred while reserving the book. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Indicates failure
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }
        }

        // Method to get the username based on userId
        private string GetUsername(string userId)
        {
            string username = null;

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT username FROM app_users WHERE studentID = @userId OR employeeID = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            username = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error getting username: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            return username;
        }

        public List<BookReservedModel> GetAllReservedBooks()
        {
            List<BookReservedModel> reservedBooks = new List<BookReservedModel>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Query to retrieve all data from bookreserve
                    string query = "SELECT * FROM bookreserved";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BookReservedModel reservedBook = new BookReservedModel
                                {
                                    ISBN = reader.GetString("isbn"),
                                    Username = reader.GetString("username"), // Assuming username is a column in the database
                                    BookTitle = reader.GetString("title"),
                                    BookAuthor = reader.GetString("author"),
                                    Status = reader.GetString("status"),
                                    Reserved = reader.GetDateTime("reservedate"),
                                    Picture = (byte[])reader["picture"],
                                    // ... (other properties)

                                };
                                reservedBooks.Add(reservedBook);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            return reservedBooks;
        }


        public BookReservedModel GetReservedBookByISBN(string isbn)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    string query = "SELECT * FROM bookreserved WHERE ISBN = @ISBN";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ISBN", isbn);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new BookReservedModel
                                {
                                    ISBN = reader["ISBN"].ToString(),
                                    UserID = reader["userID"].ToString(),
                                    Username = reader["username"].ToString(),
                                    BookTitle = reader["bookTitle"].ToString(),
                                    BookAuthor = reader["bookAuthor"].ToString(),
                                    Status = reader["status"].ToString(),
                                    Reserved = Convert.ToDateTime(reader["reservedate"]),
                                    Picture = reader["picture"] as byte[]
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception instead of writing to the console
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                db.closeConnection();
            }

            return null;
        }
        public BookReservedModel GetReservedBookByISBNAndUsername(string isbn, string username)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    
                    string query = "SELECT * FROM bookreserved WHERE isbn = @isbn AND username = @username";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@isbn", isbn);
                        command.Parameters.AddWithValue("@username", username);

                        
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new BookReservedModel
                                {
                                    ISBN = reader["isbn"].ToString(),
                                    UserID = reader["userID"].ToString(),
                                    Username = reader["username"].ToString(),
                                    BookTitle = reader["bookTitle"].ToString(),
                                    BookAuthor = reader["bookAuthor"].ToString(),
                                    Status = reader["status"].ToString(),
                                    Reserved = Convert.ToDateTime(reader["reservedate"]),
                                    Picture = reader["picture"] as byte[]
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception instead of writing to the console
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                db.closeConnection();
            }

            return null; // Return null if no matching reserved book is found
        }
        public bool CancelReservedBook(string isbn, string UserName)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    // Delete the reserved book from the bookreserved table
                    string query = "DELETE FROM bookreserved WHERE isbn = @isbn AND username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@isbn", isbn);
                        cmd.Parameters.AddWithValue("@username", UserName);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Return true if the deletion was successful, false otherwise
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception instead of writing to the console
                Console.WriteLine($"Error canceling reserved book: {ex.Message}");
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public int CountUserReservations(string username)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Count the number of reservations for the specified username
                    string query = "SELECT COUNT(*) FROM bookreserved WHERE username = @username";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error counting user reservations: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            return 0; // Return 0 if an error occurs or no reservations are found
        }

    }
}
