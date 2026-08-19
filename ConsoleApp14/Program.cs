using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace BookManger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             不同类型的默认值 
                类型    默认值
                int      0
                bool     false
                引用类型  null  
             */
            //List<Dictionary<string, dynamic>> ls = new()
            //{
            //    new Dictionary<string, dynamic>()
            //    {
            //        ["a"] = 10,
            //        ["b"] = 20,
            //        ["c"] = 30,
            //    },
            //    new Dictionary<string, dynamic>()
            //    {
            //        ["a"] = 100,
            //        ["b"] = 200,
            //        ["c"] = 300,
            //    }
            //};
            //// dic 变量 接收的是 Find返回值 
            //// dic 中存储的只是 ls中某一个字典的引用            
            //var dic = ls.Find(item => item["c"] == 30);
            //dic["c"] = 33333;

            //foreach(var it in ls)
            //{
            //    foreach(var item in it) Console.WriteLine($"{item.Key} --- {item.Value}");
            //}
            //return;

            // 实例化图书对象
            BookManager BM = new BookManager("./book.json", new JsonSerializerOptions
            {
                WriteIndented = true, // 美化格式内容
                AllowTrailingCommas = true,
            });

            string num = "";
            while (num != "0")
            {
                // 提示信息
                Console.WriteLine("======欢迎来到图书管理系统======");
                Console.WriteLine("1: 新增图书");
                Console.WriteLine("2: 删除图书");
                Console.WriteLine("3: 编辑图书");
                Console.WriteLine("4: 查询所有图书");
                Console.WriteLine("5: 查询单个图书");
                Console.WriteLine("6：借书");
                Console.WriteLine("7:还书");
                Console.WriteLine("0: 退出");
                num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.WriteLine("----新增图书----");
                        Console.WriteLine("请输入书名");
                        string bookName = Console.ReadLine()??"".Trim();
                        if(string.IsNullOrEmpty(bookName))
                        {
                            Console.WriteLine("书名不能为空");
                            break;
                        }
                        Console.WriteLine("请输入作者");
                        string author = Console.ReadLine() ?? "".Trim();
                        if (string.IsNullOrEmpty(author))
                        {
                            Console.WriteLine("作者不能为空");
                            break;
                        }
                        Console.WriteLine("请输入标签");
                        string mark = Console.ReadLine() ?? "".Trim();
                        if (string.IsNullOrEmpty(mark))
                        {
                            Console.WriteLine("标签不能为空");
                            break;
                        }
                        Console.WriteLine("请输入价格");
                        string priceStr = Console.ReadLine() ?? "".Trim();
                        // @"^[1-9]+[0-9]*(\.[0-9]+)?$"
                        if (!Regex.IsMatch(priceStr, @"^[1-9]+[0-9]*(\.[0-9]+)?$"))
                        {
                             Console.WriteLine("输入的价格格式有误");
                            break;
                        }
                            // 组装 书籍 字典
                            Dictionary<string, dynamic> bookDic = new()
                            {
                                ["name"] = bookName,
                                ["author"] = author,
                                ["isBorrow"] = false,
                                ["id"] = new Random().NextDouble(),
                                ["mark"] = mark,
                                ["price"] = double.Parse(priceStr)
                            };
                            // 调用实例方法  实现 添加书籍
                            string res = BM.AddBook(bookDic);
                            Console.WriteLine(res);
                        break;

                    case "2":
                        Console.WriteLine("----删除图书----");
                        Console.WriteLine("----输入要删除的书名----");
                        // 根据输入的书名删除 
                        string removeBN = Console.ReadLine()?? "".Trim();
                        if(string.IsNullOrEmpty(removeBN))
                            {
                            Console.WriteLine("书名不能为空");
                            break;
                        }
                        string resStr = BM.RemoveBook(removeBN);
                        Console.WriteLine(resStr);
                        break;
                    case "3":
                        Console.WriteLine("----编辑图书----");
                        // 根据输入的书名 修改图书
                        Console.WriteLine("请输入书名");
                        string editBookName = Console.ReadLine() ?? "".Trim();
                        if (string.IsNullOrEmpty(editBookName))
                        {
                            Console.WriteLine("书名不能为空");
                            break;
                        }
                        Console.WriteLine("请输入作者");
                        string editAuthor = Console.ReadLine() ?? "".Trim();
                        if (string.IsNullOrEmpty(editAuthor))
                        {
                            Console.WriteLine("作者不能为空");
                            break;
                        }
                        Console.WriteLine("请输入标签");
                        string editMark = Console.ReadLine() ?? "".Trim();
                        if (string.IsNullOrEmpty(editMark))
                        {
                            Console.WriteLine("标签不能为空");
                            break;
                        }
                        Console.WriteLine("请输入价格");
                        string editPriceStr = Console.ReadLine() ?? "".Trim();
                        if (!Regex.IsMatch(editPriceStr, @"^[1-9]+[0-9]*(\.[0-9]+)?$"))
                        {
                            Console.WriteLine("价格格式错误");
                            break;
                        }
                        double editPrice = double.Parse(Console.ReadLine());
                        // 组装 书籍 字典 ===》 用于后续调用方法传参
                        Dictionary<string, dynamic> editBook = new()
                        {
                            ["name"] = editBookName,
                            ["author"] = editAuthor,
                            ["mark"] = editMark,
                            ["price"] = editPrice
                        };
                        string resEditStr = BM.EditBook(editBook);
                        Console.WriteLine(resEditStr);
                        break;
                    case "4":
                        Console.WriteLine("----查询所有图书----");
                        var resList = BM.SearchBook();
                        // 结果list长度是够为0
                        if (resList.Count == 0)
                        {
                            Console.WriteLine("没有书籍，请先添加");
                        }
                        else
                        {
                            foreach (var item in resList)
                            {
                                Console.WriteLine($"书名：{item["name"]} - 作者：{item["author"]} - 标签：{item["mark"]} - 价格：{item["price"]}是否借出：{item["isBorrow"]}");
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("----查询单个图书----");
                        Console.WriteLine("请输入查询的书名");
                        string searchBookName = Console.ReadLine() ?? "".Trim();
                        if (string.IsNullOrEmpty(searchBookName))
                        {
                            Console.WriteLine("书名不能为空");
                            break;
                        }
                        var resBook = BM.SearchBook(searchBookName);
                        if (resBook.Count == 0) Console.WriteLine("没找到对应的数据，请先添加");
                        else Console.WriteLine($"书名：{resBook["name"]} - 作者：{resBook["author"]} - 标签：{resBook["mark"]} - 价格：{resBook["price"]}");
                        break;
                    case "6":
                        Console.WriteLine("-------借书-------");
                        Console.WriteLine("输入要借的书");
                        string borrowName = Console.ReadLine() ?? "".Trim();
                        if (string.IsNullOrEmpty(borrowName))
                        {
                            Console.WriteLine("书名不能为空");
                            break;
                           
                        }

                        string borrowRes = BM.BorrowBook(borrowName);
                        Console.WriteLine(borrowRes);
                        break;

                        

                            













                    case "0":
                        Console.WriteLine("--**退出**--");
                        break;
                    default:
                        Console.WriteLine("****输入有误****");
                        break;
                }

            }
        }
    }
}                                                                                                                                                                           
/*
后续同学自行完善 方向
    1. 对所有输入的数据进行校验
        - 可以先取出首尾两端的空白
        - 不为空，长度要求校验
        - 正则校验
     
    3. 完善一个还书功能  
*/
