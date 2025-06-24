using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FInalLibrarySystem.frmLogin;

namespace FInalLibrarySystem
{
    public partial class frmSignUp : Form
    {



        public frmSignUp()
        {
            InitializeComponent();
            

        }

        private void frmPrompt_Load(object sender, EventArgs e)
        {
            studentSignUp1.Visible = false;
            teacherSignUp1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            studentSignUp1.Visible = false;
            teacherSignUp1.Visible = true;


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFNT_Click(object sender, EventArgs e)
        {

        }

        private void txtFNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMIT_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEAddT_Click(object sender, EventArgs e)
        {

        }

        private void lblPassT_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCPassT_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnStudent_CheckedChanged(object sender, EventArgs e)
        {
            studentSignUp1.Visible = true;
            teacherSignUp1.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            frmLogin f2 = new frmLogin();
            f2.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin f2 = new frmLogin();
            f2.Show();
        }

        private void teacherSignUp1_Load(object sender, EventArgs e)
        {

        }

        private void lnkTeacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp f2 = new frmSignUp();
            f2.Visible = false;
            teacherSignUp1.Visible = true;
        }

        private void lnkStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           studentSignUp1.Visible = true;
            teacherSignUp1.Visible = false;
        }

        private void lnkTeacher_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkStudent_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
