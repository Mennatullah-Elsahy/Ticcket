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
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
            TxtUserName.Focus();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            bool em = isvalid_email(TxtUserEmail.Text);
            if (TxtUserName.Text == string.Empty)
            {
                TxtUserName.Focus();
                errorName.SetError(TxtUserName, "Reqiired");
            }
            if (em == false)
                errorEmail.SetError(TxtUserEmail, "Email Format is incorrect");
            if (TxtUserEmail.Text == string.Empty)
            {
                TxtUserEmail.Focus();
                errorEmail.SetError(TxtUserEmail, "Reqiired");
            }
            if (TxtUserPass.Text == string.Empty)
            {
                TxtUserPass.Focus();
                errorPass.SetError(TxtUserPass, "Reqiired");
            }
            if (TxtUserConfirmPass.Text == string.Empty)
            {
                TxtUserConfirmPass.Focus();
                errorConfirmPass.SetError(TxtUserConfirmPass, "Reqiired");
            }
            
            if (TxtUserName.Text == "" && TxtUserEmail.Text == "" && TxtUserPass.Text == "" && TxtUserConfirmPass.Text == "")
            {
                label1.Text = "❗️ Registration is empty, Please fill in all fields";
                TxtUserName.Focus();
            }

            else if (TxtUserPass.Text != TxtUserConfirmPass.Text)
            {
                label1.Text = "❗️ The password doesn't match, please Re-ente ";
                TxtUserPass.Focus();
            }
            else if (TxtUserName.Text == string.Empty)
            {
                TxtUserName.Focus();
                errorName.SetError(TxtUserName, "Reqiired");
            }
            else if (TxtUserEmail.Text == string.Empty)
            {
                TxtUserEmail.Focus();
                errorEmail.SetError(TxtUserEmail, "Reqiired");
            }
            else if (TxtUserPass.Text == string.Empty)
            {
                TxtUserPass.Focus();
                errorPass.SetError(TxtUserPass, "Reqiired");
            }
            else if (TxtUserConfirmPass.Text == string.Empty)
            {
                TxtUserConfirmPass.Focus();
                errorConfirmPass.SetError(TxtUserConfirmPass, "Reqiired");
            }
            else if (em == false)
            {
                TxtUserEmail.Focus();
                errorEmail.SetError(TxtUserEmail, "Email Format is incorrect");
            }
            else
            {
                this.Hide();
                organiser f = new organiser();
                f.ShowDialog();
            }
            

        }

        public bool isvalid_email(string email)
        {
            Regex check = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            bool valid = false;
            valid = check.IsMatch(email);
            if (valid == true)
                return true;
            else
            {
                errorEmail.SetError(TxtUserEmail, "Email Format is incorrect");
                return false;
            }
        }

            private void sign_up_Load(object sender, EventArgs e)
        {

        }

        private void TxtUserConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_In o = new Sign_In();
            o.ShowDialog();
        }

        private void Btnsignup_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Sign_In o = new Sign_In();
            o.ShowDialog();
        }

        
       

        private void checkBoxShowPass1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxShowPass1.Checked)
            {
                TxtUserPass.PasswordChar = '\0';
                TxtUserConfirmPass.PasswordChar = '\0';
            }
            else
            {
                TxtUserPass.PasswordChar = '•';
                TxtUserConfirmPass.PasswordChar = '•';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void label4_Click(object sender, EventArgs e)
        {
            TxtUserName.Clear();
            TxtUserEmail.Clear();
            TxtUserPass.Clear();
            TxtUserConfirmPass.Clear();
            TxtUserName.Focus();
        }

        private void TxtUserEmail_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void TxtUserConfirmPass_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUserEmail_Validating(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TxtUserEmail.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TxtUserPass.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TxtUserConfirmPass.Focus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TxtUserName.Focus();
        }

        private void bTnDesign7_Click(object sender, EventArgs e)
        {
            TxtUserName.Focus();
        }

        private void bTnDesign8_Click(object sender, EventArgs e)
        {

        }

        private void bTnDesign9_Click(object sender, EventArgs e)
        {
            TxtUserPass.Focus();
        }

        private void bTnDesign6_Click(object sender, EventArgs e)
        {
            TxtUserConfirmPass.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            TxtUserName.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            TxtUserEmail.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            TxtUserPass.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            TxtUserConfirmPass.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            TxtUserName.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TxtUserName.Focus();
        }
    }
}
