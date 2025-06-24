using FInalLibrarySystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FInalLibrarySystem.Forms.SignUp_Panels
{
    public partial class StudentSignUp : UserControl
    {
        private Stopwatch loginTimer;
        public StudentSignUp()
        {
            InitializeComponent();
            loginTimer = new Stopwatch();
        }

        private void txtbxFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentSignUp_Load(object sender, EventArgs e)
        {

        }

        private void txtbxLN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxEmailAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxStudID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxCPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbYearLvl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //field checker empty
        private bool AreFieldsEmpty()
        {
            // Check if any of the textboxes are empty
            if (string.IsNullOrWhiteSpace(txtbxFN.Text) ||
                string.IsNullOrWhiteSpace(txtbxLN.Text) ||
                string.IsNullOrWhiteSpace(txtbxMI.Text) ||
                string.IsNullOrWhiteSpace(txtbxUsername.Text) ||
                string.IsNullOrWhiteSpace(txtbxPassword.Text) ||
                string.IsNullOrWhiteSpace(txtbxCPass.Text) ||
                string.IsNullOrWhiteSpace(txtbxEmailAdd.Text) ||
                string.IsNullOrWhiteSpace(txtbxMoney.Text) ||
                string.IsNullOrWhiteSpace(cmbSection.Text) ||
                string.IsNullOrWhiteSpace(txtbxStudID.Text) ||
                string.IsNullOrWhiteSpace(cmbYearLvl.Text))

            {
                // Display a message box indicating the empty fields
                MessageBox.Show("Please fill in all the required fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true; // At least one field is empty
            }

            return false; // All fields are filled
        }

        //field checker filled
        private bool AreFieldsFilled()
        {
            // Check if all of the textboxes are filled
            if (!string.IsNullOrWhiteSpace(txtbxFN.Text) &&
                !string.IsNullOrWhiteSpace(txtbxLN.Text) &&
                !string.IsNullOrWhiteSpace(txtbxMI.Text) &&
                !string.IsNullOrWhiteSpace(txtbxUsername.Text) &&
                !string.IsNullOrWhiteSpace(txtbxPassword.Text) &&
                !string.IsNullOrWhiteSpace(txtbxCPass.Text) &&
                !string.IsNullOrWhiteSpace(txtbxEmailAdd.Text) &&
                !string.IsNullOrWhiteSpace(txtbxMoney.Text) &&
                !string.IsNullOrWhiteSpace(cmbSection.Text) &&
                !string.IsNullOrWhiteSpace(txtbxStudID.Text) &&
                !string.IsNullOrWhiteSpace(cmbYearLvl.Text))
            {
                // All fields are filled
                return true;
            }

            // Display a message box indicating the empty fields
            MessageBox.Show("Please fill in all the required fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false; // At least one field is empty
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {



            try
            {
                loginTimer.Start();
                if (txtbxPassword.Text != txtbxCPass.Text)
                {
                    MessageBox.Show("Re-Enter Password");
                    //field checker
                    AreFieldsEmpty();
                }
                else if (txtbxPassword.Text == txtbxCPass.Text)
                {

                    if (AreFieldsFilled() == true)
                    {
                        // Assuming you have a Users class instance to interact with the database
                        Users usersManager = new Users();

                        // Check if the username is already taken
                        if (usersManager.IsUsernameTaken(txtbxUsername.Text))
                        {
                            MessageBox.Show("Username is already taken. Please choose a different username.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Check if the studentID is already taken
                        if (usersManager.IsStudentIdTaken(txtbxStudID.Text))
                        {
                            MessageBox.Show("Student ID is already taken. Please choose a different Student ID.", "Student ID Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Create a User object with the form data
                        Users.User newUser = new Users.User
                        {
                            // Populate properties based on the form input
                            Username = txtbxUsername.Text,
                            Password = txtbxPassword.Text,
                            Email = txtbxEmailAdd.Text,
                            FirstName = txtbxFN.Text,
                            LastName = txtbxLN.Text,
                            MiddleInitial = txtbxMI.Text,
                            Year = cmbYearLvl.Text,
                            Section = cmbSection.Text,
                            Money = int.Parse(txtbxMoney.Text),
                            Role = "Student", // Assuming this is a student sign-up
                            StudentID = txtbxStudID.Text,
                            EmployeeID = "N/A",
                            Department = "N/A"
                            // Add other properties as needed
                        };

                        // Insert the new user into the database
                        usersManager.InsertUserIntoDatabase(newUser);

                        // Show the login form or perform other actions as needed
                        frmLogin f2 = new frmLogin();
                        f2.Show();


                        Console.WriteLine($"Signup took {loginTimer.Elapsed.TotalMilliseconds:F2} milliseconds.");

                        loginTimer.Stop();
                        loginTimer.Reset();


                        this.Refresh();
                        this.ParentForm.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            frmLogin f1 = new frmLogin();
            f1.Show();
        }
    }
}