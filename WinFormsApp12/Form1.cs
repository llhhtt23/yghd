using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static WinFormsApp12.Form1;

namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += GameInit;
        }
        private Random random = new Random();
        private List<labandtimer> labandtimers = new();
        private System.Windows.Forms.Timer Alltime = new();
        private int score = 0;
        private void GameInit(object sender, EventArgs e)
        {
            Alltime.Interval = 1000;
            Alltime.Tick += (Object sender, EventArgs e) => CreatLab();
            this.KeyPreview = true;
            this.ActiveControl = null;
            this.KeyUp += Form1_KeyUp;
        }





        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            for (int i = 0; i < labandtimers.Count; i++)
            {
                if (Enum.TryParse(labandtimers[i].Lab.Text, true, out Keys k))
                {
                    if (k != e.KeyCode) continue;
                    panel1.Controls.Remove(labandtimers[i].Lab);
                    labandtimers[i].Timer.Stop();
                    labandtimers.RemoveAt(i);
                    label2.Text = (++score).ToString();
                    return;

                }
            }
        }




        public class labandtimer
        {
            public Label Lab { get; set; }

            public System.Windows.Forms.Timer Timer { get; set; }
            public labandtimer(Label lb, System.Windows.Forms.Timer tm)
            {

                Lab = lb;
                Timer = tm;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            label2.Text = "0";
            Alltime.Start();
        }
        private void CreatLab()
        {
            Label lab = new Label();
            lab.Text = ((char)random.Next(65, 91)).ToString();
            lab.Size = new Size(30, 30);
            lab.Location = new Point(random.Next(panel1.Width - 30), 0);
            lab.TextAlign = ContentAlignment.MiddleCenter;
            lab.Font = new Font("Î¢ÈíÑÅºÚ", 14F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Controls.Add(lab);
            System.Windows.Forms.Timer lt = new();
            lt.Interval = 10;
            lt.Tick += (object sender, EventArgs e) =>labdown (lab);
            lt.Start();
            labandtimers.Add(new labandtimer(lab, lt));
        }

        private void labdown(Label lab )

        {
            lab.Top += 2;
            if(lab.Top>=panel1.Height-30)
            {
                 Alltime.Stop();
                labandtimers.ForEach(item =>item.Timer.Stop());
                MessageBox.Show("gameover");
                panel1.Controls.Clear();
                labandtimers.Clear();
            }
        }




    }
}

