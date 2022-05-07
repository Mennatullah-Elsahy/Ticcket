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
    public partial class Start1 : Form
    {
        public Start1()
        {
            InitializeComponent();
        }

        private void Btnstart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_In   o = new Sign_In();
            o.ShowDialog();
        }

        private void Start1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
