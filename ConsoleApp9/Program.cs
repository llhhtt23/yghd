
using System.Threading.Channels;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //用函数封装一个猜数字的小游戏，函数中生成一个随机整数（0 - 100）作为目标数字，不停的让用户输入数字，距离目标数字偏大，就提示用户偏大，距离目标数字偏小就输出偏小，用户有5次输入的机会，5次没有猜对，输出GAME OVER，猜对了就输出WIN！

            //var guessNum = (int n) =>
            //{
            //    var random = new Random();
            //    var x = random.Next(100);
            //    int count = 1;
            //    while (true)
            //    {
            //        if (n == x)
            //        {
            //            Console.WriteLine("Win");
            //            break;
            //        }

            //        else if (n > x) Console.WriteLine("偏大");
            //        else Console.WriteLine("偏小");
            //        Console.WriteLine("请输入你猜的数字");
            //        n = int.Parse(Console.ReadLine());
            //        count++;
            //        if (count == 5)
            //        {
            //            Console.WriteLine("game,over");
            //            break;
            //        }
            //    }

            //};
            //Console.WriteLine("请输入你猜的数字");
            //int m =int.Parse(Console.ReadLine());
            //guessNum(m);

            //double price(double r)
            // {
            //     double area = Math.PI * r * r;
            //     double halfarea = area / 2;
            //     double price = halfarea * 200 ;
            //         return price;
            // }

            // Console.WriteLine("请输入半径");
            // double r =double.Parse(Console.ReadLine());
            // Console.WriteLine($"半径{r}装修一半要{price(r)}");


            //计算字符在字符串中出现的次数：参数1字符串，参数2某个字符，函数统计次数，并返回。
            //int count (string n,char m)
            //            {
            //                int count = 0;
            //                foreach (char c in n)
            //                {
            //                    if (c == m)
            //                        count++;
            //                }
            //                return count;
            //            }
            //            Console.WriteLine("输入字符串");
            //            string n = Console.ReadLine();
            //            Console.WriteLine("输入字符");
            //            char m =char.Parse(Console.ReadLine());
            //            Console.WriteLine($"输入{count(n,m)}次");
            //计算一个整型数组中，最小值第一次出现的下标。

            //int[] arr = [10, 20, 5, 30, 50, 6, 7, 55, 555, 55555];

            //int b (int[]arr)
            //{
            //    int min = 1000000;
            //    int yes = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i]< min)
            //        {
            //            min = arr[i];
            //            yes = i;
            //        }
                        
            //    }
            //        return yes;
            //}
            //Console.WriteLine($"下标{b(arr)}");


            bool m (string str)
            {
                int l = 0;
                int r = str.Length - 1;

                while (l < r)
                {
                    if (str[l] == str[r])
                    {
                        l++;
                        r--;
                    }


                    else return false;
                }
                return true;
            }
            Console.WriteLine("请输入你的爱字符串");
                string str = Console.ReadLine();
            if (m(str)) Console.WriteLine("是回文");
            else Console.WriteLine("不是回文");
            











        }
    }
}
