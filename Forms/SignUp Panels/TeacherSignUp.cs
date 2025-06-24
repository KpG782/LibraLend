using FInalLibrarySystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FInalLibrarySystem.Forms.SignUp_Panels
{
    public partial class TeacherSignUp : UserControl
    {
        private Stopwatch loginTimer;
        public TeacherSignUp()
        {
            InitializeComponent();
            loginTimer = new Stopwatch();

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
                string.IsNullOrWhiteSpace(cmbCollegeDept.Text) ||
                string.IsNullOrWhiteSpace(txtbxEmpID.Text)
                )
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
                !string.IsNullOrWhiteSpace(txtbxEmpID.Text) &&
                !string.IsNullOrWhiteSpace(cmbCollegeDept.Text))
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
            loginTimer.Start();
            if (txtbxPassword.Text != txtbxCPass.Text || txtbxPassword.Text == "")
            {
                MessageBox.Show("Re-Enter Password");
                //field checker
                AreFieldsEmpty();
            }
            else if (txtbxPassword.Text == txtbxCPass.Text)
            {
                //field checker
                AreFieldsEmpty();

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

                    // Check if the employee ID is already taken
                    if (usersManager.IsEmployeeIdTaken(txtbxEmpID.Text))
                    {
                        MessageBox.Show("Employee ID is already taken. Please choose a different Employee ID.", "Employee ID Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        Department = cmbCollegeDept.Text,
                        Money = int.Parse(txtbxMoney.Text),
                        Role = "Teacher", // Assuming this is a student sign-up
                        EmployeeID = txtbxEmpID.Text,
                        StudentID = "N/A",
                        Section = "N/A",
                        Year = "N/A"
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

        private void txtbxFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxLN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCollegeDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbxMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxEmailAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxCPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            frmLogin f1 = new frmLogin();
            f1.Show();
        }
    }
}