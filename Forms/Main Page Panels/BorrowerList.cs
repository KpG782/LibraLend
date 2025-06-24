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
using System.Windows.Forms;
using static FInalLibrarySystem.Database.Users;

namespace FInalLibrarySystem
{
    public partial class BorrowerList : UserControl
    {
        private Users usersManager;


        // ... (existing code)



        public BorrowerList()
        {
            InitializeComponent();
            usersManager = new Users();
        }

       public void BorrowerList_Load(object sender, EventArgs e)
        {
            LoadStudentData();

            dgvStudents.Visible = true;
            teacher1.Visible = false;
            adminAll1.Visible = false;
 


        }



        //data of the students
        private void LoadStudentData()
        {
            dgvStudents.Rows.Clear();

            List<Users.User> students = usersManager.GetAllStudentsOrderedByLatest();

            foreach (var student in students)
            {
                // Create an image from the byte[] picture data
                Image studentImage = ByteArrayToImage(student.Picture);

                dgvStudents.Rows.Add(
                    student.Id,
                    student.Username,
                    student.FirstName,
                    student.LastName,
                    student.MiddleInitial,
                    student.Email,
                    student.Section,
                    student.Year

                // Add more columns as neededa
                ); ;
            }
        }

        // Helper method to convert byte array to Image
        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BorrowerList b1 = new BorrowerList();
            b1.Visible = false;
            teacher1.Visible = true;
        }


        

        private void teacher1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvStudents.Visible = true;
            teacher1.Visible = false;
        }

        private void dgvStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teacher2_Load(object sender, EventArgs e)
        {

        }

        private void lnkTeacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvStudents.Visible = false;
            teacher1.Visible = true;
        }


        public void SetAdminVisibility(bool isVisible)
        {
            adminAll1.Visible = isVisible;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // Replace 'userIdToLookup' with the actual user ID you want to look up
            int userIdToLookup = 21; // Replace with the actual user ID

            // Call GetUserById to get the user by ID
            User user = usersManager.GetUserById(userIdToLookup);

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
                    adminAll1.Visible = true;
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
                adminAll1.Visible = false;
            }
        }
    }
}
