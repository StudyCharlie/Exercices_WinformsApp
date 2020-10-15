using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercices_WinformsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (RedButton.Checked == true)
            {
                textBox1.Text = "Choosen colour: Red ";
            }

            else if (BlueButton.Checked == true)
            {
                textBox1.Text = "Choosen colour: Blue ";
            }

            else if (WhiteButton.Checked == true)
            {
                textBox1.Text = "Choosen colour: White ";
            }
            
            else
            {
                textBox1.Text = "Choosen colour: ";
            }
        }
    }
}
