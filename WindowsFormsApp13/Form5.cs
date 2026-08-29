using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox1_TextChanged;

        }
        private int maxlengh = 10;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>maxlengh)
            {
                label1.Visible = true;
                //string str = textBox1.Text.Substring(0, 10);
                //textBox1.Text = str;
                //textBox1.SelectionStart = maxlengh;

            }
            else
            {
                label1.Visible = false;
            }
        }

        
    }
}
