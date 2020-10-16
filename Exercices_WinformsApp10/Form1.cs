using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercices_WinformsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
