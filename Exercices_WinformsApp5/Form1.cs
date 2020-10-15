using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercices_WinformsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MouseBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void catBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dogBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MouseBox.Checked == true
                && catBox.Checked == false &&
                dogBox.Checked == false)
            {
                textBox1.Text = "Choosen animals: mouse";
            }

            else if (MouseBox.Checked == true
                && catBox.Checked == true &&
                dogBox.Checked == false)
            {
                textBox1.Text = "Choosen animals: mouse cat";
            }

            else if (MouseBox.Checked == true 
                && catBox.Checked == true &&
                dogBox.Checked == true)
            {
                textBox1.Text = "Choosen animals: mouse cat dog";
            }

            else if (MouseBox.Checked == false
                && catBox.Checked == true &&
                dogBox.Checked == false)
            {
                textBox1.Text = "Choosen animals: cat";
            }

            else if (MouseBox.Checked == false
                && catBox.Checked == true &&
                dogBox.Checked == true)
            {
                textBox1.Text = "Choosen animals: cat dog";
            }
            else if (MouseBox.Checked == true
                && catBox.Checked == false &&
                dogBox.Checked == true)
            {
                textBox1.Text = "Choosen animals: mouse dog";
            }
            else if (MouseBox.Checked == false
                && catBox.Checked == false &&
                dogBox.Checked == true)
            {
                textBox1.Text = "Choosen animals: dog";
            }
            else
            {
                textBox1.Text = "Choosen animals: ";
            }
        }
    }
}
