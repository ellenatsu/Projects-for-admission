﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourWH
{
    public partial class first : Form
    {
        public first()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1frm = new Form1();
            form1frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            intro introfrm = new intro();
            introfrm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
