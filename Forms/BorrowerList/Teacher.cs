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

namespace FInalLibrarySystem
{
    public partial class Teacher : UserControl
    {
        private Users usersManager;
        public Teacher()
        {
            InitializeComponent();
            usersManager = new Users();
        }


        private void Teacher_Load(object sender, EventArgs e)
        {
            LoadTeacherData();
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

        private void LoadTeacherData()
        {
            dgvTeachers.Rows.Clear();

            List<Users.User> teachers = usersManager.GetAllTeachersOrderedByLatest(); // Fetch teachers ordered by latest

            foreach (var teacher in teachers)
            {
                Image teacherImage = ByteArrayToImage(teacher.Picture);

                dgvTeachers.Rows.Add(
                    teacher.Id,
                    teacher.Username,
                    teacher.FirstName,
                    teacher.LastName,
                    teacher.MiddleInitial,
                    teacher.Email,// Assuming this identifies a teacher uniquely like StudentID does for students
                    teacher.Department

                // Add more columns as needed
                );
            }
        }

        private void dgvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
