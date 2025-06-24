using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalLibrarySystem
{
    

    public partial class MainPage : Form
    {

        public Point mouseLocation;


        public MainPage()
        {
            InitializeComponent();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            //set if visibile or not
            profile1.Visible = true;
            bookList1.Visible = false;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = false;
            bookReservation2.Visible = false;
            




        }

        private void profile1_Load(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {

        }

        private void btnBorList_Click(object sender, EventArgs e)
        {


        }

        private void btnBookBor_Click(object sender, EventArgs e)
        {

        }

        private void btnBookReturn_Click(object sender, EventArgs e)
        {

        }

        private void bookReserv_Click(object sender, EventArgs e)
        {

        }

        private void btnBookPenalty_Click(object sender, EventArgs e)
        {

        }

        private void bookReturning1_Load(object sender, EventArgs e)
        {

        }

        private void penalty1_Load(object sender, EventArgs e)
        {

        }

        private void penalty1_Load_1(object sender, EventArgs e)
        {

        }

        private void UProfileLinkList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //set if visibile or not
            profile1.Visible = true;
            bookList1.Visible = false;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = false;
            bookReservation1.Visible = false;
        }

        private void BookListLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //set if visibile or not
            profile1.Visible = false;
            bookList1.Visible = true;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = false;
            bookReservation1.Visible = false;
        }

        private void BorrowerListLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //set if visibile or not
            profile1.Visible = false;
            bookList1.Visible = false;
            borrowerList1.Visible = true;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = false;
            bookReservation1.Visible = false;
        }

        private void BookBorrowingLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //set if visibile or not
            profile1.Visible = false;
            bookList1.Visible = false;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = true;
            bookReturning1.Visible = false;
            bookReservation1.Visible = false;
        }

        private void BookReturningLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //set if visibile or not
            profile1.Visible = false;
            bookList1.Visible = false;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = true;
            bookReservation1.Visible = false;
        }

        private void BookReservationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //set if visibile or not
            profile1.Visible = false;
            bookList1.Visible = false;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = false;
            bookReservation2.Visible = true;
        }



     

        private void MainPage_Shown(object sender, EventArgs e)
        {

        }

        private void bookList1_Load(object sender, EventArgs e)
        {

        }



        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //set if visibile or not
            profile1.Visible = true;
            bookList1.Visible = false;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = false;
            bookReservation2.Visible = true;
        }

        private void profile1_Load_1(object sender, EventArgs e)
        {
            //set if visibile or not
            profile1.Visible = false;
            bookList1.Visible = true;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = false;
            bookReservation2.Visible = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            //set if visibile or not
            profile1.Visible = false;
            bookList1.Visible = true;
            borrowerList1.Visible = false;
            bookBorrowing1.Visible = false;
            bookReturning1.Visible = false;
            bookReservation2.Visible = true;
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }

        }
    }
}
