using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z01_19_forms
{
    public partial class Form2 : Form
    {
        private float a;
        private float b;
        private float c;
        public Form2()
        {
            InitializeComponent();
        }
        private string Equilateral()
        {
            string result;
            if (float.TryParse(textBox1.Text, out a) && float.TryParse(textBox2.Text, out b) && float.TryParse(textBox3.Text, out c))
            {
                if (a == b && b == c)
                    result = "Треугольник равносторонний";
                else
                    result = "Треугольник не равносторонний";
            }
            else
                result = "Некорректные данные";
            return result;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = Equilateral();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}
