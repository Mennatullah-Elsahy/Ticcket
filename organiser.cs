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
    public partial class organiser : Form
    {
        public organiser()
        {
            InitializeComponent();
            Sidepanel.Height = Btnhome.Height;
            Sidepanel.Top = Btnhome.Top;
            organiser_Home1.BringToFront();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help t = new Help();
            t.ShowDialog();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = BtnLogOut.Height;
            Sidepanel.Top = BtnLogOut.Top;
            this.Hide();
            Sign_In o = new Sign_In();
            o.ShowDialog();

        }

        private void Sidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btnhome_Click_1(object sender, EventArgs e)
        {
            Sidepanel.Height = Btnhome.Height;
            Sidepanel.Top = Btnhome.Top;
            organiser_Home1.BringToFront();
        }

        private void Btnevent_Click_1(object sender, EventArgs e)
        {
            Sidepanel.Height = Btnevent.Height;
            Sidepanel.Top = Btnevent.Top;
            organiser_event1.BringToFront();
        }

        private void Btnsearch_Click_1(object sender, EventArgs e)
        {
            Sidepanel.Height = Btnsearch.Height;
            Sidepanel.Top = Btnsearch.Top;
            organiser_search1.BringToFront();
        }

        private void Btnaccount_Click_1(object sender, EventArgs e)
        {
            Sidepanel.Height = Btnaccount.Height;
            Sidepanel.Top = Btnaccount.Top;
            oragniser_account1.BringToFront();
        }
    }
}