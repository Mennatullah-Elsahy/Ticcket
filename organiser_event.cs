﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticcket
{
    public partial class organiser_event : UserControl
    {
        public organiser_event()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Event o = new Create_Event();
            o.ShowDialog();
        }
    }
}
