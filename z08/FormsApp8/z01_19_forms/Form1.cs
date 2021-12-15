using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace z01_19_forms
{
    public partial class Form1 : Form
    {     
        public Form1()
        {
            InitializeComponent();
        }
        private string ReplaceTime()
        {
            string sentence = textBox1.Text;
            int minutes;
            int.TryParse(textBox2.Text, out minutes);
            var templ = @"\d{1,3}:\d{1,3}";
            var results = Regex.Matches(sentence, templ);
            for (var i = 0; i < results.Count; i++)
            {
                var hhss = results[i].Value.Split(':');
                var hh = Convert.ToInt32(hhss[0]);
                var mm = Convert.ToInt32(hhss[1]);
                if (hh >= 0 && hh < 24 && mm >= 0 && mm < 60)
                {
                    var time = new TimeSpan(hh, mm, 0).Add(new TimeSpan(00, minutes, 0));
                    sentence = Regex.Replace(sentence, templ, time.ToString(@"hh\:mm"));
                }
            }
            return sentence;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = ReplaceTime();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
