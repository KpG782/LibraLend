using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FInalLibrarySystem.Database.Users;

namespace FInalLibrarySystem.Database
{

    //contructor
    public class BorrowedBook
    {
        public string ISBN { get; set; }
        public string UserID { get; set; }
        public string Username { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public DateTime Borrowed { get; set; }
        public DateTime Returned { get; set; }
        public DateTime Reserved { get; set; }
        public byte[] Picture { get; set; }
    }



    internal class BookBorrows
    {
        private MyDB db;

        public BookBorrows(MyDB myDb)
        {
            db = myDb;
        }

        public delegate void BookBorrowedHandler();
        public event BookBorrowedHandler BookBorrowed;

        public bool BorrowBook(string isbn, string userID, string username, string bookTitle, string bookAuthor, DateTime borrowedDate, DateTime returnedDate, DateTime reservedDate, byte[] picture)
        {
            try
            {


                // Check user status and limit the number of books a student can borrow
                //User user = new Users().GetUserByStudentOrEmployeeId(userID);
                //if (user != null && user.Role == "Student" && CountUserBorrows(userID) >= 2)
                //{
                //    MessageBox.Show("Students can only borrow up to 2 books.");
                //    return false; // Exit the method early
                //}

                //// Get the book's category based on its ISBN
                //string bookCategory = new Books().GetBookCategoryByISBN(isbn);

                //// Check if the book is academic and the user is a student
                //if (bookCategory == "Academic" && user != null)
                //{
                //    MessageBox.Show("Academic books cannot be brought outside.");
                //}

                //if (user != null && user.Role == "Teacher" && CountUserBorrows(userID) >= 5)
                //{
                //    MessageBox.Show("Teachers can only borrow up to 5 books.");
                //    return false; // Exit the method early
                //}

                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    string insertQuery = "INSERT INTO bookborrows (ISBN, userID, username, bookTitle, bookAuthor, borrowed, returned, reserved, picture) " +
                                         "VALUES (@ISBN, @userID, @username, @bookTitle, @bookAuthor, @borrowedDate, @returnedDate, @reservedDate, @picture)";

                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@ISBN", isbn);
                        insertCommand.Parameters.AddWithValue("@userID", userID);
                        insertCommand.Parameters.AddWithValue("@username", username);
                        insertCommand.Parameters.AddWithValue("@bookTitle", bookTitle);
                        insertCommand.Parameters.AddWithValue("@bookAuthor", bookAuthor);
                        insertCommand.Parameters.AddWithValue("@borrowedDate", borrowedDate);
                        insertCommand.Parameters.AddWithValue("@returnedDate", returnedDate);
                        insertCommand.Parameters.AddWithValue("@reservedDate", reservedDate);
                        insertCommand.Parameters.AddWithValue("@picture", picture);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            BookBorrowed?.Invoke();
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("No rows affected. Failed to borrow the book.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }

        // Add this method to the BookBorrows class
        public int CountUserBorrows(string userID)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    string countQuery = "SELECT COUNT(*) FROM bookborrows WHERE userID = @userID";

                    using (MySqlCommand countCommand = new MySqlCommand(countQuery, connection))
                    {
                        countCommand.Parameters.AddWithValue("@userID", userID);

                        int userBorrowCount = Convert.ToInt32(countCommand.ExecuteScalar());
                        return userBorrowCount;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return -1; // Return -1 to indicate an error
            }
            finally
            {
                db.closeConnection();
            }
        }


        public List<BorrowedBook> GetAllBorrowedBooks()
        {
            List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    string query = "SELECT * FROM bookborrows";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        foreach (DataRow row in table.Rows)
                        {
                            BorrowedBook borrowedBook = new BorrowedBook
                            {
                                ISBN = row["ISBN"].ToString(),
                                UserID = row["userID"].ToString(),
                                Username = row["username"].ToString(),
                                BookTitle = row["bookTitle"].ToString(),
                                BookAuthor = row["bookAuthor"].ToString(),
                                Borrowed = Convert.ToDateTime(row["borrowed"]),
                                Returned = Convert.ToDateTime(row["returned"]),
                                Reserved = Convert.ToDateTime(row["reserved"]),
                                Picture = (byte[])row["picture"]
                            };

                            borrowedBooks.Add(borrowedBook);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection();
            }

            return borrowedBooks;
        }

        public BorrowedBook GetBorrowedBookByISBN(string isbn)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    string query = "SELECT * FROM bookborrows WHERE ISBN = @ISBN";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ISBN", isbn);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new BorrowedBook
                                {
                                    ISBN = reader["ISBN"].ToString(),
                                    UserID = reader["userID"].ToString(),
                                    Username = reader["username"].ToString(),
                                    BookTitle = reader["bookTitle"].ToString(),
                                    BookAuthor = reader["bookAuthor"].ToString(),
                                    Borrowed = Convert.ToDateTime(reader["borrowed"]),
                                    Returned = Convert.ToDateTime(reader["returned"]),
                                    Reserved = Convert.ToDateTime(reader["reserved"]),
                                    Picture = (byte[])reader["picture"]
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                db.closeConnection();
            }

            return null;
        }

        public BorrowedBook GetBorrowedBookByUserID(string userID)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    string query = "SELECT * FROM bookborrows WHERE userID = @UserID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new BorrowedBook
                                {
                                    ISBN = reader["ISBN"].ToString(),
                                    UserID = reader["userID"].ToString(),
                                    Username = reader["username"].ToString(),
                                    BookTitle = reader["bookTitle"].ToString(),
                                    BookAuthor = reader["bookAuthor"].ToString(),
                                    Borrowed = Convert.ToDateTime(reader["borrowed"]),
                                    Returned = Convert.ToDateTime(reader["returned"]),
                                    Reserved = Convert.ToDateTime(reader["reserved"]),
                                    Picture = (byte[])reader["picture"]
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                db.closeConnection();
            }

            return null;
        }


        // Method to remove returned book from bookborrows database
        public bool RemoveReturnedBook(string isbn)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to delete the returned book by ISBN
                    string deleteQuery = "DELETE FROM bookborrows WHERE ISBN = @isbn";

                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@isbn", isbn);

                        // Execute the delete query
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        // Return true if the operation is successful
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or notify the user)
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }
        }

        public DateTime GetReturnedDateByBookId(string isbn)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    string query = "SELECT returned FROM bookborrows WHERE ISBN = @ISBN";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ISBN", isbn);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToDateTime(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection();
            }

            // Return DateTime.MinValue if no result or an error occurs
            return DateTime.MinValue;
        }

        // Add this method to check if a book is borrowed
        public bool IsBookBorrowed(string isbn)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    string query = "SELECT COUNT(*) FROM bookborrows WHERE ISBN = @ISBN";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ISBN", isbn);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // Return true if the book is borrowed (count > 0)
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false; // Return false in case of an error
            }
            finally
            {
                db.closeConnection();
            }
        }

        // Add this method to check if a user has borrowed books
        public bool IsUserBorrowed(string userID)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection();

                    string query = "SELECT COUNT(*) FROM bookborrows WHERE userID = @UserID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // Return true if the user has borrowed books (count > 0)
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false; // Return false in case of an error
            }
            finally
            {
                db.closeConnection();
            }
        }


    }

}
