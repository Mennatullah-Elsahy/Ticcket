using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ticcket
{
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
            
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Txtemail.Clear();
            Txtpassword.Clear();
            Txtemail.Focus();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Txtemail.Focus();
        }

        private void Btndash_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Txtemail.Focus();
        }

        private void Btndash_Click_2(object sender, EventArgs e)
        {
            string Email = Txtemail.Text;
            string password = Txtpassword.Text;
            if (Email == "Mennatullah@gmail.com" && password == "1234")
            {

                this.Hide();
                organiser f = new organiser();
                f.ShowDialog();


            }
            else if (Txtemail.Text == string.Empty && Txtpassword.Text == string.Empty)
            {
                Txtemail.Focus();
                errorProvider1.SetError(Txtemail, "Reqiired");
                errorProvider2.SetError(Txtpassword, "Reqiired");
            }
            else if (Txtemail.Text == string.Empty)
            {
                Txtemail.Focus();
                errorProvider1.SetError(Txtemail, "Reqiired");
            }
            else if (Txtpassword.Text == string.Empty)
            {
                Txtpassword.Focus();
                errorProvider2.SetError(Txtpassword, "Reqiired");
            }
            else
            {
                label1.Text = "❗️ Email or password is incorrect, please try again";
                Txtpassword.Clear();
                Txtemail.Focus();
            }
            if (Txtemail.Text == string.Empty)
            {
                Txtemail.Focus();
                errorProvider1.SetError(Txtemail, "Reqiired");
            }
            if (Txtpassword.Text == string.Empty)
            {
                Txtpassword.Focus();
                errorProvider2.SetError(Txtpassword, "Reqiired");
            }
        }
        
        private void Btnsignup_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            sign_up X = new sign_up();
            X.ShowDialog();
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Txtemail.Clear();
            Txtpassword.Clear();
            Txtemail.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Txtemail.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Txtpassword.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Txtemail.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Txtpassword.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            Txtemail.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Txtpassword.Focus();
        }

        private void Txtemail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxShowPass1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass1.Checked)
            {
                Txtpassword.PasswordChar = '\0';
            }
            else
            {
                Txtpassword.PasswordChar = '•';
            }

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 }

