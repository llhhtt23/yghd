using System.ComponentModel.Design;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("请输入你的年龄");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入你的资产");
            //int zichan = int.Parse(Console.ReadLine());
            //bool res = zichan > 300 && age < 20;
            //Console.WriteLine(res ? "ok" : "no");

            //Console.WriteLine("输入你的成绩");
            //int score = int.Parse(Console.ReadLine());
            //if (score < 60)
            //{ Console.WriteLine("不及格{score}"); }
            //else if (score < 80)
            //{ Console.WriteLine("良好{score}"); }
            //else if (score < 90)
            //{ Console.WriteLine("优秀{score}"); }
            //else if (score <= 100)
            //{ Console.WriteLine("无敌{score}"); }
            //else
            //{ Console.WriteLine("无效"); }
            //Console.WriteLine("王帅请输入你的分数");
            //int score = int.Parse(Console.ReadLine());
            //if (score > 0 && score <= 100)
            //{
            //    int n = score / 10;
            //    switch (n)
            //    {
            //        case 0: Console.WriteLine($"{score}分数，等级是F"); break;
            //        case 1: Console.WriteLine($"{score}分数，等级是F"); break;
            //        case 2: Console.WriteLine($"{score}分数，等级是F"); break;
            //        case 3: Console.WriteLine($"{score}分数，等级是F"); break;
            //        case 4: Console.WriteLine($"{score}分数，等级是F"); break;
            //        case 5: Console.WriteLine($"{score}分数，等级是F"); break;
            //        case 6: Console.WriteLine($"{score}分数，等级是D"); break;
            //        case 7: Console.WriteLine($"{score}分数，等级是C"); break;
            //        case 8: Console.WriteLine($"{score}分数，等级是B"); break;
            //        case 9: Console.WriteLine($"{score}分数，等级是A"); break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("分数不在范围内");

            //}
            //Console.WriteLine("输入一个数字1~7之间");
            //int week = int.Parse(Console.ReadLine());
            //switch (week) 
            //{
            //    case 1: Console.WriteLine("星期一"); break;
            //    case 2: Console.WriteLine("星期二"); break;
            //    case 3: Console.WriteLine("星期三"); break;
            //    case 4: Console.WriteLine("星期四"); break;
            //    case 5: Console.WriteLine("星期五"); break;
            //    case 6: Console.WriteLine("星期六"); break;
            //    case 7: Console.WriteLine("星期七"); break;
            //    default: Console.WriteLine("错误"); break;
            //}
            //Console.WriteLine("王帅,请输入你的分数");
            //int score = int.Parse(Console.ReadLine());
            //if (score > 0 && score <= 100)
            //{
            //    string res = score switch

            //    {
            //        >= 90 => "A",
            //        >= 80 => "B",
            //        >= 70 => "C",
            //        >= 60 => "D",
            //        _ => "F"
            //    };
            //    Console.WriteLine($"我的分数是{score},等级是{res}");
            //}
            //else
            //{
            //    Console.WriteLine("分数无效");
            //}

            //Console.WriteLine("请输入你的账号");
            //string a=(Console.ReadLine());
            //Console.WriteLine("请输入你的密码");
            //string b =(Console.ReadLine());
            //if (a == "admin")
            //{
            //    if (b == "123456")
            //    {
            //        Console.WriteLine("登陆成功");
            //    }
            //    else
            //    {
            //        Console.WriteLine("密码错误");
            //    }
            //}
            //else {
            //    Console.WriteLine("账号错误");
            //      }

            //Console.WriteLine("请选择输入菜单（add/edit/del/)");
            //string n = Console.ReadLine();
            //switch (n)
            //{
            //    case "add": Console.WriteLine("新增成功"); break;
            //    case "edit": Console.WriteLine("编辑成功"); break;
            //    case "del": Console.WriteLine("删除成功"); break;
            //    default:
            //        Console.WriteLine("出错"); break;
            //}
            //            Console.WriteLine("请输入你的类型VIP/USER");
            //            string n = (Console.ReadLine());
            //            Console.WriteLine("请输入你的金额");
            //            double a = double.Parse(Console.ReadLine());
            //            if (n == "VIP")
            //            {
            //                if (a >= 1000)
            //                { Console.WriteLine($"消费{a * 0.9}元");
            //                }
            //                else { Console.WriteLine($"消费{a}元"); }
            //            }
            //            else if  (n== "USER")                                                         
            //{
            //                if (a >= 2000)
            //                { Console.WriteLine($"消费{a * 0.95}元");
            //                }
            //                else { Console.WriteLine($"消费{a}元");
            //                }
            //            }
            //Console.WriteLine("请输入月份1到12");
            //int a = int.Parse(Console.ReadLine());
            //switch (a)
            //{  case 1:
            //case 12:
            //case 2: Console.WriteLine("这是冬季"); break;
            //case 9:
            //case 10:
            //case 11: Console.WriteLine("这是秋季"); break;
            //case 6:
            //case 7:
            //case 8: Console.WriteLine("这是夏季"); break;
            //case 3:
            //case 4:
            //case 5: Console.WriteLine("这是春季"); break;
            //default: Console.WriteLine("错误"); break;
            //}
            //Console.WriteLine("请输入快递重量");
            //double a = double.Parse(Console.ReadLine());
            //if (a < 1)
            //{ Console.WriteLine("快递费10块"); }
            //else if (a >=1 && a <=5)
            //{ Console.WriteLine("快递费20块"); }
            //else 
            //     { Console.WriteLine("快递费50块"); }
            // Console.WriteLine("请输入会员等级3~5");
            //int a = int.Parse(Console.ReadLine());
            //switch (a)
            //{ 
            //    case 3: Console.WriteLine("购物打9折"); break;
            //    case 4: Console.WriteLine("每月可领优惠卷"); break;
            //    case 5: Console.WriteLine("终生免运费"); break;

            //    default: Console.WriteLine("错误,没有福利"); break;
            //}
            //Console.WriteLine("输入商品编号整数1到3");
            //int a = int.Parse(Console.ReadLine());
            //switch (a)
            //{
            //    case 1: Console.WriteLine("已购买可乐"); break;
            //    case 2: Console.WriteLine("已购买雪碧"); break;
            //    case 3: Console.WriteLine("已购买矿泉水"); break;

            //    default: Console.WriteLine("错误,没有此商品"); break;
            //}

            Console.WriteLine("请输入当前速度");
            double a = double.Parse(Console.ReadLine());
            if (a < 30)
            { Console.WriteLine("低速通过"); }
            else if (a >= 30 && a < 60)
            { Console.WriteLine("中速通过"); }
            else if (a >= 60 && a <100)
            { Console.WriteLine("高速通过"); }
            else if (a >= 100 && a <=120)
            { Console.WriteLine("超速通过"); }
            else 
                    { Console.WriteLine("无敌了"); }
        }
    }
}
