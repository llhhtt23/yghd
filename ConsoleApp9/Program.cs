
using System.Threading.Channels;

namespace ConsoleApp9
{
    internal class Program
    {
        delegate void myDelegate(string msg);
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
            //int count (string n, char m)
            //{
            //    int count = 0;
            //    foreach (char c in n)
            //    {
            //        if (c == m)
            //            count++;
            //    }
            //    return count;
            //}
            //Console.WriteLine(count("aassddffffffgh", 'f'));


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


            //bool m (string str)
            //{
            //    int l = 0;
            //    int r = str.Length - 1;

            //    while (l < r)
            //    {
            //        if (str[l] == str[r])
            //        {
            //            l++;
            //            r--;
            //        }


            //        else return false;
            //    }
            //    return true;
            //}
            //Console.WriteLine("请输入你的爱字符串");
            //    string str = Console.ReadLine();
            //if (m(str)) Console.WriteLine("是回文");
            //else Console.WriteLine("不是回文");



            //            List<Dictionary<string, dynamic>> list = new() {
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "zs",
            //        ["age"] = 29,
            //        ["isMan"] = true,
            //        ["isSingle"] = true,
            //        ["salary"] = 4200
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "ls",
            //        ["age"] = 20,
            //        ["isMan"] = false,
            //        ["isSingle"] = true,
            //        ["salary"] = 3400
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "ww",
            //        ["age"] = 19,
            //        ["isMan"] = true,
            //        ["isSingle"] = false,
            //        ["salary"] = 6000
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "zl",
            //        ["age"] = 14,
            //        ["isMan"] = false,
            //        ["isSingle"] = true,
            //        ["salary"] = 2000
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "sq",
            //        ["age"] = 35,
            //        ["isMan"] = true,
            //        ["isSingle"] = false,
            //        ["salary"] = 7000
            //    },
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "zb",
            //        ["age"] = 27,
            //        ["isMan"] = false,
            //        ["isSingle"] = true,
            //        ["salary"] = 2900
            //    },
            //};



            // IndexOf

            // LastIndexOf 
            // Find: 要求查找第一个年龄小于20的

            //var one = list.Find(item =>
            //{
            //    return item["age"] < 20;

            //});

            //Console.WriteLine($"name:{ one["name"]}");

            //FindAll: 要求查找每一个年龄小于20的
            //var all = list.FindAll(item => item["age"] < 20);

            //    foreach (var p in all)
            //    {
            //        Console.WriteLine(p ["name"]);
            //    }
            // FindLast: 要求查找年龄大于25的
            //    var one = list.FindLast(item =>
            //        {
            //            return item["age"] > 25;


            //        });

            //    Console.WriteLine($"name:{one["name"]}");


            // FindAll: 找出性别男的

            //var xingbie = list.FindAll(item => item["isMan"] == true);


            //    foreach (var m in xingbie)
            //    {

            //        Console.WriteLine(m["name"]);
            //    }



            // FindIndex: 找出薪水大于5000



            //var idx = list.FindIndex(item =>
            //{
            //    return item["salary"] > 5000;

            //});

            //Console.WriteLine($"name:{list[idx] ["name"]}");


            //FindLastIndex: 找出薪水小于3000

            //var idx = list.FindLastIndex(item =>
            //{
            //    return item["salary"] < 3000;

            //});

            //Console.WriteLine($"name:{list[idx]["name"]}");



            // Exists: 判断是否有薪水大于5000

            //var have =list.Exists(item =>
            //{
            //    return item["salary"] >5000;

            //});
            //if (have)

            //{
            //    Console.WriteLine($"有");
            //}
            //else
            //{
            //    Console.WriteLine($"没有");
            //}

            //ForEach: 输出每个的 名字-年龄 - 薪水

            //list.ForEach(item => Console.WriteLine($"名字:{item["name"]} 年龄:{item["age"]} 薪水:{item["salary"]}"));

            // ConvertAll: 映射得到一个所以薪水的list

            //var salaryList = list.ConvertAll(item =>
            //item["salary"]);
            //foreach (var s in salaryList)
            //{

            //    Console.WriteLine(s);

            //}
            //TrueForAll: 判断是否都成年

            //var have = list.TrueForAll(item =>
            //{
            //    return item["age"] >=18;

            //});
            //if (have)

            //{
            //    Console.WriteLine($"是成年");
            //}
            //else
            //{
            //    Console.WriteLine($"没有成年");
            //}


            //封装一个函数 接收一个字符串; 返回一个字典,键是字符串的每个字符,键值是这个字符在字符串中出现的次数

            void count(string str, Dictionary<char, int> charCount)

            {
                foreach (char s in str)
                {
                    if (charCount.ContainsKey(s))
                    {
                        charCount[s]++;
                    }
                    else
                    {
                        charCount.Add(s, 1);

                    }
                }
            }

            Dictionary<char, int> charCount = new Dictionary<char, int>();
            Console.WriteLine("输入啊字符串");

            string str = Console.ReadLine();
            count(str, charCount);
            foreach (var item in charCount)


                Console.WriteLine(item);



        }
        
    }
}
