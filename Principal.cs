﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winToolZeroX
{
    public partial class Principal : Form
    {
        Form1 youtube=new Form1 ();
        public Principal()
        {
            InitializeComponent();
        }

        private void btnOpenYoutube_Click(object sender, EventArgs e)
        {
            youtube.Show();
        }
    }
}
