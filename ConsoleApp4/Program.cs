using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int i = 1;
            //    int sum = 0;
            //    while (i<6)//括号放条件
            //    {
            //        sum=sum+i;
            //        i++;

            //    }
            //    Console.WriteLine($"总和sum：{sum}");


            //int i = 1;

            //while (i < 50)
            //{  if (i % 3 == 0&&i%5==0) Console.WriteLine(i);

            //    i++;
            //}

            //    int i = 1;

            //    int ji = 1;
            //    while (i < 6)
            //    {   ji = i * ji;
            //    i++;
            //}
            //    Console.WriteLine(ji);

            //int i = 1;
            //while (i <= 100)
            //{
            //    if(i % 7 == 0)
            //        Console.WriteLine(i);
            //        i++;
            //int i = 100;
            //while (i < 1000)
            //{
            //    int ge = i % 10;
            //    int shi = (i / 10) % 10;
            //    int bai = i / 100;
            //    if ((int)Math.Pow(ge, 3) + (int)Math.Pow(shi, 3) + (int)Math.Pow(bai, 3) == i)


            //    {
            //        Console.WriteLine(i);

            //    }i++;
            //
            //do{循环代码}  while（条件）;
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i <= 5);
            // for (  1 ; 2  ;   4 ) { 3}
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("我爱你");

            //    Console.WriteLine($"循环结束 i:{i}");
            //}

            //int i = 1;
            //for (; i <= 5; )
            //{
            //    Console.WriteLine("我爱你");
            //    i++;
            //}
            //Console.WriteLine($"循环结束 i:{i}");
            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 2; i<=10; i+=2)//+=2就是循环加2            {
            //    Console.WriteLine(i);
            //}

            //double money = 10;
            //int year = 1;
            //while(year<=50)
            //{
            //    money = money + money * 0.05;
            //    year++;
            //}
            //Console.WriteLine($"钱50年后{money}");
            //            List<string> strList = new()
            //{
            //    "aa",
            //    "bb",
            //    "ccc",
            //    "dd",
            //    "eee"
            //};
            //            for (int i = 0; i < 5; i++)
            //            {
            //                Console.WriteLine(strList[i]);
            //            }


            //    List<int> intList = new()
            //{
            //    3,5,7,2,9 };
            //    int sum = 0;
            //    for (int i = 0; i < intList.Count; i++)
            //    { sum += intList[i]; }
            //    Console.WriteLine(sum);


            //for (var i = 1; i <= 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);//跳过本次循环
            //}

            //for (var i = 1; i <= 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        break;//结束整个循环
            //    }
            //    Console.WriteLine(i);
            //}

            //int m = 9;
            //string s = "黑色";
            //    for (int i = 1; i <= m; i++) {

            //    if (i == 1 || i == m)
            //        if (m % i == 0)
            //        {
            //            s = "白色";
            //        }

            //}
            //    if(s=="黑色")
            //{
            //    Console.WriteLine($"{m}是素数");
            //}


            //int[] intArr = { 10, 20, 30 };
            //int sum = 0;
            //foreach (int item in intArr)
            //{
            //    sum += item;
            //}
            //Console.WriteLine(sum);

            //Dictionary<String, dynamic> userInfo = new Dictionary<string, dynamic>
            //{   ["name"] = "Tom",
            //    ["age"] = 5,
            //    };
            //foreach (var item in userInfo)
            //{
            //    Console.WriteLine(item);
            ////}
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"第{i}人");
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.WriteLine($"跑{j}圈");
            //    }
            //}

            //write输出不换行

            //int sum = 0;
            //int i = 2;

            //while (i <= 100) 
            //        { sum = sum + i;
            //          i += 2;
            //}
            //     Console.WriteLine(sum);

            //int i = 0;
            //  for (int year = 1000; year <= 2000; year++)
            //  {
            //      bool run = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            //      if (run)
            //      { Console.Write(year + "\t");

            //          i++;
            //          if (i % 4 == 0) {
            //              Console.WriteLine();
            //          }
            //      }
            //  }


            //for (int i = 9; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    { Console.Write("*"); }


            //    Console.WriteLine();
            //}


            //double sum = 0;
            //double sign = 1;
            //for(int i = 1;i<=100; i++)
            //{
            //    sum+=sign*(1.0/i);
            //    sign = -sign;

            //}
            //Console.WriteLine(sum);

            //int sum = 0;
            //int a = 1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    a = a * i;
            //    sum += a;
            //}

            //    Console.WriteLine(sum);

            //double h = 5;
            //int count = 0;

            //while (h > 0.1)
            //{
            //    h = h * 0.3;
            //    count++;
            //}
            //Console.WriteLine(count);





            //double weight = 0.000001;
            //double n = 1;
            //double kg = 0;
            //for(int i=1;i<=64;i++)
            //        {
            //    kg += n*weight;
            //    n = n * 2;

            //}

            //Console.WriteLine(kg);







            //double money = 50000;
            // int count = 0;
            // while(money>5000)
            // {
            //     money = money * 0.95;
            //         count++;

            // }

            // Console.WriteLine(money);
            // Console.WriteLine(count);

            //猴子摘桃
            //int n = 1;
            //for (int i = 6; i >= 1; i--)
            //{
            //    n = (n + 1) * 2;
            //}
            //    Console.WriteLine(n);


            //double h = 10;
            //double dist = 10;
            //for(int i = 1; i <10;i++)
            //{

            //    h =  h / 2;
            //    dist += h * 2;
            //}

           
            //Console.WriteLine(dist);


            
        }

    }
}
