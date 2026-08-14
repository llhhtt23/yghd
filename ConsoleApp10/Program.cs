namespace ConsoleApp10

{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Action yes = () =>
            //{
            //    var path = @"./content.log";
            //    var date = DateTime.Now;



            //    File.WriteAllText(path, "yes" + date);

            //};yes();

            //Action no = () =>
            //{
            //    var path = @"./niuma.log";
            //    var date = DateTime.Now;
            //    File.WriteAllText(path, "no" + date);

            //};no();

            //            Action yes = () =>
            //            {
            //                var path = @"./nima.log";
            //                var date = DateTime.Now;
            //}; yes();                                                                                                                                                                                                                                  // 定义一个函数, 一个参数(接收路径), 返回值0 表示啥也不是,1是文件,2是文件夹
            //Func<string, int> isFileOrDir = path =>
            //{
            //    // 说明path是文件
            //    if (File.Exists(path)) return 1;
            //    // 说明path是目录  
            //    if (Directory.Exists(path)) return 2;
            //    return 0;
            //};
            //string[] resArr = ["啥也不是", "是文件", "是文件夹"];
            //int res = isFileOrDir("./");
            ////int res = isFileOrDir("./abc");
            ////int res = isFileOrDir("./content.log");
            ////string path1 = @"D:\demo\day10\day10\bin\Debug\net8.0";
            ////string path1 = @"D:\demo\day10\day10\bin\Debug\net8.0\abcder";
            ////int res = isFileOrDir(path1);
            //Console.WriteLine(resArr[res]);

            //       作业: 使用读写文件配合命令行窗口 模拟实现注册功能

            //要求输入用户名和密码,完成注册; (注册的用户信息记录在user.txt文件中, 一行一个用户信息 数据之间通过 === 分隔)

           

            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string salt = Console.ReadLine();
           
            File.AppendAllText("./user.txt", $"{name}==={salt}\n");


























        }
    }
}
