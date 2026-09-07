using System.Drawing.Text;
using static System.Windows.Forms.AxHost;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private int Num = 0;
        public Form1()
        {
            InitializeComponent();
            panel1.Paint += Panel1_Paint;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Num = DateTime.Now.Second;
            panel1.Invalidate();
        }

        private int Radius = 100;
        private int CenterX = 150;
        private int CenterY = 150;
        private int LongScale = 10;
        private int Count = 60;





        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen p = new Pen(Color.Blue, 8))
            {
                g.DrawArc(p, CenterX - Radius, CenterY - Radius, 2 * Radius, 2 * Radius, 0, 360);
                var tmpLong = LongScale;
                for (int i = 0; i < Count; i++)
                {
                    if (i % 5 == 0) tmpLong = 2 * LongScale;


                    var startX = Math.Cos((6) * i * Math.PI / 180) * Radius + CenterX;

                    var startY = Math.Sin((6) * i * Math.PI / 180) * Radius + CenterY;
                    var endX = Math.Cos((6) * i * Math.PI / 180) * (Radius - tmpLong) + CenterX;


                    var endY = Math.Sin((6) * i * Math.PI / 180) * (Radius - tmpLong) + CenterY;

                    g.DrawLine(p, (int)startX, (int)startY, (int)endX, (int)endY);
                    tmpLong = LongScale;
                }


                using (Pen pRed = new Pen(Color.Red, 2))
                {
                    //把起点从三点挪到12点
                    var endX = Math.Cos(((6) * Num + 270) * Math.PI / 180) * (Radius - tmpLong) + CenterX;
                    var endY = Math.Sin(((6) * Num + 270) * Math.PI / 180) * (Radius - tmpLong) + CenterY;
                    g.DrawLine(pRed, CenterX, CenterY, (int)endX, (int)endY);
                }





            }
        }
    }
    public class DoubleBufferPanel : Panel
    {
        public DoubleBufferPanel()
        {
            //开启双缓冲，消除闪烁
            this.SetStyle(ControlStyles.UserPaint
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }
    }
}





