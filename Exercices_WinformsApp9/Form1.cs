using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercices_WinformsApp9
{
    public partial class Form1 : Form
    {
        int evenNumber;
        int oddNumber = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void evenButton_Click(object sender, EventArgs e)
        {
            if (evenNumber<10)
            {
                comboBox1.Items.Add(evenNumber);
                evenNumber += 2;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void oddButton_Click(object sender, EventArgs e)
        {
            if (oddNumber < 10)
            {
                comboBox1.Items.Add(oddNumber);
                oddNumber += 2;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
