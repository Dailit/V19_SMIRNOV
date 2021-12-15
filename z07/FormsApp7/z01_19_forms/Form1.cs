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
        public Form1()
        {
            InitializeComponent();
        }
        private string Z01()
        {
            StringBuilder text = new StringBuilder(textBox1.Text);
            var count = 0;
            while (text.Length > 0)
            {
                count++;
                text.Replace(new string(text[0], 1), "");
            }

            return count.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = Z01();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
