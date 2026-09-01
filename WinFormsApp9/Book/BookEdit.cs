using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9.Book
{
    public partial class BookEdit : Form
    {
        public BookEdit()
        {
            InitializeComponent();

        }
        public BookEdit(string id)
        {
            InitializeComponent();
            MessageBox.Show(id);
            label1.Text = id;

        }

        private void BookEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
