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

namespace FInalLibrarySystem.Forms.BorrowerList
{
    public partial class adminAll : UserControl
    {
        private Users usersManager;
        public adminAll()
        {
            InitializeComponent();
            usersManager = new Users();
        }

        private void dgvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminAll_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadAllData()
        {
            dgvAll.Rows.Clear();

            List<Users.User> teachers = usersManager.GetAllUsers(); // Fetch teachers ordered by latest

            foreach (var teacher in teachers)
            {

                dgvAll.Rows.Add(
                    teacher.Id,
                    teacher.Role,
                    teacher.StudentID,
                    teacher.EmployeeID,
                    teacher.Password,
                    teacher.FirstName,
                    teacher.LastName


                // Add more columns as needed
                ) ;
            }
        }
    }
}
