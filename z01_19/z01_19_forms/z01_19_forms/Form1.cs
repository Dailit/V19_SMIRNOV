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
    public partial class Form1 : Form
    {
        private float b1;
        private float q;
        private int n;
        public Form1()
        {
            InitializeComponent();
        }
        private string Summ()
        {
            string result;
            if (float.TryParse(textBox1.Text, out b1) && float.TryParse(textBox2.Text, out q) && int.TryParse(textBox3.Text, out n))
            {
                double qn = 0;
                double s = 0;
                if (q != 1)
                {
                    if (q > 0)
                        qn = Math.Exp(Math.Log(q) * n);
                    else
                        if (q < 0)
                        qn = -Math.Exp(Math.Log(-q) * n);
                    else
                        qn = 0;
                    s = b1 * (1 - qn) / (1 - q);
                }
                else
                    s = n * b1;
                result = s.ToString();
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
            label5.Text = Summ();
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
