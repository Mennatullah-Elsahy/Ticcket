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
    public partial class Create_Event : Form
    {
        public Create_Event()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "icon";
                openFileDialog.Filter = "icon(*.png;*.jpeg;*.Gif;)|*.png;*.jpeg;*.Gif;";
                openFileDialog.ShowDialog();
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
            catch
            {
                Logo.Text = "❗️ Please Select another photo";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            organiser_event s = new organiser_event();
            s.BringToFront();
        }
    }
}
