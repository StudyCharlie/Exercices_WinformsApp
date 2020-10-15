using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_WinformsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Classroom1Button_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.Add("Carlos");
            listBox.Items.Add("Toni");
            listBox.Items.Add("Xesc");
            listBox.Items.Add("Emilio");
            
        }

        private void Classroom2Button_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.Add("Miquel");
            listBox.Items.Add("Jose");
            listBox.Items.Add("Juan");
            listBox.Items.Add("Luisa");
        }

        private void listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearListButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
