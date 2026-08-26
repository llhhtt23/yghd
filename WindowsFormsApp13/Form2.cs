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
    public partial class Form2 : Form
    {
        private string[] picArr = { @"./images/bird.jpg", @"./images/cat.jpg", @"./images/eagle.jpg" };
        private int index = 0;
        List<Button> btnList = new List<Button>();

        public Form2()
        {
            InitializeComponent();
            InitLunBo();
        }
        private void InitLunBo()
        {
            btnList.Add(button1);
            btnList.Add(button2);
            btnList.Add(button3);
            Label[] labs = { label1, label2 };
            foreach (Label lab in labs) lab.Click += Lab_Click;
            foreach (Button btn in btnList) btn.Click += Btn_Click;
            Lunbo();
        }
        private void Btn_Click(object sender, EventArgs e)

        {
            index=btnList.IndexOf(sender as Button);
            Lunbo();
        }
        private void Lab_Click(object sender, EventArgs e)
        {
            Label lab = (sender as Label);
            if (lab.Text == ">")
            {
                index = (index == picArr.Length - 1) ? 0 : (++index);
            }
            else
            {
                index = (index == 0) ? picArr.Length - 1 : (--index);
            }
            Lunbo();
        }

        private void Lunbo()
        {
            pictureBox1.Image = Image.FromFile(picArr[index]);
            btnList.ForEach(btn =>
            {
                btn.BackColor = Color.DarkGray;
                btn.ForeColor = Color.Black;

            });

            btnList[index].BackColor = Color.Orange;
            btnList[index].ForeColor = Color.White;


        



        }
    }
}
