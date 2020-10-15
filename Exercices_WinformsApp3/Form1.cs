using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercices_WinformsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            int Operand1 = Int32.Parse(textBox1.Text);
            int Operand2 = Int32.Parse(textBox2.Text);
            int Result = Operand1 + Operand2;
            
            textBox3.Text = Result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
