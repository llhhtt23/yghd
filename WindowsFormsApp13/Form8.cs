using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form8: Form
    {
        public Form8()
        {
            InitializeComponent();
            InitTotal();
        }
        private List<Dictionary<string, Control>> ConList = new List<Dictionary<string, Control>>();
        private void InitTotal()
        {
          
            ConList.Add(new Dictionary<string, Control>
            {
                ["price"] = label5,
                ["count"] = textBox1,
                ["reduce"] = button1,
                ["add"]= button2

            });
            ConList.Add(new Dictionary<string, Control>
            {
                ["price"] = label6,
                ["count"] = textBox2,
                ["reduce"]=button3,
                ["addBtn"] =button4
            });
            // 初始化 的 进行统计
            GetTotal();
            // 给数量输入框控件 添加 内容改变事件
         

            //遍历给输入框绑定事件
            ConList.ForEach(tb => tb["count"].TextChanged += TextChanged);
            ConList.ForEach(tb => tb["reduceBtn"].Click+=Reduce);
            ConList.ForEach(tb => tb["addBtn"].Click += Add);
        }
        private void Add(object sender, EventArgs e)

        {
            Dictionary<string, Control> dic = ConList.Find(item => item["Add"] == (sender as Button));
            if (string.IsNullOrEmpty(dic["count"].Text))
            {
                dic["count"].Text = "0";
                (dic["count"] as TextBox).SelectionStart = 1;
                int n = int.Parse(dic["count"].Text);
                dic["count"].Text = (++n).ToString();
            }
        }

        private void Reduce(object sender,EventArgs e)

        {
            Dictionary<string, Control> dic = ConList.Find(item => item["Reduce"]==(sender as Button));
            if(string.IsNullOrEmpty(dic["count"].Text))
            {
                dic["count"].Text = "0";
                (dic["count"] as TextBox).SelectionStart=1;
                int n =int.Parse(dic["count"].Text);
                if (n <=0) return;
                dic["count"].Text= (--n).ToString();
            }


        }

        private void TextChanged(object sender, EventArgs e)
        {
            GetTotal();
        }

        // 统计总价方法
        private void GetTotal()
        {
            // 遍历ConList 直接计算总价
            int sum = 0;

            ConList.ForEach(item =>
            {
                if (!Regex.IsMatch(item["count"].Text, @"^[1-9]\d*$"))
                {
                    item["count"].Text = "1";
                    (item["count"] as TextBox).SelectionStart = 1;
                }
                int price = int.Parse(item["price"].Text);
                int count = int.Parse(item["count"].Text);
                sum += price * count; 
            });
            label8.Text = sum.ToString();
           

            }
        }
       
         
        }


   
