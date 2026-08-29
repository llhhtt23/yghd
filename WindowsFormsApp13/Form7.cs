using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            initfenge();
        }

      private void initfenge()
        {
            textBox1.TextChanged += textBox1_TextChanged;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text=textBox1.Text;
            text = Regex.Replace(text, @",", "");
            int num = int.Parse(text);
            string result = num.ToString("#,#");
            textBox1.Text= result;
            textBox1.SelectionStart = result.Length;
        }
    }
}
