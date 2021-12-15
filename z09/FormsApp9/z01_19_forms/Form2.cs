using System;
using System.IO;
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

        public Form2()
        {
            InitializeComponent();
        }
        private void z02()
        {
            string text = File.ReadAllText("../../text.txt");
            int x = 0;
            text = text.Where(i =>
            {
                if (++x == 2)
                    x = 0;
                return (x != 0);
            }).Aggregate("", (acc, y) => acc + y);
            File.WriteAllText( "../../output.txt", text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "Переписано в файл output.txt";
            z02();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
