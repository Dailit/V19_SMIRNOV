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

        public Form2()
        {
            InitializeComponent();
        }
        private string Z02()
        {
            List<string> lst = textBox1.Text.Split(' ').ToList();
            lst = lst.OrderBy(x => x.Length).ToList();          
            return string.Join(" ", lst);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = Z02();
        }
    }
}
