using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercices_WinformsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(colorsComboBox.SelectedIndex == 0)
            {
                textBox1.Text = "The choosen color is: Yellow";

            }else if (colorsComboBox.SelectedIndex == 1)
            {
                textBox1.Text = "The choosen color is: Red";
                
            }
            else if (colorsComboBox.SelectedIndex == 2)
            {
                textBox1.Text = "The choosen color is: Blue";
            }
            else if (colorsComboBox.SelectedIndex == 3)
            {
                textBox1.Text = "The choosen color is: White";
            }
            else if (colorsComboBox.SelectedIndex == 4)
            {
                textBox1.Text = "The choosen color is: Black";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
