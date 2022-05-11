using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticcket
{
    public partial class PasswordChanging : Form
    {
        public PasswordChanging()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            oragniser_account s = new oragniser_account();
            s.BringToFront();

        }

        private void PasswordChanging_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxShowPass1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass1.Checked)
            {
                OldPass.PasswordChar = '\0';
                NewPass.PasswordChar = '\0';
                ConfirmPass.PasswordChar = '\0';
            }
            else
            {
                OldPass.PasswordChar = '•';
                NewPass.PasswordChar = '\0';
                ConfirmPass.PasswordChar = '\0';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OldPass.Clear();
            NewPass.Clear();
            ConfirmPass.Clear();
            OldPass.Focus();
        }
    }
}
