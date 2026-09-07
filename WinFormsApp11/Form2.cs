using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11
{
   
    public partial class Form2 : Form
    {


        private int Num = 0;
        public Form2()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;
        }

        private int Radius = 100;
        private int RadiusX = 150;
        private int RadiusY = 150;
        private int LongScale = 10;
        private int Count = 30;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.Green, 3))
            using (Pen M = new Pen(Color.Orange, 3))
            {
                g.DrawArc(p, RadiusX - Radius, RadiusY - Radius, 2 * Radius, 2 * Radius, 180, 180);
                var tmpLong = LongScale;
                for (int i = 0; i < Count; i++)
                {
                    if (i % 10 == 0) tmpLong = 2 * LongScale;
                    var startX = Math.Cos((6* i+180 )* Math.PI / 180) * Radius + RadiusX;
                    var startY = Math.Sin((6 * i+180) * Math.PI / 180) * Radius + RadiusY;

                    var endX = Math.Cos((6 * i+180) * Math.PI / 180) * (Radius - tmpLong) + RadiusX;
                    var endY = Math.Sin((6* i+180) * Math.PI / 180) * (Radius - tmpLong) + RadiusY;
                    g.DrawLine(M, (int)startX, (int)startY, (int)endX, (int)endY);
                    tmpLong = LongScale;

                }
                using (Pen pRed = new Pen(Color.Red, 2))
                {
                    //把起点从三点挪到12点
                    var endX = Math.Cos(((6) * Num + 270) * Math.PI / 180) * (Radius - tmpLong) + RadiusX;
                    var endY = Math.Sin(((6) * Num + 270) * Math.PI / 180) * (Radius - tmpLong) + RadiusY;
                    g.DrawLine(pRed, RadiusX, RadiusY, (int)endX, (int)endY);
                }

                Font font = new Font("微软雅黑", 12);
                SolidBrush brush = new SolidBrush(Color.Black);
                int[] numList = { 0, 20, 40, 60 };
                foreach(var num in numList)
                {
                    double deg = 180 - num * 3;
                    double rad = deg * Math.PI / 180;
                     double tx = RadiusX + Math.Cos(rad) * (Radius-25);
                    double ty = RadiusY - Math.Sin(rad) * (Radius-25);
                    g.DrawString(num.ToString(),font,brush,(float)tx,(float)ty);
                }


                    

            }
        }
    }
}
