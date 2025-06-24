using FInalLibrarySystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using static FInalLibrarySystem.Database.Users;
using Microsoft.VisualBasic.ApplicationServices;

namespace FInalLibrarySystem
{

    public partial class BookReturning : UserControl
    {
        private Books books; // Assuming you have an instance of the Books class
        private BookBorrows bookBorrows;
        private Users usersManager;
        private string studentOrEmployeeId;  // Add this line
        private Stopwatch loginTimer;
        public BookReturning()
        {
            InitializeComponent();
            books = new Books();
            bookBorrows = new BookBorrows(new MyDB());
            usersManager = new Users(); // Initialize the Users class
            DisplayBooks();
            DisplayBookBorrows();
            loginTimer = new Stopwatch();

            // Hide the pnlReceipt when the form loads
            pnlReceipt.Visible = false;
            pnlPlay1.Visible = false;
            btnAReturn.Visible = false;

        }

        // Update the DisplayReturnedBooks method in the BookReturning class
        private void DisplayBooks()
        {
            // Assuming dgvShow is the DataGridView control where you want to display the books
            dgvBooks.Rows.Clear();

            // Retrieve returned books from the Books class
            List<Book> borrowedBooks = books.GetBorrowedBooks();

            // Populate the DataGridView with returned books
            foreach (var book in borrowedBooks)
            {
                dgvBooks.Rows.Add(book.Title, book.ISBN, book.Category, book.Author, book.Status, book.Copyright);
            }
        }

        private void DisplayBookBorrows()
        {
            // Assuming dgvBookBorrows is the DataGridView control where you want to display borrowed books
            dgvBookBorrow.Rows.Clear();

            // Retrieve all borrowed books from the BookBorrows class
            List<BorrowedBook> borrowedBooks = bookBorrows.GetAllBorrowedBooks();

            // Populate the DataGridView with borrowed books
            foreach (var borrowedBook in borrowedBooks)
            {
                dgvBookBorrow.Rows.Add(
                    borrowedBook.Username,
                    borrowedBook.ISBN,
                    borrowedBook.BookTitle,
                    borrowedBook.BookAuthor,
                    borrowedBook.Borrowed,
                    borrowedBook.Returned,
                    borrowedBook.Reserved
                // Add other columns as needed
                );
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IssueIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            //dito ko lagay yung load
            //pnlReceipt.Visible = true; 
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ReturnButton_Click_1(object sender, EventArgs e)
        {
            //pnlReceiptForm.Visible=true;
        }

        private void pnlReceiptForm_Load(object sender, EventArgs e)
        {

        }

        private void PrimaryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbPicture_Click(object sender, EventArgs e)
        {

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



        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }



        private void dtpReturn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblSUserID_Click(object sender, EventArgs e)
        {

        }

        private void lblSUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblSBookID_Click(object sender, EventArgs e)
        {

        }

        private void lblSBookTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblSAuthor_Click(object sender, EventArgs e)
        {

        }

        private void lblSBorrowedDate_Click(object sender, EventArgs e)
        {

        }

        private void lblSReturnedDate_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void lblUserMoney_Click(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {


        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pnlReceipt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            pnlReceipt.Visible=false;
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {

           
        }

        private void txtBookID_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtUserID_TextChanged_1(object sender, EventArgs e)
        {
            studentOrEmployeeId = txtUserID.Text.Trim();  // Update the class-level variable

            // Retrieve borrowed books based on the entered student or employee ID
            BorrowedBook borrowedBook = bookBorrows.GetBorrowedBookByUserID(studentOrEmployeeId);

            // Update labels with user details or show not available
            if (borrowedBook != null)
            {
                // Display book information in the corresponding labels and picture box
                lblAuthorName.Text = borrowedBook.BookAuthor;
                lblBookTitle.Text = borrowedBook.BookTitle;

                // Check if the Cover property is not null before assigning to the PictureBox
                if (borrowedBook.Picture != null && borrowedBook.Picture.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(borrowedBook.Picture))
                    {
                        pbPicture.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Set a default image or handle the case where the cover is not available
                }

                // Synchronize ISBN
                txtBookID.Text = borrowedBook.ISBN;
            }
            else
            {
                // Clear labels and picture box if the user is not found or has no borrowed books
                lblAuthorName.Text = "Author Not Available";
                lblBookTitle.Text = "Book Not Available";
                lblUserName.Text = "Username Not Available";
                pbPicture.Image = null;
            }
        }

       
        //confirm button
        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            string bookID = txtBookID.Text.Trim();
            string userID = txtUserID.Text.Trim();

            // Retrieve the returned date of the book
            DateTime returnedDate = bookBorrows.GetReturnedDateByBookId(bookID);

            // Calculate the days ahead
            int daysAhead = (int)(dtpReturn.Value - returnedDate).TotalDays;


            // Calculate deduction for late return (assuming PHP20 deduction per day)
            int lateReturnDeduction = daysAhead * 20;


            int currentMoney = usersManager.GetUserMoneyByUserId(userID);
            // Deduct the entered amount from the user's money
            int updatedMoney = currentMoney - lateReturnDeduction;

            if (updatedMoney < 0)
    {
        DialogResult result = MessageBox.Show(
            $"Transaction failed. Insufficient funds. Do you want to add the amount to your debt?",
            "Insufficient Funds",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes)
        {
            // Calculate the remaining amount after deducting the user's money
            int remainingAmount = Math.Abs(updatedMoney);

            // Pass the remaining amount to the AddToDebt method
            bool debtAdded = usersManager.AddToDebt(userID, remainingAmount);

            if (debtAdded)
            {
                MessageBox.Show($"Added {remainingAmount} to your debt. You can return the book.");
                // Proceed with the book return process (update book status, remove from database, etc.)
                ProcessBookReturn(bookID);
            }
            else
            {
                MessageBox.Show("Failed to add the amount to your debt.");
            }
        }
        else
        {
            MessageBox.Show("Transaction canceled.");
        }

        return; // Exit the method without further processing
    }


            // Update user money in the database
            bool moneyUpdated = usersManager.UpdateUserMoneyByUserId(userID, updatedMoney);

            if (moneyUpdated)
            {
                MessageBox.Show($"Deducted {lateReturnDeduction} from user's account. Updated money: {updatedMoney}");


                // Update the book status to "Returned" in the Books class using ISBN
                bool isBookReturned = books.UpdateBookStatusByISBN(bookID, "Returned");

                if (isBookReturned)
                {
                    // Remove the returned book from the bookborrows database
                    bool isBookRemoved = bookBorrows.RemoveReturnedBook(bookID);

                    if (isBookRemoved)
                    {

                        // Display a message indicating successful return and removal
                        MessageBox.Show("Book returned and removed successfully.");

                        // Clear the UI elements after borrowing
                        txtBookID.Text = "";
                        txtUserID.Text = "";
                        lblUserName.Text = "";
                        lblBookTitle.Text = "";
                        lblAuthorName.Text = "";
                        dtpReturn.Value = DateTime.Now; // Reset the DateTimePicker value
                        pbPicture.Image = null; // Clear the PictureBox image

                        // Refresh the DataGridView controls to reflect the changes
                        DisplayBooks();
                        DisplayBookBorrows();


                    }
                    else
                    {
                        // Display a message if removing the book fails
                        MessageBox.Show("Failed to remove the returned book from bookborrows database.");
                    }
                }

                // Hide the receipt panel after the transaction is successfully finished
                pnlReceipt.Visible = false;
            }
            else
            {
                MessageBox.Show("Failed to update user money.");
            }
        }

        private void ProcessBookReturn(string bookID)
        {
            // Update the book status to "Returned" in the Books class using ISBN
            bool isBookReturned = books.UpdateBookStatusByISBN(bookID, "Returned");

            if (isBookReturned)
            {
                bool isBookRemoved = bookBorrows.RemoveReturnedBook(bookID);

                if (isBookRemoved)
                {
                    // Display success message
                    MessageBox.Show("Book returned and removed successfully.");

                    // Clear the UI elements after borrowing
                    txtBookID.Text = "";
                    txtUserID.Text = "";
                    lblUserName.Text = "";
                    lblBookTitle.Text = "";
                    lblAuthorName.Text = "";
                    dtpReturn.Value = DateTime.Now; // Reset the DateTimePicker value
                    pbPicture.Image = null; // Clear the PictureBox image

                    // Refresh the DataGridView controls to reflect the changes
                    DisplayBooks();
                    DisplayBookBorrows();
                }
                else
                {
                    MessageBox.Show("Failed to remove the returned book from bookborrows database.");
                }
            }
            else
            {
                MessageBox.Show("Failed to update book status.");
            }

            // Hide the receipt panel after the transaction is successfully finished
            pnlReceipt.Visible = false;
        }

        private void btnAddToDebt_Click(object sender, EventArgs e)
        {

        }

        private void dgvBookBorrow_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Get the values from the clicked row
            string selectedISBN = dgvBookBorrow.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
            string selectedTitle = dgvBookBorrow.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            string selectedAuthor = dgvBookBorrow.Rows[e.RowIndex].Cells["Author"].Value.ToString();

            // Set the values in the respective TextBoxes and Labels
            txtBookID.Text = selectedISBN;
            lblBookTitle.Text = selectedTitle;
            lblAuthorName.Text = selectedAuthor;
        }

        private void dgvBooks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            pnlPlay1.Visible = false;
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            pnlPlay1.Visible = true;
            pnlPlay1.BringToFront();
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
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

            // Check if the entered ISBN is not in the bookBorrows table
            if (!bookBorrows.IsBookBorrowed(txtBookID.Text))
            {
                MessageBox.Show("Book with ISBN " + txtBookID.Text + " is not available for return.");
                return; // Exit the method without further processing
            }

            // Check if the entered UserID is not associated with any borrowed books
            if (!bookBorrows.IsUserBorrowed(txtUserID.Text))
            {
                MessageBox.Show("User with ID " + txtUserID.Text + " has no borrowed books.");
                return; // Exit the method without further processing
            }


            // Retrieve necessary information from UI elements
            string bookID = txtBookID.Text.Trim();
            string userID = txtUserID.Text.Trim();
            try
            {
                loginTimer.Start();

                // Check if both book ID and user ID are provided
                if (!string.IsNullOrEmpty(bookID) && !string.IsNullOrEmpty(userID))
                {
                    // Check if the selected return date is valid
                    DateTime selectedReturnDate = dtpReturn.Value.Date;
                    DateTime currentDate = DateTime.Now.Date;

                    if (selectedReturnDate < currentDate)
                    {
                        MessageBox.Show("Invalid return date. Please select a date on or after the current date.");
                        return; // Exit the method without further processing
                    }


                    // Check if the user is a student
                    bool isStudent = usersManager.IsStudent(userID);

                    // Display MessageBox based on the result
                    if (isStudent)
                    {
                        MessageBox.Show("The user is a student.");
                        // Retrieve the returned date of the book
                        DateTime returnedDate = bookBorrows.GetReturnedDateByBookId(bookID);

                        if (dtpReturn.Value > returnedDate)
                        {


                            // Calculate the days ahead
                            int daysAhead = (int)(dtpReturn.Value - returnedDate).TotalDays;

                            // Show the days ahead in a MessageBox
                            MessageBox.Show($"The return date is {daysAhead} days ahead of the returned date.");


                            // Retrieve borrowed books based on the entered student or employee ID
                            BorrowedBook borrowedBook = bookBorrows.GetBorrowedBookByUserID(studentOrEmployeeId);

                            //get user money
                            int userMoney = usersManager.GetUserMoneyByUserId(studentOrEmployeeId);


                            // Calculate deduction for late return (assuming $20 deduction per day)
                            int lateReturnDeduction = daysAhead * 20;

                            //for the receipt
                            lblSAuthor.Text = borrowedBook.BookAuthor;
                            lblSUserID.Text = borrowedBook.UserID;
                            lblSUsername.Text = borrowedBook.Username;
                            lblSBorrowedDate.Text = borrowedBook.Borrowed.ToString();
                            lblSReturnedDate.Text = dtpReturn.Value.ToString();
                            lblSDueDate.Text = borrowedBook.Returned.ToString();
                            lblSBookID.Text = borrowedBook.ISBN.ToString();
                            lblSBookTitle.Text = borrowedBook.BookTitle;
                            lblSUserMoney.Text = userMoney.ToString();
                            lblSPayDue.Text = lateReturnDeduction.ToString();
                            lblNoDays.Text = daysAhead.ToString();


                            //show the receipt
                            pnlReceipt.Visible = true;
                            return;
                        }


                    }

                    // Update the book status to "Returned" in the Books class using ISBN
                    bool isBookReturned = books.UpdateBookStatusByISBN(bookID, "Returned");

                    if (isBookReturned)
                    {
                        // Remove the returned book from the bookborrows database
                        bool isBookRemoved = bookBorrows.RemoveReturnedBook(bookID);

                        if (isBookRemoved)
                        {

                            // Display a message indicating successful return and removal
                            MessageBox.Show("Book returned and removed successfully.");

                            // Clear the UI elements after borrowing
                            txtBookID.Text = "";
                            txtUserID.Text = "";
                            lblUserName.Text = "";
                            lblBookTitle.Text = "";
                            lblAuthorName.Text = "";
                            dtpReturn.Value = DateTime.Now; // Reset the DateTimePicker value
                            pbPicture.Image = null; // Clear the PictureBox image

                            // Refresh the DataGridView controls to reflect the changes
                            DisplayBooks();
                            DisplayBookBorrows();
                            Console.WriteLine($"Returning took {loginTimer.Elapsed.TotalMilliseconds:F2} milliseconds.");

                            loginTimer.Stop();
                            loginTimer.Reset();
                        }
                        else
                        {
                            // Display a message if removing the book fails
                            MessageBox.Show("Failed to remove the returned book from bookborrows database.");
                        }
                    }
                    else
                    {
                        // Display a message if updating the book status fails
                        MessageBox.Show("Failed to update book status.");
                    }
                }

                else
                {
                    // Display a message if book ID or user ID is missing
                    MessageBox.Show("Please provide both Book ID and User ID.");
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click_2(object sender, EventArgs e)
        {
            DisplayBooks();
            DisplayBookBorrows();
        }

        private void btnClear_Click_2(object sender, EventArgs e)
        {
            // Clear the UI elements after borrowing
            txtBookID.Text = "";
            txtUserID.Text = "";
            lblUserName.Text = "";
            lblBookTitle.Text = "";
            lblAuthorName.Text = "";
            dtpReturn.Value = DateTime.Now; // Reset the DateTimePicker value
            pbPicture.Image = null; // Clear the PictureBox image
        }

        private void txtBookID_TextChanged_2(object sender, EventArgs e)
        {
            string isbn = txtBookID.Text.Trim();
            BorrowedBook borrowedBook = bookBorrows.GetBorrowedBookByISBN(isbn);

            if (borrowedBook != null)
            {
                // Display book information in the corresponding labels and picture box
                lblAuthorName.Text = borrowedBook.BookAuthor;
                lblBookTitle.Text = borrowedBook.BookTitle;

                // Check if the Cover property is not null before assigning to the PictureBox
                if (borrowedBook.Picture != null && borrowedBook.Picture.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(borrowedBook.Picture))
                    {
                        pbPicture.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Set a default image or handle the case where the cover is not available
                }

                // Synchronize UserID and Username
                //txtUserID.Text = borrowedBook.UserID;
                lblUserName.Text = borrowedBook.Username;
            }
            else
            {
                // Clear labels and picture box if book is not found
                lblAuthorName.Text = "Author Not Available";
                lblBookTitle.Text = "Book Not Available";
                lblUserName.Text = "Username Not Available";
                pbPicture.Image = null;
            }
        }

        private void txtUserID_TextChanged_2(object sender, EventArgs e)
        {
            studentOrEmployeeId = txtUserID.Text.Trim();  // Update the class-level variable

            // Retrieve borrowed books based on the entered student or employee ID
            BorrowedBook borrowedBook = bookBorrows.GetBorrowedBookByUserID(studentOrEmployeeId);

            // Update labels with user details or show not available
            if (borrowedBook != null)
            {
                // Display book information in the corresponding labels and picture box
                lblAuthorName.Text = borrowedBook.BookAuthor;
                lblBookTitle.Text = borrowedBook.BookTitle;

                // Check if the Cover property is not null before assigning to the PictureBox
                if (borrowedBook.Picture != null && borrowedBook.Picture.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(borrowedBook.Picture))
                    {
                        pbPicture.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Set a default image or handle the case where the cover is not available
                }

                // Synchronize ISBN
                txtBookID.Text = borrowedBook.ISBN;
                //may prob ata dito
                lblUserName.Text = borrowedBook.Username;
            }
            else
            {
                // Clear labels and picture box if the user is not found or has no borrowed books
                lblAuthorName.Text = "Author Not Available";
                lblBookTitle.Text = "Book Not Available";
                lblUserName.Text = "Username Not Available";
                pbPicture.Image = null;
            }
        }

        private void dtpReturn_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void pnlPlay1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            pnlPlay1.Visible = false;
        }

        private void rdAnswer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            

          
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNameLester_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlPlay1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbq1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void q2Choice1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void q2Choice2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            string answer1 = "Jomariss Baccay Ganda";
            string answer2 = "Lester Gwapo Diampoc";

            // get the response from the qChoice1 and qchoice2

            if (answer1 == txtNamePlan.Text && answer2 == txtNameLester.Text)
            {
                string userID = txtUserID.Text.Trim();

                // Assuming you have a method to retrieve the user's current money based on user ID
                int currentMoney = usersManager.GetUserMoneyByUserId(userID);

                // Assuming you have a variable named 'amountToAdd' with the amount to be added
                int amountToAdd = 100;  // You can replace this with the actual amount

                // Calculate the updated money
                int updatedMoney = currentMoney + amountToAdd;

                // Update the user's money in the database
                bool moneyUpdated = usersManager.UpdateUserMoneyByUserId(userID, updatedMoney);


                if (moneyUpdated)
                {

                    // Display a success message
                    MessageBox.Show($"Added {amountToAdd} to the user's account. Updated money: {updatedMoney}");

                    MessageBox.Show($"Sana Maka-Uno ang Kampon ni Pedro Basuraman");
                    pnlPlay1.Visible = false;

                }
                else
                {
                    // Display a message if the update fails
                    MessageBox.Show("Failed to update user money.");
                }
            }
            else
            {
                // Display a message if the update fails
                MessageBox.Show("Answer is not Correct.");
            }

        }

        private void btnAReturn_Click(object sender, EventArgs e)
        {
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

            // Check if the entered ISBN is not in the bookBorrows table
            if (!bookBorrows.IsBookBorrowed(txtBookID.Text))
            {
                MessageBox.Show("Book with ISBN " + txtBookID.Text + " is not available for return.");
                return; // Exit the method without further processing
            }

            // Check if the entered UserID is not associated with any borrowed books
            if (!bookBorrows.IsUserBorrowed(txtUserID.Text))
            {
                MessageBox.Show("User with ID " + txtUserID.Text + " has no borrowed books.");
                return; // Exit the method without further processing
            }


            // Retrieve necessary information from UI elements
            string bookID = txtBookID.Text.Trim();
            string userID = txtUserID.Text.Trim();
            try
            {
                loginTimer.Start();

                // Check if both book ID and user ID are provided
                if (!string.IsNullOrEmpty(bookID) && !string.IsNullOrEmpty(userID))
                {
                    // Check if the selected return date is valid
                    DateTime selectedReturnDate = dtpReturn.Value.Date;
                    DateTime currentDate = DateTime.Now.Date;

                    if (selectedReturnDate < currentDate)
                    {
                        MessageBox.Show("Invalid return date. Please select a date on or after the current date.");
                        return; // Exit the method without further processing
                    }


                    // Check if the user is a student
                    bool isStudent = usersManager.IsStudent(userID);


                    // Update the book status to "Returned" in the Books class using ISBN
                    bool isBookReturned = books.UpdateBookStatusByISBN(bookID, "Returned");

                    if (isBookReturned)
                    {
                        // Remove the returned book from the bookborrows database
                        bool isBookRemoved = bookBorrows.RemoveReturnedBook(bookID);

                        if (isBookRemoved)
                        {

                            // Display a message indicating successful return and removal
                            MessageBox.Show("Book returned and removed successfully.");

                            // Clear the UI elements after borrowing
                            txtBookID.Text = "";
                            txtUserID.Text = "";
                            lblUserName.Text = "";
                            lblBookTitle.Text = "";
                            lblAuthorName.Text = "";
                            dtpReturn.Value = DateTime.Now; // Reset the DateTimePicker value
                            pbPicture.Image = null; // Clear the PictureBox image

                            // Refresh the DataGridView controls to reflect the changes
                            DisplayBooks();
                            DisplayBookBorrows();
                            Console.WriteLine($"Returning took {loginTimer.Elapsed.TotalMilliseconds:F2} milliseconds.");

                            loginTimer.Stop();
                            loginTimer.Reset();
                        }
                        else
                        {
                            // Display a message if removing the book fails
                            MessageBox.Show("Failed to remove the returned book from bookborrows database.");
                        }
                    }
                    else
                    {
                        // Display a message if updating the book status fails
                        MessageBox.Show("Failed to update book status.");
                    }
                }

                else
                {
                    // Display a message if book ID or user ID is missing
                    MessageBox.Show("Please provide both Book ID and User ID.");
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbltitleBook_Click(object sender, EventArgs e)
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
                    btnAReturn.Visible = true;

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
                btnAReturn.Visible = false;
            }
        }
    }
}
