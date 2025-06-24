namespace FInalLibrarySystem
{
    partial class BookBorrowing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PrimaryPanel = new System.Windows.Forms.Panel();
            this.lbltitleBook = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnABorrow = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnBorrow = new Guna.UI2.WinForms.Guna2Button();
            this.pbPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dtpBorrow = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblborrow = new System.Windows.Forms.Label();
            this.LBLBookID = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtUserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBookID = new Guna.UI2.WinForms.Guna2TextBox();
            this.LBLUserID = new System.Windows.Forms.Label();
            this.LBLTitle = new System.Windows.Forms.Label();
            this.LBLAuthor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.Book_TItle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copyright = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PrimaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrimaryPanel
            // 
            this.PrimaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrimaryPanel.Controls.Add(this.lbltitleBook);
            this.PrimaryPanel.Controls.Add(this.btnABorrow);
            this.PrimaryPanel.Controls.Add(this.btnUpdate);
            this.PrimaryPanel.Controls.Add(this.lblUserName);
            this.PrimaryPanel.Controls.Add(this.lblAuthorName);
            this.PrimaryPanel.Controls.Add(this.lblBookTitle);
            this.PrimaryPanel.Controls.Add(this.btnClear);
            this.PrimaryPanel.Controls.Add(this.btnBorrow);
            this.PrimaryPanel.Controls.Add(this.pbPicture);
            this.PrimaryPanel.Controls.Add(this.dtpBorrow);
            this.PrimaryPanel.Controls.Add(this.lblborrow);
            this.PrimaryPanel.Controls.Add(this.LBLBookID);
            this.PrimaryPanel.Controls.Add(this.lbluser);
            this.PrimaryPanel.Controls.Add(this.txtUserID);
            this.PrimaryPanel.Controls.Add(this.txtBookID);
            this.PrimaryPanel.Controls.Add(this.LBLUserID);
            this.PrimaryPanel.Controls.Add(this.LBLTitle);
            this.PrimaryPanel.Controls.Add(this.LBLAuthor);
            this.PrimaryPanel.Controls.Add(this.label1);
            this.PrimaryPanel.Location = new System.Drawing.Point(2, 2);
            this.PrimaryPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PrimaryPanel.Name = "PrimaryPanel";
            this.PrimaryPanel.Size = new System.Drawing.Size(576, 882);
            this.PrimaryPanel.TabIndex = 2;
            this.PrimaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PrimaryPanel_Paint_1);
            // 
            // lbltitleBook
            // 
            this.lbltitleBook.BackColor = System.Drawing.Color.Transparent;
            this.lbltitleBook.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.lbltitleBook.Location = new System.Drawing.Point(196, 39);
            this.lbltitleBook.Name = "lbltitleBook";
            this.lbltitleBook.Size = new System.Drawing.Size(195, 34);
            this.lbltitleBook.TabIndex = 52;
            this.lbltitleBook.Text = "Book Borrowing";
            this.lbltitleBook.Click += new System.EventHandler(this.lbltitleBook_Click);
            // 
            // btnABorrow
            // 
            this.btnABorrow.BorderRadius = 15;
            this.btnABorrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnABorrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnABorrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnABorrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnABorrow.FillColor = System.Drawing.Color.Black;
            this.btnABorrow.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABorrow.ForeColor = System.Drawing.Color.White;
            this.btnABorrow.Location = new System.Drawing.Point(107, 801);
            this.btnABorrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnABorrow.Name = "btnABorrow";
            this.btnABorrow.Size = new System.Drawing.Size(106, 46);
            this.btnABorrow.TabIndex = 69;
            this.btnABorrow.Text = "BORROW";
            this.btnABorrow.Click += new System.EventHandler(this.btnABorrow_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(237, 801);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 46);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(172, 602);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(283, 18);
            this.lblUserName.TabIndex = 67;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(172, 532);
            this.lblAuthorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(283, 18);
            this.lblAuthorName.TabIndex = 66;
            this.lblAuthorName.Text = "AuthorName";
            this.lblAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(179, 501);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(276, 18);
            this.lblBookTitle.TabIndex = 65;
            this.lblBookTitle.Text = "Book Title";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 15;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.IndianRed;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(371, 801);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 46);
            this.btnClear.TabIndex = 64;
            this.btnClear.Text = "CLEAR";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BorderRadius = 15;
            this.btnBorrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBorrow.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBorrow.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.Black;
            this.btnBorrow.Location = new System.Drawing.Point(107, 801);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(106, 46);
            this.btnBorrow.TabIndex = 63;
            this.btnBorrow.Text = "BORROW";
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click_1);
            // 
            // pbPicture
            // 
            this.pbPicture.BorderRadius = 20;
            this.pbPicture.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbPicture.ImageRotate = 0F;
            this.pbPicture.Location = new System.Drawing.Point(176, 102);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(245, 301);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 59;
            this.pbPicture.TabStop = false;
            // 
            // dtpBorrow
            // 
            this.dtpBorrow.BorderRadius = 10;
            this.dtpBorrow.BorderThickness = 1;
            this.dtpBorrow.Checked = true;
            this.dtpBorrow.FillColor = System.Drawing.Color.White;
            this.dtpBorrow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBorrow.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBorrow.Location = new System.Drawing.Point(170, 633);
            this.dtpBorrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpBorrow.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBorrow.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(285, 38);
            this.dtpBorrow.TabIndex = 62;
            this.dtpBorrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpBorrow.Value = new System.DateTime(2024, 1, 12, 0, 0, 0, 0);
            // 
            // lblborrow
            // 
            this.lblborrow.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblborrow.Location = new System.Drawing.Point(75, 643);
            this.lblborrow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblborrow.Name = "lblborrow";
            this.lblborrow.Size = new System.Drawing.Size(78, 18);
            this.lblborrow.TabIndex = 55;
            this.lblborrow.Text = "BORROW:";
            this.lblborrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBLBookID
            // 
            this.LBLBookID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBookID.Location = new System.Drawing.Point(77, 464);
            this.LBLBookID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLBookID.Name = "LBLBookID";
            this.LBLBookID.Size = new System.Drawing.Size(69, 18);
            this.LBLBookID.TabIndex = 56;
            this.LBLBookID.Text = "BOOK ID:";
            this.LBLBookID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbluser
            // 
            this.lbluser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(75, 602);
            this.lbluser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(90, 18);
            this.lbluser.TabIndex = 58;
            this.lbluser.Text = "USERNAME:";
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserID
            // 
            this.txtUserID.BorderColor = System.Drawing.Color.Black;
            this.txtUserID.BorderRadius = 10;
            this.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserID.DefaultText = "";
            this.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserID.ForeColor = System.Drawing.Color.Black;
            this.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserID.Location = new System.Drawing.Point(170, 565);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.PlaceholderText = "";
            this.txtUserID.SelectedText = "";
            this.txtUserID.Size = new System.Drawing.Size(285, 34);
            this.txtUserID.TabIndex = 61;
            this.txtUserID.TextChanged += new System.EventHandler(this.txtUserID_TextChanged_1);
            // 
            // txtBookID
            // 
            this.txtBookID.BorderColor = System.Drawing.Color.Black;
            this.txtBookID.BorderRadius = 10;
            this.txtBookID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookID.DefaultText = "";
            this.txtBookID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBookID.ForeColor = System.Drawing.Color.Black;
            this.txtBookID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookID.Location = new System.Drawing.Point(170, 464);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.PasswordChar = '\0';
            this.txtBookID.PlaceholderText = "";
            this.txtBookID.SelectedText = "";
            this.txtBookID.Size = new System.Drawing.Size(285, 34);
            this.txtBookID.TabIndex = 60;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged_1);
            // 
            // LBLUserID
            // 
            this.LBLUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUserID.Location = new System.Drawing.Point(76, 565);
            this.LBLUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLUserID.Name = "LBLUserID";
            this.LBLUserID.Size = new System.Drawing.Size(69, 18);
            this.LBLUserID.TabIndex = 57;
            this.LBLUserID.Text = "USER ID:";
            this.LBLUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBLTitle
            // 
            this.LBLTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitle.Location = new System.Drawing.Point(77, 501);
            this.LBLTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLTitle.Name = "LBLTitle";
            this.LBLTitle.Size = new System.Drawing.Size(69, 18);
            this.LBLTitle.TabIndex = 53;
            this.LBLTitle.Text = "BOOK TITLE:";
            this.LBLTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBLAuthor
            // 
            this.LBLAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAuthor.Location = new System.Drawing.Point(75, 532);
            this.LBLAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLAuthor.Name = "LBLAuthor";
            this.LBLAuthor.Size = new System.Drawing.Size(69, 18);
            this.LBLAuthor.TabIndex = 54;
            this.LBLAuthor.Text = "AUTHOR:";
            this.LBLAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-98, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShow.BackgroundColor = System.Drawing.Color.Black;
            this.dgvShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvShow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShow.ColumnHeadersHeight = 40;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_TItle,
            this.ISBN,
            this.Category,
            this.Book_Author,
            this.Column10,
            this.Copyright});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShow.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShow.EnableHeadersVisualStyles = false;
            this.dgvShow.Location = new System.Drawing.Point(580, 23);
            this.dgvShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 40;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(602, 865);
            this.dgvShow.TabIndex = 25;
            // 
            // Book_TItle
            // 
            this.Book_TItle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Book_TItle.FillWeight = 58.17943F;
            this.Book_TItle.HeaderText = "Book_TItle";
            this.Book_TItle.MinimumWidth = 6;
            this.Book_TItle.Name = "Book_TItle";
            this.Book_TItle.Width = 95;
            // 
            // ISBN
            // 
            this.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ISBN.FillWeight = 73.73386F;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 60;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Category.FillWeight = 93.26363F;
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 87;
            // 
            // Book_Author
            // 
            this.Book_Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Book_Author.FillWeight = 117.2417F;
            this.Book_Author.HeaderText = "Book_Author";
            this.Book_Author.MinimumWidth = 6;
            this.Book_Author.Name = "Book_Author";
            this.Book_Author.Width = 110;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column10.FillWeight = 145.6994F;
            this.Column10.HeaderText = "Book_Status";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 105;
            // 
            // Copyright
            // 
            this.Copyright.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Copyright.FillWeight = 177.665F;
            this.Copyright.HeaderText = "Copyright";
            this.Copyright.MinimumWidth = 6;
            this.Copyright.Name = "Copyright";
            this.Copyright.Width = 92;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.dgvShow);
            this.MainPanel.Controls.Add(this.PrimaryPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1184, 890);
            this.MainPanel.TabIndex = 4;
            // 
            // BookBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookBorrowing";
            this.Size = new System.Drawing.Size(1184, 890);
            this.Load += new System.EventHandler(this.BookBorrowing_Load);
            this.PrimaryPanel.ResumeLayout(false);
            this.PrimaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PrimaryPanel;
        private Guna.UI2.WinForms.Guna2Button btnABorrow;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblBookTitle;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbltitleBook;
        private Guna.UI2.WinForms.Guna2Button btnBorrow;
        private Guna.UI2.WinForms.Guna2PictureBox pbPicture;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBorrow;
        private System.Windows.Forms.Label lblborrow;
        private System.Windows.Forms.Label LBLBookID;
        private System.Windows.Forms.Label lbluser;
        private Guna.UI2.WinForms.Guna2TextBox txtUserID;
        private Guna.UI2.WinForms.Guna2TextBox txtBookID;
        private System.Windows.Forms.Label LBLUserID;
        private System.Windows.Forms.Label LBLTitle;
        private System.Windows.Forms.Label LBLAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_TItle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copyright;
        private System.Windows.Forms.Panel MainPanel;
    }
}
