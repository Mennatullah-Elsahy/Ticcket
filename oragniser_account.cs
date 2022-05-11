using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Ticcket
{
    public partial class oragniser_account : UserControl
    {
        public oragniser_account()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bTnDesign1_Click(object sender, EventArgs e)
        {

        }

        private void bTnDesign3_Click(object sender, EventArgs e)
        {

           
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void bTnDesign4_Click(object sender, EventArgs e)
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
                Picture.Text = "❗️ Please Select another photo";
            }
        }

        private void oragniser_account_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            PasswordChanging o = new PasswordChanging();
            o.ShowDialog();
        }

        private void Btnstart_Click(object sender, EventArgs e)
        {
            label4.Text = "Saved";
        }
    }
}
