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
    public partial class Form4 : Form
    {
        private int speed = 8;

        private DateTime StartTime { get; set; }

        public Form4()
        {
            InitializeComponent();
            //this代表form4自己
            this.KeyDown += Move_KeyDown;
             this.KeyUp += keyUp_KeyUp;


        }
        private bool flag = true;
        private void keyUp_KeyUp(object sender, KeyEventArgs e)
        {
            flag = true;
            DateTime EndTime=DateTime.Now;
            TimeSpan diff= EndTime - StartTime;
            LabelTime.Text = diff.TotalMilliseconds.ToString();
        }







        private void Move_KeyDown(object sender, KeyEventArgs e)
        {


            if (flag)
            {


                StartTime = DateTime.Now;
                flag = false;
            }
            Point bl = box.Location;
            int formWidth = this.Width;
            int formHeight = this.Height;
            int boxHeight = box.Height;
            int boxWidth = box.Width;
            int xMax = formWidth - boxWidth;
            int yMax = formHeight - boxHeight;
            switch (e.KeyCode)
            {
                case Keys.W:
                    bl.Y -= speed;
                    if (bl.Y < 0) bl.Y = 0;
                    break;
                case Keys.S:
                    bl.Y += speed;
                    if (bl.Y >= yMax) bl.Y = yMax;
                    break;
                case Keys.A:
                    bl.X -= speed;
                    if (bl.X < 0) bl.X = 0;
                    break;
                case Keys.D:
                    bl.X += speed;
                    if (bl.X >= xMax) bl.X = xMax;
                    break;
            }
            //写回
            box.Location = bl;
            if (e.KeyCode == Keys.Escape) this.Close();
        }
            
        }

        
    
}
