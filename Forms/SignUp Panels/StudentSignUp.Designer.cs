namespace FInalLibrarySystem.Forms.SignUp_Panels
{
    partial class StudentSignUp
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
            this.cmbSection = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbYearLvl = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtbxMoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxCPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtbxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtbxEmailAdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStudID = new System.Windows.Forms.Label();
            this.txtbxStudID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblYearLvl = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtbxMI = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxLN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbxFN = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // cmbSection
            // 
            this.cmbSection.BackColor = System.Drawing.Color.Transparent;
            this.cmbSection.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbSection.BorderRadius = 10;
            this.cmbSection.BorderThickness = 2;
            this.cmbSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSection.ItemHeight = 30;
            this.cmbSection.Items.AddRange(new object[] {
            "ACSAD",
            "BCSAD",
            "CCSAD",
            "DCSAD",
            "AINS",
            "BINS",
            "CINS",
            "DINS"});
            this.cmbSection.Location = new System.Drawing.Point(164, 178);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(107, 36);
            this.cmbSection.TabIndex = 115;
            this.cmbSection.SelectedIndexChanged += new System.EventHandler(this.cmbSection_SelectedIndexChanged);
            // 
            // cmbYearLvl
            // 
            this.cmbYearLvl.BackColor = System.Drawing.Color.Transparent;
            this.cmbYearLvl.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbYearLvl.BorderRadius = 10;
            this.cmbYearLvl.BorderThickness = 2;
            this.cmbYearLvl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbYearLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearLvl.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbYearLvl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbYearLvl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbYearLvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbYearLvl.ItemHeight = 30;
            this.cmbYearLvl.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.cmbYearLvl.Location = new System.Drawing.Point(26, 178);
            this.cmbYearLvl.Name = "cmbYearLvl";
            this.cmbYearLvl.Size = new System.Drawing.Size(107, 36);
            this.cmbYearLvl.TabIndex = 114;
            this.cmbYearLvl.SelectedIndexChanged += new System.EventHandler(this.cmbYearLvl_SelectedIndexChanged);
            // 
            // lblMoney
            // 
            this.lblMoney.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Black;
            this.lblMoney.Location = new System.Drawing.Point(16, 214);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(196, 27);
            this.lblMoney.TabIndex = 113;
            this.lblMoney.Text = "Deposit Money in Peso";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxMoney
            // 
            this.txtbxMoney.Animated = true;
            this.txtbxMoney.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbxMoney.BorderRadius = 10;
            this.txtbxMoney.BorderThickness = 2;
            this.txtbxMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxMoney.DefaultText = "";
            this.txtbxMoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxMoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxMoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxMoney.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbxMoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxMoney.Location = new System.Drawing.Point(26, 243);
            this.txtbxMoney.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtbxMoney.Name = "txtbxMoney";
            this.txtbxMoney.PasswordChar = '\0';
            this.txtbxMoney.PlaceholderText = "Enter Amount in Peso";
            this.txtbxMoney.SelectedText = "";
            this.txtbxMoney.Size = new System.Drawing.Size(265, 37);
            this.txtbxMoney.TabIndex = 112;
            this.txtbxMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.AutoRoundedCorners = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 24;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Gold;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(333, 301);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 51);
            this.btnExit.TabIndex = 111;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Animated = true;
            this.btnSubmit.AutoRoundedCorners = true;
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BorderRadius = 24;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.Black;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(200, 301);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 51);
            this.btnSubmit.TabIndex = 110;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(332, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 27);
            this.label8.TabIndex = 109;
            this.label8.Text = "Confirm Password";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxCPass
            // 
            this.txtbxCPass.Animated = true;
            this.txtbxCPass.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbxCPass.BorderRadius = 10;
            this.txtbxCPass.BorderThickness = 2;
            this.txtbxCPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxCPass.DefaultText = "";
            this.txtbxCPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxCPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxCPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxCPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxCPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxCPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbxCPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxCPass.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtbxCPass.Location = new System.Drawing.Point(341, 243);
            this.txtbxCPass.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtbxCPass.Name = "txtbxCPass";
            this.txtbxCPass.PasswordChar = '\0';
            this.txtbxCPass.PlaceholderText = "Re-enter Password";
            this.txtbxCPass.SelectedText = "";
            this.txtbxCPass.Size = new System.Drawing.Size(265, 37);
            this.txtbxCPass.TabIndex = 108;
            this.txtbxCPass.TextChanged += new System.EventHandler(this.txtbxCPass_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(332, 148);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(158, 27);
            this.lblPassword.TabIndex = 107;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Animated = true;
            this.txtbxPassword.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbxPassword.BorderRadius = 10;
            this.txtbxPassword.BorderThickness = 2;
            this.txtbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxPassword.DefaultText = "";
            this.txtbxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxPassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtbxPassword.Location = new System.Drawing.Point(341, 175);
            this.txtbxPassword.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = '\0';
            this.txtbxPassword.PlaceholderText = "Enter Password";
            this.txtbxPassword.SelectedText = "";
            this.txtbxPassword.Size = new System.Drawing.Size(265, 37);
            this.txtbxPassword.TabIndex = 106;
            this.txtbxPassword.TextChanged += new System.EventHandler(this.txtbxPassword_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(332, 80);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(182, 27);
            this.lblUsername.TabIndex = 105;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Animated = true;
            this.txtbxUsername.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbxUsername.BorderRadius = 10;
            this.txtbxUsername.BorderThickness = 2;
            this.txtbxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxUsername.DefaultText = "";
            this.txtbxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxUsername.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtbxUsername.Location = new System.Drawing.Point(341, 108);
            this.txtbxUsername.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.PasswordChar = '\0';
            this.txtbxUsername.PlaceholderText = "Enter Username";
            this.txtbxUsername.SelectedText = "";
            this.txtbxUsername.Size = new System.Drawing.Size(265, 37);
            this.txtbxUsername.TabIndex = 104;
            this.txtbxUsername.TextChanged += new System.EventHandler(this.txtbxUsername_TextChanged);
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.ForeColor = System.Drawing.Color.Black;
            this.lblEmailAddress.Location = new System.Drawing.Point(332, 11);
            this.lblEmailAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(182, 27);
            this.lblEmailAddress.TabIndex = 103;
            this.lblEmailAddress.Text = "Email Address";
            this.lblEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxEmailAdd
            // 
            this.txtbxEmailAdd.Animated = true;
            this.txtbxEmailAdd.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbxEmailAdd.BorderRadius = 10;
            this.txtbxEmailAdd.BorderThickness = 2;
            this.txtbxEmailAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxEmailAdd.DefaultText = "";
            this.txtbxEmailAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxEmailAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxEmailAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxEmailAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxEmailAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxEmailAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbxEmailAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxEmailAdd.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtbxEmailAdd.Location = new System.Drawing.Point(341, 41);
            this.txtbxEmailAdd.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtbxEmailAdd.Name = "txtbxEmailAdd";
            this.txtbxEmailAdd.PasswordChar = '\0';
            this.txtbxEmailAdd.PlaceholderText = "Enter Email";
            this.txtbxEmailAdd.SelectedText = "";
            this.txtbxEmailAdd.Size = new System.Drawing.Size(265, 37);
            this.txtbxEmailAdd.TabIndex = 102;
            this.txtbxEmailAdd.TextChanged += new System.EventHandler(this.txtbxEmailAdd_TextChanged);
            // 
            // lblStudID
            // 
            this.lblStudID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudID.ForeColor = System.Drawing.Color.Black;
            this.lblStudID.Location = new System.Drawing.Point(16, 82);
            this.lblStudID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudID.Name = "lblStudID";
            this.lblStudID.Size = new System.Drawing.Size(160, 27);
            this.lblStudID.TabIndex = 101;
            this.lblStudID.Text = "Student ID";
            this.lblStudID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxStudID
            // 
            this.txtbxStudID.Animated = true;
            this.txtbxStudID.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbxStudID.BorderRadius = 10;
            this.txtbxStudID.BorderThickness = 2;
            this.txtbxStudID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxStudID.DefaultText = "";
            this.txtbxStudID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxStudID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxStudID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxStudID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxStudID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxStudID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbxStudID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxStudID.Location = new System.Drawing.Point(26, 111);
            this.txtbxStudID.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtbxStudID.Name = "txtbxStudID";
            this.txtbxStudID.PasswordChar = '\0';
            this.txtbxStudID.PlaceholderText = "Enter Student ID";
            this.txtbxStudID.SelectedText = "";
            this.txtbxStudID.Size = new System.Drawing.Size(265, 37);
            this.txtbxStudID.TabIndex = 100;
            this.txtbxStudID.TextChanged += new System.EventHandler(this.txtbxStudID_TextChanged);
            // 
            // lblSection
            // 
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.Black;
            this.lblSection.Location = new System.Drawing.Point(160, 148);
            this.lblSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(118, 27);
            this.lblSection.TabIndex = 99;
            this.lblSection.Text = "Section";
            this.lblSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYearLvl
            // 
            this.lblYearLvl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearLvl.ForeColor = System.Drawing.Color.Black;
            this.lblYearLvl.Location = new System.Drawing.Point(16, 148);
            this.lblYearLvl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYearLvl.Name = "lblYearLvl";
            this.lblYearLvl.Size = new System.Drawing.Size(130, 27);
            this.lblYearLvl.TabIndex = 98;
            this.lblYearLvl.Text = "Year Level";
            this.lblYearLvl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(16, 11);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(160, 27);
            this.lblFullName.TabIndex = 97;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxMI
            // 
            this.txtbxMI.Animated = true;
            this.txtbxMI.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbxMI.BorderRadius = 10;
            this.txtbxMI.BorderThickness = 2;
            this.txtbxMI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxMI.DefaultText = "";
            this.txtbxMI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxMI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxMI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxMI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxMI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxMI.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbxMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxMI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxMI.Location = new System.Drawing.Point(243, 41);
            this.txtbxMI.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtbxMI.Name = "txtbxMI";
            this.txtbxMI.PasswordChar = '\0';
            this.txtbxMI.PlaceholderText = "M.I";
            this.txtbxMI.SelectedText = "";
            this.txtbxMI.Size = new System.Drawing.Size(48, 37);
            this.txtbxMI.TabIndex = 96;
            this.txtbxMI.TextChanged += new System.EventHandler(this.txtbxMI_TextChanged);
            // 
            // txtbxLN
            // 
            this.txtbxLN.Animated = true;
            this.txtbxLN.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbxLN.BorderRadius = 10;
            this.txtbxLN.BorderThickness = 2;
            this.txtbxLN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxLN.DefaultText = "";
            this.txtbxLN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxLN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxLN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxLN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxLN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxLN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbxLN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxLN.Location = new System.Drawing.Point(132, 41);
            this.txtbxLN.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtbxLN.Name = "txtbxLN";
            this.txtbxLN.PasswordChar = '\0';
            this.txtbxLN.PlaceholderText = "Last Name";
            this.txtbxLN.SelectedText = "";
            this.txtbxLN.Size = new System.Drawing.Size(106, 37);
            this.txtbxLN.TabIndex = 95;
            this.txtbxLN.TextChanged += new System.EventHandler(this.txtbxLN_TextChanged);
            // 
            // txtbxFN
            // 
            this.txtbxFN.Animated = true;
            this.txtbxFN.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbxFN.BorderRadius = 10;
            this.txtbxFN.BorderThickness = 2;
            this.txtbxFN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxFN.DefaultText = "";
            this.txtbxFN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbxFN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbxFN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxFN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbxFN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxFN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbxFN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbxFN.Location = new System.Drawing.Point(26, 41);
            this.txtbxFN.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtbxFN.Name = "txtbxFN";
            this.txtbxFN.PasswordChar = '\0';
            this.txtbxFN.PlaceholderText = "First Name";
            this.txtbxFN.SelectedText = "";
            this.txtbxFN.Size = new System.Drawing.Size(101, 37);
            this.txtbxFN.TabIndex = 94;
            this.txtbxFN.TextChanged += new System.EventHandler(this.txtbxFN_TextChanged);
            // 
            // StudentSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.cmbYearLvl);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtbxMoney);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbxCPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.txtbxEmailAdd);
            this.Controls.Add(this.lblStudID);
            this.Controls.Add(this.txtbxStudID);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.lblYearLvl);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtbxMI);
            this.Controls.Add(this.txtbxLN);
            this.Controls.Add(this.txtbxFN);
            this.Name = "StudentSignUp";
            this.Size = new System.Drawing.Size(636, 395);
            this.Load += new System.EventHandler(this.StudentSignUp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbSection;
        private Guna.UI2.WinForms.Guna2ComboBox cmbYearLvl;
        private System.Windows.Forms.Label lblMoney;
        private Guna.UI2.WinForms.Guna2TextBox txtbxMoney;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtbxCPass;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtbxPassword;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtbxUsername;
        private System.Windows.Forms.Label lblEmailAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtbxEmailAdd;
        private System.Windows.Forms.Label lblStudID;
        private Guna.UI2.WinForms.Guna2TextBox txtbxStudID;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblYearLvl;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtbxMI;
        private Guna.UI2.WinForms.Guna2TextBox txtbxLN;
        private Guna.UI2.WinForms.Guna2TextBox txtbxFN;
    }
}
