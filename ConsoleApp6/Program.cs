namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //            List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1001},
            //        {"singerName", "周杰伦"},
            //        {"genre", "流行"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1002},
            //        {"singerName", "林俊杰"},
            //        {"genre", "华语流行"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1003},
            //        {"singerName", "邓紫棋"},
            //        {"genre", "流行、摇滚"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1004},
            //        {"singerName", "薛之谦"},
            //        {"genre", "抒情流行"}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"singerId", 1005},
            //        {"singerName", "毛不易"},
            //        {"genre", "民谣流行"}
            //    }
            //};

            //            List<Dictionary<string, dynamic>> songList = new List<Dictionary<string, dynamic>>
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 10001},
            //        {"singerId", 1001},
            //        {"songName", "青花瓷"},
            //        {"duration", 239}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 10002},
            //        {"singerId", 1001},
            //        {"songName", "发如雪"},
            //        {"duration", 253}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 10003},
            //        {"singerId", 1001},
            //        {"songName", "东风破"},
            //        {"duration", 215}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 1004},
            //        {"singerId", 3002},
            //        {"songName", "不为谁而作的歌"},
            //        {"duration", 296}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"songId", 1005},
            //        {"singerId", 1002},
            //        {"songName", "背对背拥抱"},
            //        {"duration", 262}
            //    }
            //};
            //            Console.WriteLine("请输入歌手姓名：");
            //            string singer = Console.ReadLine();
            //            int singerId = 0;
            //            foreach (Dictionary<string, dynamic> item in singerList)
            //            {
            //                if (item["singerName"] == singer) singerId = item["singerId"];
            //            }
            //            var singerSongs = new List<Dictionary<string,dynamic>>();

            //            foreach (Dictionary<string,dynamic> item in songList)
            //            {
            //                if (item["singerId"] == singerId)
            //                    singerSongs.Add(item);

            //            }

            //            foreach (dynamic item in singerSongs)
            //            {
            //                Console.WriteLine(item["songName"]);
            //            }


            //    通过歌曲查找歌手
            //Console.WriteLine("输入歌曲名称：");
            //string song = Console.ReadLine();



            //            Console.WriteLine("输入歌曲名称：");
            //    string song = Console.ReadLine();
            //            int singerId = 0;
            //            foreach (Dictionary<string,dynamic>item in songList)
            //            {
            //                if (item["songName"] == song)
            //                {
            //                    singerId = item["singerId"];break;

            //                }
            //            }

            //if (singerId == 0) {Console.WriteLine("没有找到该歌曲");return;}

            //foreach(Dictionary<string,dynamic>item in singerList)
            //            {
            //                if (item["singerId"] == singerId)
            //                 {
            //                    Console.WriteLine($"歌手:{item["singerName"]}");
            //                }
            //            }


            List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
{
    new Dictionary<string, dynamic>
    {
        {"name", "机械键盘"},
        {"price", 299.99},
        {"code", "G001"},
        {"stock", 120}
    },
    new Dictionary<string, dynamic>
    {
        {"name", "无线鼠标"},
        {"price", 89.50},
        {"code", "G002"},
        {"stock", 356}
    },
    new Dictionary<string, dynamic>
    {
        {"name", "27寸显示器"},
        {"price", 1299.00},
        {"code", "G003"},
        {"stock", 48}
    },
    new Dictionary<string, dynamic>
    {
        {"name", "电竞耳机"},
        {"price", 199.00},
        {"code", "G004"},
        {"stock", 85}
    },
    new Dictionary<string, dynamic>
    {
        {"name", "电脑支架"},
        {"price", 69.90},
        {"code", "G005"},
        {"stock", 210}
    }
};
            Console.WriteLine("请输入排序字段 price / stock:");
            string field = Console.ReadLine();
            Console.WriteLine("请输入排序方式 ASC升序 DSC降序：");
            string order = Console.ReadLine();
            for (int i = 0; i < goodsList.Count - 1; i++) 
            {
                for (int j = 0; j < goodsList.Count - 1 -i; j++)
                {
                    dynamic a = goodsList[j][field];
                    dynamic b = goodsList[j + 1][field];
                    bool needswap = false;
                    if (order == "ASC")
                    {
                        needswap = a > b;

                    }
                    else if (order == "DSC")
                    {
                        needswap = a < b;
                    }
                    if (needswap)
                    {
                        var temp = goodsList[j];
                        goodsList[j] = goodsList[j + 1];
                        goodsList[j + 1] = temp;
                    }
                }

            }

            foreach (var item in goodsList) {

                Console.WriteLine($"名称：{item["name"]}价格:{item["price"]} 库存:{item["stock"]}");

}

































        }
    }
}
