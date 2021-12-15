using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace z01_19_forms
{
    public partial class Form1 : Form
    {     
        public Form1()
        {
            InitializeComponent();
        }
        private string z01()
        {
            string filetext = File.ReadAllText("../../text.txt");
            string[] text = filetext.Split(' ');
            string result ="";
            foreach (var item in text)
            {
                if (item[0] == text[text.Length - 1][0]) result= result + item+ "\n";
            }
            return result;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = z01();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
