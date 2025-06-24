using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static FInalLibrarySystem.BookList;

namespace FInalLibrarySystem.Database
{


    //constructor
    public class Book
    {
        // Define properties for book information
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public int Copyright { get; set; }
        public string Publisher { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public byte[] Cover { get; set; }
    }

    public class Books
    {

        private MyDB db;

        public Books()
        {
            db = new MyDB();
        }

        // Assuming you have a method to retrieve academic books
        public List<Book> GetAcademicBooks()
        {
            List<Book> academicBooks = new List<Book>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve academic books
                    string query = "SELECT * FROM books WHERE category = 'Academic'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    Id = reader.GetInt32("id"),
                                    Title = reader.GetString("title"),
                                    ISBN = reader.GetString("ISBN"),
                                    Category = reader.GetString("category"),
                                    Author = reader.GetString("author"),
                                    Copyright = reader.GetInt32("copyright"),
                                    Publisher = reader.GetString("publisher"),
                                    Status = reader.GetString("status"),
                                    Description = reader.GetString("description"),
                                    Cover = (byte[])reader["cover"]
                                };
                                academicBooks.Add(book);
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

            return academicBooks;
        }

        // Method to retrieve fictional books
        public List<Book> GetFictionalBooks()
        {
            List<Book> fictionalBooks = new List<Book>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve fictional books
                    string query = "SELECT * FROM books WHERE category = 'Fiction'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    Id = reader.GetInt32("id"),
                                    Title = reader.GetString("title"),
                                    ISBN = reader.GetString("ISBN"),
                                    Category = reader.GetString("category"),
                                    Author = reader.GetString("author"),
                                    Copyright = reader.GetInt32("copyright"),
                                    Publisher = reader.GetString("publisher"),
                                    Status = reader.GetString("status"),
                                    Description = reader.GetString("description"),
                                    Cover = (byte[])reader["cover"]
                                };
                                fictionalBooks.Add(book);
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

            return fictionalBooks;
        }

        // Method to retrieve non-fictional books
        public List<Book> GetNonFictionalBooks()
        {
            List<Book> nonFictionalBooks = new List<Book>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve non-fictional books
                    string query = "SELECT * FROM books WHERE category = 'Non-Fiction'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    Id = reader.GetInt32("id"),
                                    Title = reader.GetString("title"),
                                    ISBN = reader.GetString("ISBN"),
                                    Category = reader.GetString("category"),
                                    Author = reader.GetString("author"),
                                    Copyright = reader.GetInt32("copyright"),
                                    Publisher = reader.GetString("publisher"),
                                    Status = reader.GetString("status"),
                                    Description = reader.GetString("description"),
                                    Cover = (byte[])reader["cover"]
                                };
                                nonFictionalBooks.Add(book);
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

            return nonFictionalBooks;
        }


        // Method to retrieve all books
        public List<Book> GetAllBooks()
        {
            List<Book> allBooks = new List<Book>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve all books
                    string query = "SELECT * FROM books";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    Id = reader.GetInt32("id"),
                                    Title = reader.GetString("title"),
                                    ISBN = reader.GetString("ISBN"),
                                    Category = reader.GetString("category"),
                                    Author = reader.GetString("author"),
                                    Copyright = reader.GetInt32("copyright"),
                                    Publisher = reader.GetString("publisher"),
                                    Status = reader.GetString("status"),
                                    Description = reader.GetString("description"),
                                    Cover = (byte[])reader["cover"]
                                };
                                allBooks.Add(book);
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

            return allBooks;
        }



        // Get book details by ISBN
        public Book GetBookDetailsByISBN(string isbn)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve book details by ISBN
                    string query = "SELECT * FROM books WHERE ISBN = @isbn";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@isbn", isbn);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Create a Book object with retrieved details
                                return new Book
                                {
                                    Id = reader.GetInt32("id"),
                                    Title = reader.GetString("title"),
                                    Author = reader.GetString("author"),
                                    Cover = (byte[])reader["cover"],
                                    Status = reader.GetString("status"),  // Include the status field

                                    // Add other properties as needed
                                };
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

            return null; // Return null if the book is not found or an error occurs
        }


        public bool UpdateBookStatus(int bookID, string newStatus)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to update the book status by ID
                    string updateQuery = "UPDATE books SET status = @newStatus WHERE id = @bookID";

                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@newStatus", newStatus);
                        updateCommand.Parameters.AddWithValue("@bookID", bookID);

                        // Execute the update query
                        int rowsAffected = updateCommand.ExecuteNonQuery();

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

        public List<Book> GetReturnedBooks()
        {
            List<Book> returnedBooks = new List<Book>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve returned books
                    string query = "SELECT * FROM books WHERE status = 'Returned'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    Id = reader.GetInt32("id"),
                                    Title = reader.GetString("title"),
                                    ISBN = reader.GetString("ISBN"),
                                    Category = reader.GetString("category"),
                                    Author = reader.GetString("author"),
                                    Copyright = reader.GetInt32("copyright"),
                                    Publisher = reader.GetString("publisher"),
                                    Status = reader.GetString("status"),
                                    Description = reader.GetString("description"),
                                    Cover = (byte[])reader["cover"]
                                };
                                returnedBooks.Add(book);
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

            return returnedBooks;
        }


        // Method to retrieve borrowed books
        public List<Book> GetBorrowedBooks()
        {
            List<Book> borrowedBooks = new List<Book>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve borrowed books
                    string query = "SELECT * FROM books WHERE status = 'Borrowed'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    Id = reader.GetInt32("id"),
                                    Title = reader.GetString("title"),
                                    ISBN = reader.GetString("ISBN"),
                                    Category = reader.GetString("category"),
                                    Author = reader.GetString("author"),
                                    Copyright = reader.GetInt32("copyright"),
                                    Publisher = reader.GetString("publisher"),
                                    Status = reader.GetString("status"),
                                    Description = reader.GetString("description"),
                                    Cover = (byte[])reader["cover"]
                                };
                                borrowedBooks.Add(book);
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

            return borrowedBooks;
        }


        // Method to update book status based on ISBN
        public bool UpdateBookStatusByISBN(string isbn, string newStatus)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to update the book status by ISBN
                    string updateQuery = "UPDATE books SET status = @newStatus WHERE ISBN = @isbn";

                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@newStatus", newStatus);
                        updateCommand.Parameters.AddWithValue("@isbn", isbn);

                        // Execute the update query
                        int rowsAffected = updateCommand.ExecuteNonQuery();

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

        // Function to check if a book with a given ISBN is reserved
        public bool IsBookReserved(string isbn)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Query to retrieve the status of the book with the given ISBN
                    string query = "SELECT status FROM books WHERE ISBN = @isbn";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@isbn", isbn);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Check if the status is "Reserved"
                                string status = reader.GetString("status");
                                return status.Equals("Reserved", StringComparison.OrdinalIgnoreCase);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or notify the user)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            // Return false if an error occurs or the book is not found
            return false;
        }

        // Method to get the book category by ISBN
        public string GetBookCategoryByISBN(string isbn)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to retrieve the category of the book by ISBN
                    string query = "SELECT category FROM books WHERE ISBN = @isbn";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@isbn", isbn);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or notify the user)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            // Return null if the category is not found or an error occurs
            return null;
        }


        //-----------------------------------------------------
        //counters
        public int CountReturnedBooks()
        {
            int returnedBooksCount = 0;

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to count returned books
                    string query = "SELECT COUNT(*) FROM books WHERE status = 'Returned'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Execute the query and get the count
                        returnedBooksCount = Convert.ToInt32(command.ExecuteScalar());
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

            return returnedBooksCount;
        }


        //counter
        public int CountBorrowedBooks()
        {
            int borrowedBooksCount = 0;

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to count borrowed books
                    string query = "SELECT COUNT(*) FROM books WHERE status = 'Borrowed'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Execute the query and get the count
                        borrowedBooksCount = Convert.ToInt32(command.ExecuteScalar());
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

            return borrowedBooksCount;
        }


        //counter
        public int CountReservedBooks()
        {
            int reservedBooksCount = 0;

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to count reserved books
                    string query = "SELECT COUNT(*) FROM books WHERE status = 'Reserved'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Execute the query and get the count
                        reservedBooksCount = Convert.ToInt32(command.ExecuteScalar());
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

            return reservedBooksCount;
        }




        //count-------------------------------------
        public int CountFictionalBooks()
        {
            int fictionalBooksCount = 0;

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to count fictional books
                    string query = "SELECT COUNT(*) FROM books WHERE category = 'Fiction'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Execute the query and get the count
                        fictionalBooksCount = Convert.ToInt32(command.ExecuteScalar());
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

            return fictionalBooksCount;
        }

        //
        public int CountNonFictionalBooks()
        {
            int nonFictionalBooksCount = 0;

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to count non-fictional books
                    string query = "SELECT COUNT(*) FROM books WHERE category = 'Non-Fiction'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Execute the query and get the count
                        nonFictionalBooksCount = Convert.ToInt32(command.ExecuteScalar());
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

            return nonFictionalBooksCount;
        }

        //academic
        public int CountAcademicBooks()
        {
            int academicBooksCount = 0;

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Modify the query to count academic books
                    string query = "SELECT COUNT(*) FROM books WHERE category = 'Academic'";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Execute the query and get the count
                        academicBooksCount = Convert.ToInt32(command.ExecuteScalar());
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

            return academicBooksCount;
        }


    }

}



