using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp9
{

    //1. 你点 UCBook 的按钮

//2. 把界面上：书名、价格、作者、编号全部装进 BookInfo 对象

//3. 通过 SendData 事件，一次性把这一整包数据发给外面主窗体

//4. 主窗体拿到这一包，再存到 json、列表里面

//不写 BookInfo 的麻烦：
//事件要分开传好多个参数（名字传一次、价格传一次、作者传一次），代码很乱。
//有 BookInfo：一包带走全部信息。
    internal class Bookinfo
    {
        public string Id {  get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price{ get; set; }
        public string BookLabel{ get; set; }
        public bool IsBorrow { get; set; }


    }
}
