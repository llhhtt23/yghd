using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9.Book
{
    public partial class BookAdd : Form
    {
        public BookAdd()
        {
            InitializeComponent();
            ucBook1.SendData += AddBook;
        }
        private void AddBook(Bookinfo book)
        {   
            List<Bookinfo>books  =new List<Bookinfo>();
            string JsonStr = "";
            if (File.Exists("./book.json"))
            {
                JsonStr=File.ReadAllText("./book.json");
                books=JsonSerializer.Deserialize<List<Bookinfo>>(JsonStr);
            }
            books.Add(book);
            JsonStr = JsonSerializer.Serialize(books, new JsonSerializerOptions()
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
                Encoder=System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText("./book.json", JsonStr);
            MessageBox.Show("新增成功");
           this.Close();    
        }
    }
}