using System.ComponentModel.Design;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            //数字转汉字
            //            int money = 1500245;
            //            string str = money.ToString();
            //            string[] arr = ["零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"];
            //            string[] units = ["", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿"];
            //            string result = "";
            //            for (int i = str.Length - 1; i >= 0; i--)
            //            {
            //                int idx = int.Parse(str[i].ToString());
            //                int index = str.Length - 1 - i;
            //                string unit = units[index];
            //                if (idx != 0)
            //                {
            //                    result = arr[idx] + unit +result;
            //                }
            //                else
            //                {
            //                    if (str.Length - 5 == i) 
            //                    { 
            //                    result = arr[idx] + units[4] + result;
            //            }
            //            else
            //            {
            //                result = arr[idx] + result;
            //            }
            //        }
            //    }

            //    result = Regex.Replace(result, @"零+萬", "萬");

            //     result = Regex.Replace(result, @"零+", "零");   
            //    if (result.EndsWith("零"))
            //{
            //    // 将零截取掉
            //    result = result.Substring(0, result.Length - 1);
            //}

            //Console.WriteLine(result);

            //            //数据加密


            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "3-7-16-38-49-17-63-70";
            //string result = "";
            //string[] nums = salt.Split("-");
            ////foreach (string s in nums)
            ////{
            ////    Console.WriteLine(s);
            ////}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int index = int.Parse(nums[i]);
            //    result += text[index];
            //}
            //Console.WriteLine(result);

            // string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";

            //string salt = "午夜渡口交换情报";
            //List<int> nums = [];
            //for (int i = 0; i < salt.Length; i++)
            //{
            //    int index = text.IndexOf(salt[i]);
            //    nums.Add(index);
            //}
            //string result = string.Join("-", nums);
            //Console.WriteLine(result);

            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "午夜渡口交换情报";
            //List<int> nums = []; 

            //for (int i = 0; i < salt.Length; i++)
            //{

            //    int index = text.IndexOf(salt[i]) - 1;
            //    nums.Add(index);
            //}
            //string result = string.Join("-", nums);

            //Console.WriteLine(result); // "6-15-29-37-48-51-62-69"

            //string res = ""; 

            //string[] nums1 = result.Split("-");

            //for (int i = 0; i < nums1.Length; i++)
            //{

            //    int index = int.Parse(nums1[i]) + 1;
            //    res += text[index];
            //}
            //Console.WriteLine(res); // 午夜渡口交换情报

            string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            string salt = "午夜渡口交换情报";
            List<int> nums = [];
            for (int i = 0; i < salt.Length; i++)
            {
                int index = text.IndexOf(salt[i]);
                index += index %2== 0 ? 1 : -1;
                nums.Add(index);
            }
            string result = string.Join("-", nums);
            Console.WriteLine(result);

            string res = "";
            string[] num1 = result.Split("-");
            for (int i = 0; i < num1.Length; i++)
            {
                int index = int.Parse(num1[i]);
                index += index % 2 == 0 ? 1 : -1;
                res += text[index];
            }

            Console.WriteLine(res);
































        }
    }
}
