using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercices_WinformsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Carlos");
            listBox1.Items.Add("Toni");
            listBox1.Items.Add("Xesc");
            listBox1.Items.Add("Emilio");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Classroom2Button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Miquel");
            listBox1.Items.Add("Jose");
            listBox1.Items.Add("Juan");
            listBox1.Items.Add("Luisa");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearListButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
