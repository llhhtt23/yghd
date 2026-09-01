using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9.Controls
{
    public partial class UCBook : UserControl
    {
        public UCBook()
        {
            InitializeComponent();
        }


        public UCBook(string text)
        {
            InitializeComponent();
            button1.Text = text;
            label1.Text = "图书"+text;
        }

        //1. 你点 UCBook 的按钮

        //2. 把界面上：书名、价格、作者、编号全部装进 BookInfo 对象

        //3. 通过 SendData 事件，一次性把这一整包数据发给外面主窗体

        //4. 主窗体拿到这一包，再存到 json、列表里面

        //不写 BookInfo 的麻烦：
        //事件要分开传好多个参数（名字传一次、价格传一次、作者传一次），代码很乱。
        //有 BookInfo：一包带走全部信息。

        //新建用户控件，VS自动给internal(只能本项目用）
        internal event Action<Bookinfo> SendData;

        private void button1_Click(object sender, EventArgs e)
        {
            //invoke:子线程想改界面，委托主线程去干活
            SendData.Invoke(new Bookinfo()
            {
                Id = Guid.NewGuid().ToString(),
                Name =labname.Text,
                Author=labauthor.Text,
                Price=double.Parse(labprice.Text),
                BookLabel=lablabel.Text,
                IsBorrow=false,

            });
        }
    }
}
