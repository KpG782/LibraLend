namespace FInalLibrarySystem
{
    partial class BookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookList));
            this.lblFBooks = new System.Windows.Forms.LinkLabel();
            this.lblNFBooks = new System.Windows.Forms.LinkLabel();
            this.lblAcadBooks = new System.Windows.Forms.LinkLabel();
            this.academic1 = new FInalLibrarySystem.Academic();
            this.nonFictional1 = new FInalLibrarySystem.Non_Fictional();
            this.fictional1 = new FInalLibrarySystem.Fictional();
            this.SuspendLayout();
            // 
            // lblFBooks
            // 
            this.lblFBooks.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.lblFBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBooks.Image = ((System.Drawing.Image)(resources.GetObject("lblFBooks.Image")));
            this.lblFBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFBooks.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblFBooks.LinkColor = System.Drawing.Color.Black;
            this.lblFBooks.Location = new System.Drawing.Point(212, 30);
            this.lblFBooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFBooks.Name = "lblFBooks";
            this.lblFBooks.Size = new System.Drawing.Size(140, 52);
            this.lblFBooks.TabIndex = 26;
            this.lblFBooks.TabStop = true;
            this.lblFBooks.Text = "Fictional Books";
            this.lblFBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFBooks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFBooks_LinkClicked);
            // 
            // lblNFBooks
            // 
            this.lblNFBooks.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.lblNFBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNFBooks.Image = ((System.Drawing.Image)(resources.GetObject("lblNFBooks.Image")));
            this.lblNFBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNFBooks.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblNFBooks.LinkColor = System.Drawing.Color.Black;
            this.lblNFBooks.Location = new System.Drawing.Point(356, 30);
            this.lblNFBooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNFBooks.Name = "lblNFBooks";
            this.lblNFBooks.Size = new System.Drawing.Size(183, 52);
            this.lblNFBooks.TabIndex = 28;
            this.lblNFBooks.TabStop = true;
            this.lblNFBooks.Text = "Non-Fictional Books";
            this.lblNFBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNFBooks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lblAcadBooks
            // 
            this.lblAcadBooks.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.lblAcadBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcadBooks.Image = ((System.Drawing.Image)(resources.GetObject("lblAcadBooks.Image")));
            this.lblAcadBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAcadBooks.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblAcadBooks.LinkColor = System.Drawing.Color.Black;
            this.lblAcadBooks.Location = new System.Drawing.Point(36, 30);
            this.lblAcadBooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcadBooks.Name = "lblAcadBooks";
            this.lblAcadBooks.Size = new System.Drawing.Size(156, 52);
            this.lblAcadBooks.TabIndex = 29;
            this.lblAcadBooks.TabStop = true;
            this.lblAcadBooks.Text = "Academic Books";
            this.lblAcadBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAcadBooks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // academic1
            // 
            this.academic1.BackColor = System.Drawing.Color.White;
            this.academic1.Location = new System.Drawing.Point(2, 84);
            this.academic1.Margin = new System.Windows.Forms.Padding(2);
            this.academic1.Name = "academic1";
            this.academic1.Size = new System.Drawing.Size(1184, 890);
            this.academic1.TabIndex = 30;
            // 
            // nonFictional1
            // 
            this.nonFictional1.BackColor = System.Drawing.Color.White;
            this.nonFictional1.Location = new System.Drawing.Point(2, 84);
            this.nonFictional1.Margin = new System.Windows.Forms.Padding(2);
            this.nonFictional1.Name = "nonFictional1";
            this.nonFictional1.Size = new System.Drawing.Size(1184, 890);
            this.nonFictional1.TabIndex = 32;
            this.nonFictional1.Load += new System.EventHandler(this.nonFictional1_Load);
            // 
            // fictional1
            // 
            this.fictional1.BackColor = System.Drawing.Color.White;
            this.fictional1.Location = new System.Drawing.Point(2, 84);
            this.fictional1.Margin = new System.Windows.Forms.Padding(2);
            this.fictional1.Name = "fictional1";
            this.fictional1.Size = new System.Drawing.Size(1184, 890);
            this.fictional1.TabIndex = 31;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblAcadBooks);
            this.Controls.Add(this.lblNFBooks);
            this.Controls.Add(this.lblFBooks);
            this.Controls.Add(this.academic1);
            this.Controls.Add(this.fictional1);
            this.Controls.Add(this.nonFictional1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookList";
            this.Size = new System.Drawing.Size(1184, 890);
            this.Load += new System.EventHandler(this.BookList_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel lblFBooks;
        private System.Windows.Forms.LinkLabel lblNFBooks;
        private System.Windows.Forms.LinkLabel lblAcadBooks;
        private Academic academic1;
        private Fictional fictional1;
        private Non_Fictional nonFictional1;
    }
}
