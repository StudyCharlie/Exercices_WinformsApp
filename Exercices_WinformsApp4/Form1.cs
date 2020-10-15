using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercices_WinformsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OperationChoosed_TextChanged(object sender, EventArgs e)
        {

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            OperationChoosed.Text = "+";
        }

        private void SubstractButton_Click(object sender, EventArgs e)
        {
            OperationChoosed.Text = "-";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (OperationChoosed.Text == "+")
            {
                int Operand1 = Int32.Parse(textBox1.Text);
                int Operand2 = Int32.Parse(textBox2.Text);
                int Result = Operand1 + Operand2;

                resultBox.Text = Result.ToString();
            }
            else if (OperationChoosed.Text == "-")
            {
                int Operand1 = Int32.Parse(textBox1.Text);
                int Operand2 = Int32.Parse(textBox2.Text);
                int Result = Operand1 - Operand2;

                resultBox.Text = Result.ToString();
            }
        }
        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            resultBox.Text = "0";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 0)
            {
                OperationChoosed.Text = "+";
            }
            else if (listBox1.SelectedIndex == 1)
            {
                OperationChoosed.Text = "-";
            }
        }
    }
}

