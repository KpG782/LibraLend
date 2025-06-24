using FInalLibrarySystem.Database;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FInalLibrarySystem.Database.Users;
using FInalLibrarySystem.Forms.BorrowerList;
using Microsoft.VisualBasic.ApplicationServices;

namespace FInalLibrarySystem
{
    public partial class BookReservation : UserControl
    {
        private Stopwatch loginTimer;
        private Books books; // Assuming you have an instance of the Books class
        private BookBorrows bookBorrows;
        private Users usersManager;
        private string studentOrEmployeeId;  // Add this line
        private BookReserved bookReserved;

        public BookReservation()
        {

            InitializeComponent();
            books = new Books();
            bookBorrows = new BookBorrows(new MyDB());
            usersManager = new Users(); // Initialize the Users class
            bookReserved = new BookReserved();
            loginTimer = new Stopwatch();

            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            dgvBookReserved.CellContentClick += dgvBookReserved_CellContentClick_1;

            //admin
            btnACancel.Visible = false;
            btnAReserve.Visible = false;
            
            DisplayReturnedBooks();
            DisplayReservedBooks();
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }





        private void BookReservation_Load(object sender, EventArgs e)
        {

        }
      


        private void dgvBorrowedDetailsDat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PrimaryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayReservedBooks()
        {
            dgvBookReserved.Rows.Clear();

            // Retrieve reserved books from the BookReserved class
            List<BookReservedModel> reservedBooks = bookReserved.GetAllReservedBooks();



            // Populate the DataGridView with reserved books
            foreach (var reservedBook in reservedBooks)
            {
                dgvBookReserved.Rows.Add(
                    reservedBook.ISBN,
                    reservedBook.UserFullName,
                    reservedBook.BookTitle,
                    reservedBook.BookAuthor,
                    reservedBook.Status,
                    reservedBook.Reserved
                );
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the values from the clicked row
                string selectedISBN = dgvBooks.Rows[e.RowIndex].Cells["SBN"].Value.ToString();
                string selectedTitle = dgvBooks.Rows[e.RowIndex].Cells["Book_Title"].Value.ToString();
                string selectedAuthor = dgvBooks.Rows[e.RowIndex].Cells["Book_Author"].Value.ToString();


                // Set the values in the respective TextBoxes and Labels
                txtBookID.Text = selectedISBN;
                lblBookTitle.Text = selectedTitle;
                lblAuthorName.Text = selectedAuthor;

            }
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblBookTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblAuthorName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void DisplayReturnedBooks()
        {
            // Assuming dgvShow is the DataGridView control where you want to display the books
            dgvBooks.Rows.Clear();

            // Retrieve returned books from the Books class
            List<Book> returnedBooks = books.GetReturnedBooks();

            // Populate the DataGridView with returned books
            foreach (var book in returnedBooks)
            {
                dgvBooks.Rows.Add(book.Title, book.ISBN, book.Category, book.Author, book.Status, book.Copyright);
            }
        }






        private void txtBookID_TextChanged_1(object sender, EventArgs e)
        {


            // Ensure the user has entered a valid ISBN
            string isbn = txtBookID.Text.Trim();

            // Retrieve the reserved book by ISBN and User ID
            BookReservedModel reservedBook = bookReserved.GetReservedBookByISBN(isbn);


            // Retrieve book details from the database
            FInalLibrarySystem.Database.Book book = books.GetBookDetailsByISBN(isbn);

            // Update labels with book details or show not available
            if (book != null)
            {
                lblBookTitle.Text = book.Title;
                lblAuthorName.Text = book.Author;
                pbPicture.Image = ByteArrayToImage(book.Cover);
                
            }
            else
            {
                // Clear labels if the book is not found
                lblBookTitle.Text = "Book not available";
                lblAuthorName.Text = "Author not available";
                pbPicture.Image = null;
            }
        }

        private void PrimaryPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtUserID_TextChanged_1(object sender, EventArgs e)
        {
            studentOrEmployeeId = txtUserID.Text.Trim();  // Update the class-level variable

            // Retrieve user details from the database based on student or employee ID
            Users.User user = usersManager.GetUserByStudentOrEmployeeId(studentOrEmployeeId);

            // Update labels with user details or show not available
            if (user != null)
            {
                lblUserName.Text = $"{user.FirstName} {user.LastName}";
            }
            else
            {
                // Clear labels if the user is not found
                lblUserName.Text = "User not available";
            }
        }

        private void btnReserve_Click_1(object sender, EventArgs e)
        {

                // Get values from UI elements
                string isbn = txtBookID.Text.Trim();
            string userId = txtUserID.Text.Trim();
            string title = lblBookTitle.Text;
            string author = lblAuthorName.Text;
            string userFullName = lblUserName.Text;





            // Retrieve borrowed books based on the entered student or employee ID
            BorrowedBook borrowedBook = bookBorrows.GetBorrowedBookByUserID(studentOrEmployeeId);
            // Retrieve user details based on student or employee ID
            Users.User user = usersManager.GetUserByStudentOrEmployeeId(userId);
            // Retrieve book details from the database
            FInalLibrarySystem.Database.Book book = books.GetBookDetailsByISBN(isbn);


            // Check if the user has a debt
            if (user != null && usersManager.HasDebt(userId))
            {
                MessageBox.Show("You cannot borrow/reserve a book as you have an existing debt.", "Debt Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method early
            }

            // Check if the user is a student and has already borrowed 2 books
            if (user.Role == "Student" && (bookReserved.CountUserReservations(userId) + bookBorrows.CountUserBorrows(userId)) >= 2)
            {
                MessageBox.Show("Students can only borrow/reserve up to 2 books.");
                return; // Exit the method early
            }

            // Check if the user is a teacher and has already borrowed 3 books
            if (user.Role == "Teacher" && (bookReserved.CountUserReservations(userId) + bookBorrows.CountUserBorrows(userId)) >= 5)
            {
                MessageBox.Show("Teachers can only borrow/reserve up to 5 books.");
                return; // Exit the method early
            }

            bool isReserved = books.IsBookReserved(isbn);

            if (isReserved)
            {
                MessageBox.Show("The Book is already borrowed/reserved");
                return;
            }


            // Check if both txtUserID and txtBookID are empty
            if (string.IsNullOrWhiteSpace(txtUserID.Text) && string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("User ID and ISBN are required for the update.");
                return; // Exit the method without further processing
            }

            // Check if txtUserID is empty
            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBox.Show("User ID is required for the update.");
                return; // Exit the method without further processing
            }

            // Check if txtBookID is empty
            if (string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("ISBN is required for the update.");
                return; // Exit the method without further processing
            }

            studentOrEmployeeId = txtUserID.Text.Trim();  // Update the class-level variable



            // Check if the selected return date is valid
            DateTime selectedReturnDate = dtpReserve.Value.Date;
            DateTime currentDate = DateTime.Now.Date;
            byte[] picture = book.Cover; // Declare the picture variable = problem to

            try
            {
                loginTimer.Start();

                DateTime reservedDate = dtpReserve.Value;
            string status = "Reserved";

            if (user != null)
            {


                // Now 'user' object contains details like username, department, etc.

                bool updateSuccess = books.UpdateBookStatusByISBN(isbn, "Reserved");

                // Add the reserved book to the bookreserved table
                bool reservationSuccess = bookReserved.AddReservedBook(userId, isbn, title, author, picture, reservedDate, status, userFullName);


                if (reservationSuccess)
                {
                    MessageBox.Show("Book reserved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayReservedBooks();
                    DisplayReturnedBooks();

                        Console.WriteLine($"Reservation took {loginTimer.Elapsed.TotalMilliseconds:F2} milliseconds.");


                        loginTimer.Stop();
                        loginTimer.Reset();

                        // Clear the UI elements after reserving
                        txtBookID.Text = "";
                    txtUserID.Text = "";
                    lblUserName.Text = "";
                    lblBookTitle.Text = "";
                    lblAuthorName.Text = "";
                    pbPicture.Image = null; // Clear the PictureBox image
                }
                // No need for an else block; the AddReservedBook method handles showing error messages
            }
            else
            {
                // Handle the case where the user is not found
                MessageBox.Show("User not found. Please enter a valid student or employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            }
                
    
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            DisplayReservedBooks();
            DisplayReturnedBooks();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            // Get values from UI elements
            string isbn = txtBookID.Text.Trim();
            string userId = txtUserID.Text.Trim();

            // Retrieve user details from the database based on student or employee ID
            Users.User user = usersManager.GetUserByStudentOrEmployeeId(userId);

            // Check if both txtUserID and txtBookID are empty
            if (string.IsNullOrWhiteSpace(txtUserID.Text) && string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("User ID and ISBN are required for cancellation.");
                return; // Exit the method without further processing
            }

            // Check if txtUserID is empty
            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBox.Show("User ID is required for cancellation.");
                return; // Exit the method without further processing
            }

            // Check if txtBookID is empty
            if (string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("ISBN is required for cancellation.");
                return; // Exit the method without further processing
            }



            // Retrieve the reserved book by ISBN and User ID
            BookReservedModel reservedBook = bookReserved.GetReservedBookByISBNAndUsername(isbn, userId);


            // Display a confirmation dialog before cancellation
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Delete the reserved book from the database
                bool cancelSuccess = bookReserved.CancelReservedBook(isbn, userId);

                if (cancelSuccess)
                {
                    //update the status of that book to returned
                    bool updateSuccess = books.UpdateBookStatusByISBN(isbn, "Returned");


                    MessageBox.Show("Reservation canceled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayReservedBooks(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to cancel the reservation. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Clear the UI elements after cancellation
                txtBookID.Text = "";
                txtUserID.Text = "";
                lblUserName.Text = "";
                lblBookTitle.Text = "";
                lblAuthorName.Text = "";
                pbPicture.Image = null; // Clear the PictureBox image
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            string isbn = txtBookID.Text.Trim();
            string userId = txtUserID.Text.Trim();


            // Clear the UI elements after borrowing
            txtBookID.Text = "";
            txtUserID.Text = "";
            lblUserName.Text = "";
            lblBookTitle.Text = "";
            lblAuthorName.Text = "";
            pbPicture.Image = null; // Clear the PictureBox image
        }

        private void dgvBookReserved_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the values from the clicked row
                string selectedISBN = dgvBookReserved.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                string selectedTitle = dgvBookReserved.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                string selectedAuthor = dgvBookReserved.Rows[e.RowIndex].Cells["Author"].Value.ToString();

                // Set the values in the respective TextBoxes and Labels
                txtBookID.Text = selectedISBN;
                lblBookTitle.Text = selectedTitle;
                lblAuthorName.Text = selectedAuthor;
            }
        }

        private void btnACancel_Click(object sender, EventArgs e)
        {
            // Get values from UI elements
            string isbn = txtBookID.Text.Trim();
            string userId = txtUserID.Text.Trim();

            // Retrieve the reserved book by ISBN and User ID
            BookReservedModel reservedBook = bookReserved.GetReservedBookByISBNAndUsername(isbn, userId);


            // Display a confirmation dialog before cancellation
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Delete the reserved book from the database
                bool cancelSuccess = bookReserved.CancelReservedBook(isbn, userId);

                if (cancelSuccess)
                {
                    //update the status of that book to returned
                    bool updateSuccess = books.UpdateBookStatusByISBN(isbn, "Returned");


                    MessageBox.Show("Reservation canceled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayReservedBooks(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to cancel the reservation. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Clear the UI elements after cancellation
                txtBookID.Text = "";
                txtUserID.Text = "";
                lblUserName.Text = "";
                lblBookTitle.Text = "";
                lblAuthorName.Text = "";
                pbPicture.Image = null; // Clear the PictureBox image
            }
        }

        private void btnAReserve_Click(object sender, EventArgs e)
        {

            // Get values from UI elements
            string isbn = txtBookID.Text.Trim();
            string userId = txtUserID.Text.Trim();
            string title = lblBookTitle.Text;
            string author = lblAuthorName.Text;
            string userFullName = lblUserName.Text;





            // Retrieve borrowed books based on the entered student or employee ID
            BorrowedBook borrowedBook = bookBorrows.GetBorrowedBookByUserID(studentOrEmployeeId);
            // Retrieve user details based on student or employee ID
            Users.User user = usersManager.GetUserByStudentOrEmployeeId(userId);
            // Retrieve book details from the database
            FInalLibrarySystem.Database.Book book = books.GetBookDetailsByISBN(isbn);


            bool isReserved = books.IsBookReserved(isbn);

            if (isReserved)
            {
                MessageBox.Show("The Book is already borrowed/reserved");
                return;
            }


            // Check if both txtUserID and txtBookID are empty
            if (string.IsNullOrWhiteSpace(txtUserID.Text) && string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("User ID and ISBN are required for the update.");
                return; // Exit the method without further processing
            }

            // Check if txtUserID is empty
            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBox.Show("User ID is required for the update.");
                return; // Exit the method without further processing
            }

            // Check if txtBookID is empty
            if (string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("ISBN is required for the update.");
                return; // Exit the method without further processing
            }

            studentOrEmployeeId = txtUserID.Text.Trim();  // Update the class-level variable



            // Check if the selected return date is valid
            DateTime selectedReturnDate = dtpReserve.Value.Date;
            DateTime currentDate = DateTime.Now.Date;
            byte[] picture = book.Cover; // Declare the picture variable = problem to

            try
            {
                loginTimer.Start();

                DateTime reservedDate = dtpReserve.Value;
                string status = "Reserved";

                if (user != null)
                {


                    // Now 'user' object contains details like username, department, etc.

                    bool updateSuccess = books.UpdateBookStatusByISBN(isbn, "Reserved");

                    // Add the reserved book to the bookreserved table
                    bool reservationSuccess = bookReserved.AddReservedBook(userId, isbn, title, author, picture, reservedDate, status, userFullName);


                    if (reservationSuccess)
                    {
                        MessageBox.Show("Book reserved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayReservedBooks();
                        DisplayReturnedBooks();

                        Console.WriteLine($"Reservation took {loginTimer.Elapsed.TotalMilliseconds:F2} milliseconds.");


                        loginTimer.Stop();
                        loginTimer.Reset();

                        // Clear the UI elements after reserving
                        txtBookID.Text = "";
                        txtUserID.Text = "";
                        lblUserName.Text = "";
                        lblBookTitle.Text = "";
                        lblAuthorName.Text = "";
                        pbPicture.Image = null; // Clear the PictureBox image
                    }
                    // No need for an else block; the AddReservedBook method handles showing error messages
                }
                else
                {
                    // Handle the case where the user is not found
                    MessageBox.Show("User not found. Please enter a valid student or employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }


            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbltitleBook_Click(object sender, EventArgs e)
        {
            
        }

        private void lbltitleBook_Click_1(object sender, EventArgs e)
        {
            // Replace 'userIdToLookup' with the actual user ID you want to look up
            int userIdToLookup = 21; // Replace with the actual user ID

            // Call GetUserById to get the user by ID
            Users.User user = usersManager.GetUserById(userIdToLookup);

            string password = user.Password;

            // Ask the user if they are an admin
            DialogResult result = MessageBox.Show("Are you an admin?", "Admin Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Prompt the user for the admin password
                string enteredPassword = Microsoft.VisualBasic.Interaction.InputBox("Enter admin password:", "Admin Password", "");

                // Check if the entered password matches the stored password
                if (enteredPassword == user.Password)
                {
                    // Password is correct, update visibility
                    btnACancel.Visible = true;
                    btnAReserve.Visible = true;
                }
                else
                {
                    // Password is incorrect, handle accordingly
                    MessageBox.Show("Incorrect admin password. Access denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Optionally, you can perform additional actions, such as logging the attempt or blocking access.
                }
            }
            else
            {
                // User is not an admin, handle accordingly
                // For example, you might want to hide admin-related controls
                btnACancel.Visible = false;
                btnAReserve.Visible = false;
            }
        }
    }
}
