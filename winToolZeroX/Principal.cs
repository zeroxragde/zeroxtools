using System;
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
        Form1 youtube = new Form1();
        ConversorWEBToPNG conversor = new ConversorWEBToPNG();
        public Principal()
        {
            InitializeComponent();
        }


        private void parrotSuperButton1_Click(object sender, EventArgs e)
        {
            if (youtube.IsDisposed)
            {
                youtube = new Form1();
            }
            youtube.Show();
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void parrotSuperButton2_Click(object sender, EventArgs e)
        {
            if (conversor.IsDisposed)
            {
                conversor = new ConversorWEBToPNG();
            }
            conversor.Show();
        }
    }
}
