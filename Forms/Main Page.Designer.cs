namespace FInalLibrarySystem
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.BookReservationLink = new System.Windows.Forms.LinkLabel();
            this.BookReturningLink = new System.Windows.Forms.LinkLabel();
            this.BookBorrowingLink = new System.Windows.Forms.LinkLabel();
            this.BorrowerListLink = new System.Windows.Forms.LinkLabel();
            this.BookListLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnDashboard = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profile1 = new FInalLibrarySystem.Profile();
            this.bookList1 = new FInalLibrarySystem.BookList();
            this.bookReturning1 = new FInalLibrarySystem.BookReturning();
            this.bookBorrowing1 = new FInalLibrarySystem.BookBorrowing();
            this.borrowerList1 = new FInalLibrarySystem.BorrowerList();
            this.bookReservation2 = new FInalLibrarySystem.BookReservation();
            this.bookReservation1 = new FInalLibrarySystem.BookReservation();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookReservationLink
            // 
            this.BookReservationLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.BookReservationLink.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookReservationLink.Image = ((System.Drawing.Image)(resources.GetObject("BookReservationLink.Image")));
            this.BookReservationLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookReservationLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BookReservationLink.LinkColor = System.Drawing.Color.White;
            this.BookReservationLink.Location = new System.Drawing.Point(15, 551);
            this.BookReservationLink.Name = "BookReservationLink";
            this.BookReservationLink.Size = new System.Drawing.Size(268, 64);
            this.BookReservationLink.TabIndex = 22;
            this.BookReservationLink.TabStop = true;
            this.BookReservationLink.Text = "Book Reservation";
            this.BookReservationLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BookReservationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BookReservationLink_LinkClicked);
            // 
            // BookReturningLink
            // 
            this.BookReturningLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.BookReturningLink.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookReturningLink.Image = ((System.Drawing.Image)(resources.GetObject("BookReturningLink.Image")));
            this.BookReturningLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookReturningLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BookReturningLink.LinkColor = System.Drawing.Color.White;
            this.BookReturningLink.Location = new System.Drawing.Point(15, 636);
            this.BookReturningLink.Name = "BookReturningLink";
            this.BookReturningLink.Size = new System.Drawing.Size(248, 64);
            this.BookReturningLink.TabIndex = 21;
            this.BookReturningLink.TabStop = true;
            this.BookReturningLink.Text = "Book Returning";
            this.BookReturningLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BookReturningLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BookReturningLink_LinkClicked);
            // 
            // BookBorrowingLink
            // 
            this.BookBorrowingLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.BookBorrowingLink.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookBorrowingLink.Image = ((System.Drawing.Image)(resources.GetObject("BookBorrowingLink.Image")));
            this.BookBorrowingLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookBorrowingLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BookBorrowingLink.LinkColor = System.Drawing.Color.White;
            this.BookBorrowingLink.Location = new System.Drawing.Point(15, 476);
            this.BookBorrowingLink.Name = "BookBorrowingLink";
            this.BookBorrowingLink.Size = new System.Drawing.Size(248, 64);
            this.BookBorrowingLink.TabIndex = 20;
            this.BookBorrowingLink.TabStop = true;
            this.BookBorrowingLink.Text = "Book Borrowing";
            this.BookBorrowingLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BookBorrowingLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BookBorrowingLink_LinkClicked);
            // 
            // BorrowerListLink
            // 
            this.BorrowerListLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.BorrowerListLink.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowerListLink.Image = ((System.Drawing.Image)(resources.GetObject("BorrowerListLink.Image")));
            this.BorrowerListLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowerListLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BorrowerListLink.LinkColor = System.Drawing.Color.White;
            this.BorrowerListLink.Location = new System.Drawing.Point(15, 402);
            this.BorrowerListLink.Name = "BorrowerListLink";
            this.BorrowerListLink.Size = new System.Drawing.Size(221, 64);
            this.BorrowerListLink.TabIndex = 19;
            this.BorrowerListLink.TabStop = true;
            this.BorrowerListLink.Text = "Borrower List";
            this.BorrowerListLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrowerListLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BorrowerListLink_LinkClicked);
            // 
            // BookListLink
            // 
            this.BookListLink.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.BookListLink.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookListLink.Image = ((System.Drawing.Image)(resources.GetObject("BookListLink.Image")));
            this.BookListLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookListLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.BookListLink.LinkColor = System.Drawing.Color.White;
            this.BookListLink.Location = new System.Drawing.Point(15, 322);
            this.BookListLink.Name = "BookListLink";
            this.BookListLink.Size = new System.Drawing.Size(176, 64);
            this.BookListLink.TabIndex = 18;
            this.BookListLink.TabStop = true;
            this.BookListLink.Text = "Book List";
            this.BookListLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BookListLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BookListLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FInalLibrarySystem.Properties.Resources.logo_2;
            this.pictureBox1.Location = new System.Drawing.Point(15, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FillColor = System.Drawing.Color.Black;
            this.closeButton.IconColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(1799, 2);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(64, 36);
            this.closeButton.TabIndex = 34;
            this.closeButton.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnDashboard.LinkColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(15, 241);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(189, 64);
            this.btnDashboard.TabIndex = 37;
            this.btnDashboard.TabStop = true;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDashboard_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1867, 41);
            this.panel1.TabIndex = 38;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // profile1
            // 
            this.profile1.BackColor = System.Drawing.Color.White;
            this.profile1.Location = new System.Drawing.Point(285, 9);
            this.profile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(1579, 1095);
            this.profile1.TabIndex = 26;
            this.profile1.Load += new System.EventHandler(this.profile1_Load_1);
            // 
            // bookList1
            // 
            this.bookList1.BackColor = System.Drawing.Color.White;
            this.bookList1.Location = new System.Drawing.Point(284, 14);
            this.bookList1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookList1.Name = "bookList1";
            this.bookList1.Size = new System.Drawing.Size(1579, 1095);
            this.bookList1.TabIndex = 27;
            this.bookList1.Load += new System.EventHandler(this.bookList1_Load);
            // 
            // bookReturning1
            // 
            this.bookReturning1.BackColor = System.Drawing.Color.White;
            this.bookReturning1.Location = new System.Drawing.Point(284, 14);
            this.bookReturning1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookReturning1.Name = "bookReturning1";
            this.bookReturning1.Size = new System.Drawing.Size(1579, 1095);
            this.bookReturning1.TabIndex = 35;
            // 
            // bookBorrowing1
            // 
            this.bookBorrowing1.BackColor = System.Drawing.Color.White;
            this.bookBorrowing1.Location = new System.Drawing.Point(284, 14);
            this.bookBorrowing1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookBorrowing1.Name = "bookBorrowing1";
            this.bookBorrowing1.Size = new System.Drawing.Size(1579, 1095);
            this.bookBorrowing1.TabIndex = 29;
            // 
            // borrowerList1
            // 
            this.borrowerList1.BackColor = System.Drawing.Color.White;
            this.borrowerList1.Location = new System.Drawing.Point(284, 14);
            this.borrowerList1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrowerList1.Name = "borrowerList1";
            this.borrowerList1.Size = new System.Drawing.Size(1579, 1095);
            this.borrowerList1.TabIndex = 28;
            // 
            // bookReservation2
            // 
            this.bookReservation2.BackColor = System.Drawing.Color.White;
            this.bookReservation2.Location = new System.Drawing.Point(284, 14);
            this.bookReservation2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookReservation2.Name = "bookReservation2";
            this.bookReservation2.Size = new System.Drawing.Size(1579, 1095);
            this.bookReservation2.TabIndex = 36;
            // 
            // bookReservation1
            // 
            this.bookReservation1.BackColor = System.Drawing.Color.DarkGray;
            this.bookReservation1.Location = new System.Drawing.Point(192, 4);
            this.bookReservation1.Margin = new System.Windows.Forms.Padding(2);
            this.bookReservation1.Name = "bookReservation1";
            this.bookReservation1.Size = new System.Drawing.Size(926, 860);
            this.bookReservation1.TabIndex = 31;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1867, 1108);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BookReservationLink);
            this.Controls.Add(this.BookReturningLink);
            this.Controls.Add(this.BookBorrowingLink);
            this.Controls.Add(this.BorrowerListLink);
            this.Controls.Add(this.BookListLink);
            this.Controls.Add(this.bookReturning1);
            this.Controls.Add(this.bookBorrowing1);
            this.Controls.Add(this.borrowerList1);
            this.Controls.Add(this.bookReservation2);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.bookList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.Shown += new System.EventHandler(this.MainPage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel BookReservationLink;
        private System.Windows.Forms.LinkLabel BookReturningLink;
        private System.Windows.Forms.LinkLabel BookBorrowingLink;
        private System.Windows.Forms.LinkLabel BorrowerListLink;
        private System.Windows.Forms.LinkLabel BookListLink;
        private Profile profile1;
        private BookList bookList1;
        private BorrowerList borrowerList1;
        private BookBorrowing bookBorrowing1;
        private BookReservation bookReservation1;
       
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox closeButton;
        private BookReturning bookReturning1;
        private BookReservation bookReservation2;
        private System.Windows.Forms.LinkLabel btnDashboard;
        private System.Windows.Forms.Panel panel1;
    }
}