using FInalLibrarySystem.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace FInalLibrarySystem
{
    public partial class Fictional : UserControl
    {
        private Books booksManager1;

        public Fictional()
        {
            InitializeComponent();
            booksManager1 = new Books();
        }

        private void Fictional_Load(object sender, EventArgs e)
        {
            LoadFictionalData();

            //pb1
            pb1.MouseHover += pb1_MouseHover;
            pb1.MouseLeave += pb1_MouseLeave;
            pnl1.Visible = false;

            //pb2
            pb2.MouseHover += pb2_MouseHover;
            pb2.MouseLeave += pb2_MouseLeave;
            pnl2.Visible = false;

            //pb3
            pb3.MouseHover += pb3_MouseHover;
            pb3.MouseLeave += pb3_MouseLeave;
            pnl3.Visible = false;

            //pb4
            pb4.MouseHover += pb4_MouseHover;
            pb4.MouseLeave += pb4_MouseLeave;
            pnl4.Visible = false;

            //pb5
            pb5.MouseHover += pb5_MouseHover;
            pb5.MouseLeave += pb5_MouseLeave;
            pnl5.Visible = false;

            //pb6
            pb6.MouseHover += pb6_MouseHover;
            pb6.MouseLeave += pb6_MouseLeave;
            pnl6.Visible = false;
            // pb7
            pb7.MouseHover += pb7_MouseHover;
            pb7.MouseLeave += pb7_MouseLeave;
            pnl7.Visible = false;

            //pb8

            pb8.MouseHover += pb8_MouseHover;
            pb8.MouseLeave += pb8_MouseLeave;
            pnl8.Visible = false;

            //pb9
            pb9.MouseHover += pb9_MouseHover;
            pb9.MouseLeave += pb9_MouseLeave;
            pnl9.Visible = false;

            //pb10
            pb10.MouseHover += pb10_MouseHover;
            pb10.MouseLeave += pb10_MouseLeave;
            pnl10.Visible = false;


        }

        private void LoadFictionalData()
        {


            List<Book> fictionalBooks = booksManager1.GetFictionalBooks();

            foreach (var book in fictionalBooks)
            {

                // Create an image from the byte[] cover data
                Image coverImage = ByteArrayToImage(book.Cover);

                // Check if the current book is "To KIll a Mockingbird"
                if (book.Title == "To Kill a Mockingbird")
                {
                    // Set the cover image for "To Kill a Mockingbird" in the PictureBox
                    pb1.Image = ByteArrayToImage(book.Cover);

                    // Additional logic for displaying other book information
                    // For example, you might set labels or other controls with book details
                    bk1lbl1.Text = book.Title;
                    bk1lbl2.Text = book.ISBN;
                    bk1lbl3.Text = book.Category;
                    bk1lbl4.Text = book.Author;
                    bk1lbl5.Text = book.Copyright.ToString();
                    bk1lbl6.Text = book.Publisher;
                    bk1lbl7.Text = book.Status;
                    bk1lbl8.Text = book.Description;
                    title1.Text = book.Title;
                    author1.Text = book.Author;

                    // Title,ISBN,Category, Author, Copyright, Publisher, Status, Description
                }
                else if (book.Title == "1984")
                {
                    // Set the cover image for "1984" in the PictureBox
                    pb2.Image = ByteArrayToImage(book.Cover);

                    // Additional logic for displaying other book information
                    // For example, you might set labels or other controls with book details
                    bk2lbl1.Text = book.Title;
                    bk2lbl2.Text = book.ISBN;
                    bk2lbl3.Text = book.Category;
                    bk2lbl4.Text = book.Author;
                    bk2lbl5.Text = book.Copyright.ToString();
                    bk2lbl6.Text = book.Publisher;
                    bk2lbl7.Text = book.Status;
                    bk2lbl8.Text = book.Description;
                    title2.Text = book.Title;
                    author2.Text = book.Author;


                    // Title,ISBN,Category, Author, Copyright, Publisher, Status, Description
                }
                else if (book.Title == "Pride and Prejudice")
                {
                    // Set the cover image for "Pride and Prejudice" in the PictureBox
                    pb3.Image = ByteArrayToImage(book.Cover);

                    // Additional logic for displaying other book information
                    // For example, you might set labels or other controls with book details
                    bk3lbl1.Text = book.Title;
                    bk3lbl2.Text = book.ISBN;
                    bk3lbl3.Text = book.Category;
                    bk3lbl4.Text = book.Author;
                    bk3lbl5.Text = book.Copyright.ToString();
                    bk3lbl6.Text = book.Publisher;
                    bk3lbl7.Text = book.Status;
                    bk3lbl8.Text = book.Description;
                    title3.Text = book.Title;
                    author3.Text = book.Author;

                    // Title,ISBN,Category, Author, Copyright, Publisher, Status, Description
                }
                else if (book.Title == "The Great Gatsby")
                {
                    // Set the cover image for "The Great Gatsby" in the PictureBox
                    pb4.Image = ByteArrayToImage(book.Cover);

                    // Additional logic for displaying other book information
                    // For example, you might set labels or other controls with book details
                    bk4lbl1.Text = book.Title;
                    bk4lbl2.Text = book.ISBN;
                    bk4lbl3.Text = book.Category;
                    bk4lbl4.Text = book.Author;
                    bk4lbl5.Text = book.Copyright.ToString();
                    bk4lbl6.Text = book.Publisher;
                    bk4lbl7.Text = book.Status;
                    bk4lbl8.Text = book.Description;
                    title4.Text = book.Title;
                    author4.Text = book.Author;

                    // Title,ISBN,Category, Author, Copyright, Publisher, Status, Description
                }
                else if (book.Title == "One Hundred Years of Solitude")
                {
                    // Set the cover image for "One Hundred Years of Solitude" in the PictureBox
                    pb5.Image = ByteArrayToImage(book.Cover);

                    // Additional logic for displaying other book information
                    // For example, you might set labels or other controls with book details
                    bk5lbl1.Text = book.Title;
                    bk5lbl2.Text = book.ISBN;
                    bk5lbl3.Text = book.Category;
                    bk5lbl4.Text = book.Author;
                    bk5lbl5.Text = book.Copyright.ToString();
                    bk5lbl6.Text = book.Publisher;
                    bk5lbl7.Text = book.Status;
                    bk5lbl8.Text = book.Description;
                    title5.Text = book.Title;
                    author5.Text = book.Author;

                    // Title,ISBN,Category, Author, Copyright, Publisher, Status, Description
                }
                else if (book.Title == "The Catcher in the Rye")
                {
                    // Set the cover image for "The Catcher in the Rye" in the PictureBox
                    pb6.Image = ByteArrayToImage(book.Cover);

                    // Additional logic for displaying other book information
                    // For example, you might set labels or other controls with book details
                    bk6lbl1.Text = book.Title;
                    bk6lbl2.Text = book.ISBN;
                    bk6lbl3.Text = book.Category;
                    bk6lbl4.Text = book.Author;
                    bk6lbl5.Text = book.Copyright.ToString();
                    bk6lbl6.Text = book.Publisher;
                    bk6lbl7.Text = book.Status;
                    bk6lbl8.Text = book.Description;
                    title6.Text = book.Title;
                    author6.Text = book.Author;

                    // Title,ISBN,Category, Author, Copyright, Publisher, Status, Description
                }
                else if (book.Title == "Jane Eyre")
                {
                    // Set the cover image for "The Catcher in the Rye" in the PictureBox
                    pb8.Image = ByteArrayToImage(book.Cover);

                    // Additional logic for displaying other book information
                    // For example, you might set labels or other controls with book details
                    bk8lbl1.Text = book.Title;
                    bk8lbl2.Text = book.ISBN;
                    bk8lbl3.Text = book.Category;
                    bk8lbl4.Text = book.Author;
                    bk8lbl5.Text = book.Copyright.ToString();
                    bk8lbl6.Text = book.Publisher;
                    bk8lbl7.Text = book.Status;
                    bk8lbl8.Text = book.Description;
                    title8.Text = book.Title;
                    author8.Text = book.Author;

                    // Title,ISBN,Category, Author, Copyright, Publisher, Status, Description
                }
                else if (book.Title == "Brave New World")
                {
                    // Set the cover image for "The Catcher in the Rye" in the PictureBox
                    pb9.Image = ByteArrayToImage(book.Cover);

                    // Additional logic for displaying other book information
                    // For example, you might set labels or other controls with book details
                    bk9lbl1.Text = book.Title;
                    bk9lbl2.Text = book.ISBN;
                    bk9lbl3.Text = book.Category;
                    bk9lbl4.Text = book.Author;
                    bk9lbl5.Text = book.Copyright.ToString();
                    bk9lbl6.Text = book.Publisher;
                    bk9lbl7.Text = book.Status;
                    bk9lbl8.Text = book.Description;
                    title9.Text = book.Title;
                    author9.Text = book.Author;

                    // Title,ISBN,Category, Author, Copyright, Publisher, Status, Description
                }
                else if (book.Title == "The Hobbit")
                {
                    // Set the cover image for "The Catcher in the Rye" in the PictureBox
                    pb10.Image = ByteArrayToImage(book.Cover);

                    // Additional logic for displaying other book information
                    // For example, you might set labels or other controls with book details
                    bk10lbl1.Text = book.Title;
                    bk10lbl4.Text = book.ISBN;
                    bk10lbl3.Text = book.Category;
                    bk10lbl4.Text = book.Author;
                    bk10lbl5.Text = book.Copyright.ToString();
                    bk10lbl6.Text = book.Publisher;
                    bk10lbl7.Text = book.Status;
                    bk10lbl8.Text = book.Description;
                    title10.Text = book.Title;
                    author10.Text = book.Author;

                    // Title,ISBN,Category, Author, Copyright, Publisher, Status, Description
                }
                else if (book.Title == "Harry Potter and the Philosophers Stone")
                {
                    // Set the cover image for "The Catcher in the Rye" in the PictureBox
                    pb7.Image = ByteArrayToImage(book.Cover);

                    // Additional logic for displaying other book information
                    // For example, you might set labels or other controls with book details
                    bk7lbl1.Text = book.Title;
                    bk7lbl2.Text = book.ISBN;
                    bk7lbl3.Text = book.Category;
                    bk7lbl4.Text = book.Author;
                    bk7lbl7.Text = book.Copyright.ToString();
                    bk7lbl6.Text = book.Publisher;
                    bk7lbl7.Text = book.Status;
                    bk7lbl8.Text = book.Description;
                    title7.Text = book.Title;
                    author7.Text = book.Author;

                    // Title,ISBN,Category, Author, Copyright, Publisher, Status, Description
                }
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

        private void bk1pb1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pb2_Click(object sender, EventArgs e)
        {

        }

        private void pb3_Click(object sender, EventArgs e)
        {

        }

        private void bk1lbl3_Click(object sender, EventArgs e)
        {

        }



        private void bk1lbl7_Click(object sender, EventArgs e)
        {

        }

        private void bk1lbl6_Click(object sender, EventArgs e)
        {

        }

        //pb1
        private void pb1_MouseHover(object sender, EventArgs e)
        {
            pnl1.Visible = true;
        }

        private void pb1_MouseLeave(object sender, EventArgs e)
        {
            pnl1.Visible = false;
        }

        //pb2
        private void pb2_MouseHover(object sender, EventArgs e)
        {
            pnl2.Visible = true;
        }

        private void pb2_MouseLeave(object sender, EventArgs e)
        {
            pnl2.Visible = false;
        }

        //pb3
        private void pb3_MouseHover(object sender, EventArgs e)
        {
            pnl3.Visible = true;
        }

        private void pb3_MouseLeave(object sender, EventArgs e)
        {
            pnl3.Visible = false;
        }

        //pb4
        private void pb4_MouseHover(object sender, EventArgs e)
        {
            pnl4.Visible = true;
        }

        private void pb4_MouseLeave(object sender, EventArgs e)
        {
            pnl4.Visible = false;
        }

        //pb5
        private void pb5_MouseHover(object sender, EventArgs e)
        {
            pnl5.Visible = true;
        }

        private void pb5_MouseLeave(object sender, EventArgs e)
        {
            pnl5.Visible = false;
        }

        //pb6
        private void pb6_MouseHover(object sender, EventArgs e)
        {
            pnl6.Visible = true;
        }

        private void pb6_MouseLeave(object sender, EventArgs e)
        {
            pnl6.Visible = false;
        }

        //pb7
        private void pb7_MouseHover(object sender, EventArgs e)
        {
            pnl7.Visible = true;
        }

        private void pb7_MouseLeave(object sender, EventArgs e)
        {
            pnl7.Visible = false;
        }

        //pb8
        private void pb8_MouseHover(object sender, EventArgs e)
        {
            pnl8.Visible = true;
        }

        private void pb8_MouseLeave(object sender, EventArgs e)
        {
            pnl8.Visible = false;
        }

        //pb9
        private void pb9_MouseHover(object sender, EventArgs e)
        {
            pnl9.Visible = true;
        }

        private void pb9_MouseLeave(object sender, EventArgs e)
        {
            pnl9.Visible = false;
        }

        //pb10
        private void pb10_MouseHover(object sender, EventArgs e)
        {
            pnl10.Visible = true;
        }

        private void pb10_MouseLeave(object sender, EventArgs e)
        {
            pnl10.Visible = false;
        }

        private void pb8_Click(object sender, EventArgs e)
        {

        }

        private void pb10_Click(object sender, EventArgs e)
        {

        }

        private void bk1lbl1_Click(object sender, EventArgs e)
        {

        }

        private void bk1lbl5_Click(object sender, EventArgs e)
        {

        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb4_Click(object sender, EventArgs e)
        {

        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void bk2lbl3_Click(object sender, EventArgs e)
        {

        }

        private void bk2lbl8_Click(object sender, EventArgs e)
        {

        }

        private void pnl3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void author1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pb5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pb6_Click(object sender, EventArgs e)
        {

        }

        private void title6_Click(object sender, EventArgs e)
        {

        }

        private void author6_Click(object sender, EventArgs e)
        {

        }

        private void author7_Click(object sender, EventArgs e)
        {

        }

        private void author1_Click_1(object sender, EventArgs e)
        {

        }

        private void pb8_Click_1(object sender, EventArgs e)
        {

        }

        private void title2_Click(object sender, EventArgs e)
        {

        }
    }
}
