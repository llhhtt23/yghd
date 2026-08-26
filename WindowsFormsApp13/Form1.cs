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
    public partial class Form1 : Form
    {//构造函数，调用
        public Form1()
        {
            InitializeComponent();
            init();

        }
        //绑定事件
        private  void init()
        //    光标离开方法
        {
            tab1.Leave += tab1_Leave;
            //文字变化方法
            tab1.TextChanged += tab1_TextChanged;

            lab2.MouseEnter += lab2_MouseEnter;
            lab2.MouseLeave += lab2_MouseLeave;

        }
        //文字改变触发
        private void tab1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            string conent = tb.Text;
            if (!string.IsNullOrEmpty(conent)) label1.Visible = false;
        }



        //光标离开触发
        private void tab1_Leave(object sender, EventArgs e)
        {
            TextBox tb = (sender as TextBox);
            string conent = tb.Text;
            if (string.IsNullOrEmpty(conent))
            {
                tb.Focus();
                label1.Visible = true;
          
            }

        }


        private void lab2_MouseEnter(object sender, EventArgs e)
        {
           lab2.ForeColor = Color.Red;
            lab2.Font = new Font("宋体",9F,FontStyle.Underline,GraphicsUnit.Point);
        }


        private void lab2_MouseLeave(object sender, EventArgs e)
        {
            lab2.ForeColor = Color.Blue;
            lab2.Font =new  Font("宋体",9F,FontStyle.Regular,GraphicsUnit.Point);
            
        }






                private void textBox1_TextChanged(object sender, EventArgs e)
                {

                }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
