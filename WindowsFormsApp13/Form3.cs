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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            button1.GotFocus += Button1_GotFocus;
            button1.Leave += Button1_Leave;
            textBox1.Leave += TextBox1_Leave;
            textBox1.GotFocus += TextBox1_GotFocus;
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;

            (sender as TextBox).ForeColor = Color.Black;
            (sender as TextBox).BorderStyle = BorderStyle.FixedSingle;
        }
        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.Orange;

            (sender as TextBox).ForeColor = Color.Blue;
            (sender as TextBox).BorderStyle = BorderStyle.Fixed3D;
        }


        private void Button1_Leave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.White;

            (sender as Button).ForeColor = Color.Black;
        }

             private void Button1_GotFocus(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Orange;

            (sender as Button).ForeColor = Color.Blue;
            
        }

    }
    }

