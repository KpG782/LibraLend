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
using FInalLibrarySystem.Database;

namespace FInalLibrarySystem
{
    public partial class Profile : UserControl
    {

        private Books booksManager1;

        public Profile()
        {
            InitializeComponent();
            booksManager1 = new Books();

            UpdateStatusLabelCounts();
            UpdateCategoryCountsButton();


        }

        private void UpdateStatusLabelCounts()
        {
            // Call the count methods
            int returnedBooksCount = booksManager1.CountReturnedBooks();
            int borrowedBooksCount = booksManager1.CountBorrowedBooks();
            int reservedBooksCount = booksManager1.CountReservedBooks();

            // Update the labels with the counts
            LBLAvailable.Text = $"{returnedBooksCount}";
            LBLBorrowed.Text = $"{borrowedBooksCount}";
            LBLReserved.Text = $"{reservedBooksCount}";
        }

        private void UpdateCategoryCountsButton()
        {
            // Call the count methods
            int academicBooksCount = booksManager1.CountAcademicBooks();
            int fictionalBooksCount = booksManager1.CountFictionalBooks();
            int nonFictionalBooksCount = booksManager1.CountNonFictionalBooks();

            // Update the labels with the counts
            LBLAcademic.Text = $"{academicBooksCount}";
            LBLFictional.Text = $"{fictionalBooksCount}";
            LBLNonFictional.Text = $"{nonFictionalBooksCount}";
        }







        private void Profile_Load(object sender, EventArgs e)
        {


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStatusLabelCounts();
            UpdateCategoryCountsButton();
        }
    }
}