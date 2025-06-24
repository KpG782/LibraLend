using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalLibrarySystem.Database
{
    internal class Users
    {

        internal class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MiddleInitial { get; set; }
            public string Role { get; set; }
            public string Department { get; set; }
            public string StudentID { get; set; }
            public string EmployeeID { get; set; }
            public string Section { get; set; }
            public string Year { get; set; }
            public byte[] Picture { get; set; }

            public int Money { get; set; }

            public int Debt { get; set; }

        }


        public List<User> GetAllUsersOrderedByLatest()
        {
            List<User> users = GetAllUsers(); // Fetch all users

            // Use the List.Sort method with a custom IComparer
            users.Sort(new UserComparer());

            return users;
        }

        // Custom comparer to sort users based on ID in descending order
        public class UserComparer : IComparer<User>
        {
            public int Compare(User x, User y)
            {
                // Compare by ID in descending order
                return y.Id.CompareTo(x.Id);
            }
        }


        // Add a method to retrieve user by ID
        public User GetUserById(int userId)
        {
            User user = null;

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    
                    string query = "SELECT * FROM `app_users` WHERE `id` = @userId";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.Add("@userId", MySqlDbType.Int32).Value = userId;

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            //                            MessageBox.Show("The user id should be : " + userId);

                            DataRow row = table.Rows[0];

                           
                            user = new User
                            {
                                
                                Id = Convert.ToInt32(row["id"]),
                                Username = row["username"].ToString(),
                                Password = row["password"].ToString(),
                                Email = row["email"].ToString(),
                                FirstName = row["first_name"].ToString(),
                                LastName = row["last_name"].ToString(),
                                MiddleInitial = row["middle_initial"].ToString(),
                                Role = row["role"].ToString(),
                                Department = row["department"].ToString(),
                                StudentID = row["studentID"].ToString(),
                                EmployeeID = row["employeeID"].ToString(),
                                Section = row["section"].ToString(),
                                Year = row["year"].ToString(),
                                Picture = (byte[])row["picture"],
                                Money = Convert.ToInt32(row["money"])

                            };
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

            return user;
        }

        private MyDB db;

        public Users()
        {
            db = new MyDB();
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT * FROM app_users";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        foreach (DataRow row in table.Rows)
                        {
                            User user = new User
                            {
                                Id = Convert.ToInt32(row["id"]),
                                Username = row["username"].ToString(),
                                Password = row["password"].ToString(),
                                Email = row["email"].ToString(),
                                FirstName = row["first_name"].ToString(),
                                LastName = row["last_name"].ToString(),
                                MiddleInitial = row["middle_initial"].ToString(),
                                Role = row["role"].ToString(),
                                Department = row["department"].ToString(),
                                StudentID = row["studentID"].ToString(),
                                EmployeeID = row["employeeID"].ToString(),
                                Section = row["section"].ToString(),
                                Year = row["year"].ToString(),
                                Picture = (byte[])row["picture"]
                            };

                            users.Add(user);
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

            return users;
        }


        //getallstudents only
        public List<User> GetAllStudents()
        {
            List<User> students = new List<User>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT * FROM app_users WHERE role = 'Student'";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        foreach (DataRow row in table.Rows)
                        {
                            User student = new User
                            {
                                Id = Convert.ToInt32(row["id"]),
                                Username = row["username"].ToString(),
                                Password = row["password"].ToString(),
                                Email = row["email"].ToString(),
                                FirstName = row["first_name"].ToString(),
                                LastName = row["last_name"].ToString(),
                                MiddleInitial = row["middle_initial"].ToString(),
                                Role = row["role"].ToString(),
                                Department = row["department"].ToString(),
                                StudentID = row["studentID"].ToString(),
                                EmployeeID = row["employeeID"].ToString(),
                                Section = row["section"].ToString(),
                                Year = row["year"].ToString(),
                                Picture = (byte[])row["picture"]
                            };

                            students.Add(student);
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
                db.closeConnection(); // Close the database connection
            }

            return students;
        }


        //get all teachers
        public List<User> GetAllTeachers()
        {
            List<User> teachers = new List<User>();

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT * FROM app_users WHERE role = 'Teacher'";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        foreach (DataRow row in table.Rows)
                        {
                            User teacher = new User
                            {
                                Id = Convert.ToInt32(row["id"]),
                                Username = row["username"].ToString(),
                                Password = row["password"].ToString(),
                                Email = row["email"].ToString(),
                                FirstName = row["first_name"].ToString(),
                                LastName = row["last_name"].ToString(),
                                MiddleInitial = row["middle_initial"].ToString(),
                                Role = row["role"].ToString(),
                                Department = row["department"].ToString(),
                                StudentID = row["studentID"].ToString(),
                                EmployeeID = row["employeeID"].ToString(),
                                Section = row["section"].ToString(),
                                Year = row["year"].ToString(),
                                Picture = (byte[])row["picture"]
                            };

                            teachers.Add(teacher);
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
                db.closeConnection(); // Close the database connection
            }

            return teachers;
        }


        public void InsertUserIntoDatabase(User user)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    // Use a parameterized INSERT query to avoid SQL injection
                    string query = "INSERT INTO app_users (username, password, email, first_name, last_name, middle_initial, role, " +
                                   "department, studentID, employeeID, section, year, money) " +
                                   "VALUES (@username, @password, @email, @firstName, @lastName, @middleInitial, " +
                                   "@role, @department, @studentID, @employeeID, @section, @year, @money)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", user.Password);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                        cmd.Parameters.AddWithValue("@lastName", user.LastName);
                        cmd.Parameters.AddWithValue("@middleInitial", user.MiddleInitial);
                        cmd.Parameters.AddWithValue("@role", user.Role);
                        cmd.Parameters.AddWithValue("@department", user.Department);
                        cmd.Parameters.AddWithValue("@studentID", user.StudentID);
                        cmd.Parameters.AddWithValue("@employeeID", user.EmployeeID);
                        cmd.Parameters.AddWithValue("@section", user.Section);
                        cmd.Parameters.AddWithValue("@year", user.Year);
                        cmd.Parameters.AddWithValue("@money", user.Money);  // Assuming 'money' is the property in your User class
                                                                            // Add other parameters as needed

                        // Execute the query
                        cmd.ExecuteNonQuery();
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
        }

        // Method to check if a username is already taken
        public bool IsUsernameTaken(string username)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT COUNT(*) FROM app_users WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());


                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error: {ex.Message}");
                return true; // Assume an error, treat it as username taken
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }
        }

        // Method to check if an employee ID is already taken
        public bool IsEmployeeIdTaken(string employeeId)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT COUNT(*) FROM app_users WHERE employeeID = @employeeId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error: {ex.Message}");
                return true; // Assume an error, treat it as employee ID taken
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }
        }


        // Method to check if a student ID is already taken
        public bool IsStudentIdTaken(string studentId)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT COUNT(*) FROM app_users WHERE studentID = @studentId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error: {ex.Message}");
                return true; // Assume an error, treat it as student ID taken
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }
        }

        //checker for the borrowing system
        public User GetUserByStudentOrEmployeeId(string studentOrEmployeeId)
        {
            User user = null;

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT * FROM `app_users` WHERE `studentID` = @id OR `employeeID` = @id";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.Add("@id", MySqlDbType.VarChar).Value = studentOrEmployeeId;

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            DataRow row = table.Rows[0];

                            user = new User
                            {
                                Id = Convert.ToInt32(row["id"]),
                                Username = row["username"].ToString(),
                                Password = row["password"].ToString(),
                                Email = row["email"].ToString(),
                                FirstName = row["first_name"].ToString(),
                                LastName = row["last_name"].ToString(),
                                MiddleInitial = row["middle_initial"].ToString(),
                                Role = row["role"].ToString(),
                                Department = row["department"].ToString(),
                                StudentID = row["studentID"].ToString(),
                                EmployeeID = row["employeeID"].ToString(),
                                Section = row["section"].ToString(),
                                Year = row["year"].ToString(),
                                Picture = (byte[])row["picture"],
                                Money = Convert.ToInt32(row["money"])
                            };
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

            return user;
        }

        public bool IsStudent(string studentOrEmployeeId)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT role FROM `app_users` WHERE `studentID` = @id OR `employeeID` = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = studentOrEmployeeId;

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Check if the role is 'Student'
                            return result.ToString().Equals("Student", StringComparison.OrdinalIgnoreCase);
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

            return false; // Default to false if there is an error or no matching user found
        }


        //get user money in bookreturning
        public int GetUserMoneyByUserId(string userId)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT money FROM app_users WHERE studentID = @userId OR employeeID = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int money))
                        {
                            return money;
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

            return 0; // Default to 0 if there is an error or no matching user found
        }

        public bool UpdateUserMoneyByUserId(string userId, int updatedMoney)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string updateQuery = "UPDATE app_users SET money = @UpdatedMoney WHERE studentID = @UserId OR employeeID = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@UpdatedMoney", updatedMoney);
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, show error message, etc.)
                Console.WriteLine($"Error updating user money: {ex.Message}");
                return false;
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }
        }

        public bool AddToDebt(string userId, int amount)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string updateQuery = "UPDATE app_users SET debt = debt + @Amount WHERE studentID = @UserId OR employeeID = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, show error message, etc.)
                Console.WriteLine($"Error adding debt: {ex.Message}");
                return false;
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }
        }

        public bool HasDebt(string userId)
        {
            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT debt FROM app_users WHERE studentID = @UserId OR employeeID = @UserId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int debt))
                        {
                            return debt > 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, show error message, etc.)
                Console.WriteLine($"Error checking debt status: {ex.Message}");
            }
            finally
            {
                db.closeConnection(); // Close the database connection
            }

            return false; // Default to false if there is an error or no matching user found
        }

        //bubble sorting algorithm
        public List<User> GetAllTeachersOrderedByLatest()
        {
            List<User> teachers = GetAllTeachers();

            // Bubble Sort
            for (int i = 0; i < teachers.Count - 1; i++)
            {
                for (int j = 0; j < teachers.Count - i - 1; j++)
                {
                    // Compare teachers based on ID (you can change this to another criterion if needed)
                    if (teachers[j].Id < teachers[j + 1].Id)
                    {
                        // Swap teachers
                        User temp = teachers[j];
                        teachers[j] = teachers[j + 1];
                        teachers[j + 1] = temp;
                    }
                }
            }

            return teachers;
        }

        //using mergesort
        public List<User> GetAllStudentsOrderedByLatest()
        {
            List<User> students = GetAllStudents();

            // Use Merge Sort
            students = MergeSort(students);

            return students;
        }

        private List<User> MergeSort(List<User> userList)
        {
            if (userList.Count <= 1)
                return userList;

            int middle = userList.Count / 2;
            List<User> left = userList.GetRange(0, middle);
            List<User> right = userList.GetRange(middle, userList.Count - middle);

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private List<User> Merge(List<User> left, List<User> right)
        {
            List<User> result = new List<User>();
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                // Compare students based on ID (you can change this to another criterion if needed)
                if (left[leftIndex].Id >= right[rightIndex].Id)
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            // Add remaining elements from left and right lists
            while (leftIndex < left.Count)
            {
                result.Add(left[leftIndex]);
                leftIndex++;
            }

            while (rightIndex < right.Count)
            {
                result.Add(right[rightIndex]);
                rightIndex++;
            }

            return result;
        }



        public void SetAdminVisibility(BorrowerList borrowerList, bool isVisible)
        {
            if (borrowerList != null)
            {
                // Assuming adminAll1 is a control in BorrowerList
                borrowerList.SetAdminVisibility(isVisible);
            }
            else
            {
                MessageBox.Show("Error in Setting Admin Visibility to true");
                // Handle the case where borrowerList is null (optional)
            }

        }

        public User GetUserByStatus(int userId)
        {
            User user = null;

            try
            {
                using (MySqlConnection connection = db.getConnection())
                {
                    db.openConnection(); // Open the database connection

                    string query = "SELECT * FROM `app_users` WHERE `id` = @userId";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.Add("@userId", MySqlDbType.Int32).Value = userId;

                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            DataRow row = table.Rows[0];

                            user = new User
                            {
                                Id = Convert.ToInt32(row["id"]),
                                Username = row["username"].ToString(),
                                Password = row["password"].ToString(),
                                Email = row["email"].ToString(),
                                FirstName = row["first_name"].ToString(),
                                LastName = row["last_name"].ToString(),
                                MiddleInitial = row["middle_initial"].ToString(),
                                Role = row["role"].ToString(),
                                Department = row["department"].ToString(),
                                StudentID = row["studentID"].ToString(),
                                EmployeeID = row["employeeID"].ToString(),
                                Section = row["section"].ToString(),
                                Year = row["year"].ToString(),
                                Picture = (byte[])row["picture"],
                                Money = Convert.ToInt32(row["money"])
                            };
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

            return user;
        }
    }
}
