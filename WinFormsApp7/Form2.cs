using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        private Point P;
        public Form2()
        {
            InitializeComponent();
            button1.MouseDown += Button1_MouseDown;
            button1.MouseUp += Button1_MouseUp;
            richTextBox1.GotFocus += RichTextBox1_GotFocus;
        }

        private void RichTextBox1_GotFocus(object sender, EventArgs e)
        {
            this.Close();

        }
        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.MouseMove += Button1_MouseMove;
            P = e.Location;
        }
        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.MouseMove -= Button1_MouseMove;
        }
        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {    //鼠标相对屏幕坐标
            Point m_s =button1.PointToScreen(e.Location);
            //offset(x,y):坐标平移,按键相对于屏幕坐标

            m_s.Offset(-P.X,-P.Y);
            //按键相对于窗体坐标
            Point b_f = this.PointToClient(m_s);
            if(b_f.X < 0) b_f.X = 0;    
            if(b_f.Y < 0)   b_f.Y = 0;
            int MaxX = this.Width - button1.Width;
            int MaxY =this.Height - button1.Height; 
            if(b_f.X>=MaxX)b_f.X=MaxX; 
            if(b_f.Y>=MaxY)b_f.Y=MaxY;
            button1.Location = b_f;







        }
    }
}
