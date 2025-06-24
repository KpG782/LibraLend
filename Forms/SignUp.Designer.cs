namespace FInalLibrarySystem
{
    partial class frmSignUp
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.rdbtnStudent = new System.Windows.Forms.RadioButton();
            this.rdbtnTeacher = new System.Windows.Forms.RadioButton();
            this.studentSignUp1 = new FInalLibrarySystem.Forms.SignUp_Panels.StudentSignUp();
            this.teacherSignUp1 = new FInalLibrarySystem.Forms.SignUp_Panels.TeacherSignUp();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FInalLibrarySystem.Properties.Resources.Add_a_heading__3_;
            this.pictureBox1.Location = new System.Drawing.Point(213, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(233, 91);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 45);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Sign Up Page";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(602, 4);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox1.TabIndex = 41;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(570, 3);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox2.TabIndex = 42;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Location = new System.Drawing.Point(-4, -2);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(646, 30);
            this.guna2Panel1.TabIndex = 66;
            // 
            // rdbtnStudent
            // 
            this.rdbtnStudent.AutoSize = true;
            this.rdbtnStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnStudent.Location = new System.Drawing.Point(328, 151);
            this.rdbtnStudent.Name = "rdbtnStudent";
            this.rdbtnStudent.Size = new System.Drawing.Size(78, 23);
            this.rdbtnStudent.TabIndex = 1;
            this.rdbtnStudent.TabStop = true;
            this.rdbtnStudent.Text = "Student";
            this.rdbtnStudent.UseVisualStyleBackColor = true;
            this.rdbtnStudent.CheckedChanged += new System.EventHandler(this.btnStudent_CheckedChanged);
            // 
            // rdbtnTeacher
            // 
            this.rdbtnTeacher.AutoSize = true;
            this.rdbtnTeacher.CausesValidation = false;
            this.rdbtnTeacher.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnTeacher.Location = new System.Drawing.Point(232, 151);
            this.rdbtnTeacher.Name = "rdbtnTeacher";
            this.rdbtnTeacher.Size = new System.Drawing.Size(79, 23);
            this.rdbtnTeacher.TabIndex = 0;
            this.rdbtnTeacher.TabStop = true;
            this.rdbtnTeacher.Text = "Teacher";
            this.rdbtnTeacher.UseVisualStyleBackColor = true;
            this.rdbtnTeacher.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // studentSignUp1
            // 
            this.studentSignUp1.Location = new System.Drawing.Point(-4, 191);
            this.studentSignUp1.Name = "studentSignUp1";
            this.studentSignUp1.Size = new System.Drawing.Size(636, 395);
            this.studentSignUp1.TabIndex = 95;
            // 
            // teacherSignUp1
            // 
            this.teacherSignUp1.Location = new System.Drawing.Point(-4, 180);
            this.teacherSignUp1.Name = "teacherSignUp1";
            this.teacherSignUp1.Size = new System.Drawing.Size(636, 395);
            this.teacherSignUp1.TabIndex = 94;
            this.teacherSignUp1.Load += new System.EventHandler(this.teacherSignUp1_Load);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 574);
            this.Controls.Add(this.studentSignUp1);
            this.Controls.Add(this.teacherSignUp1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdbtnStudent);
            this.Controls.Add(this.rdbtnTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.frmPrompt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Forms.SignUp_Panels.TeacherSignUp teacherSignUp1;
        private System.Windows.Forms.RadioButton rdbtnStudent;
        private System.Windows.Forms.RadioButton rdbtnTeacher;
        private Forms.SignUp_Panels.StudentSignUp studentSignUp1;
    }
}