using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp13
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            InitFilterList();
        }
        private string[] strArr = { "1111", "2222", "3333", "4444", "555", "6666", "7777", "11122", "222333", "333444", "44455", "666777" };
        private void InitFilterList()
        {
            listBox1.Items.AddRange(strArr);
            textBox1.TextChanged += TextBox1_TextChanged;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = listBox1.SelectedItem.ToString();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string keyWords=(sender as TextBox).Text;
         
            List
                <string> resList = strArr.ToList().FindAll(item => item.Contains(keyWords));
            listBox1.Items.Clear();

          
            listBox1.Items.AddRange(resList.ToArray());
        

        }
}
}
