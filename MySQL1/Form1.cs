using MySqlConnector;
using System.Data;

namespace MySQL1
{


    public partial class Form1 : Form
    {
        //server=服务器地址
        private string ConnStr = "server=127.0.0.1;port=3306;database=text;uid=root;password=root;charset=utf8";
        public Form1()
        {
            InitializeComponent();


            using (MySqlConnection Coon = new MySqlConnection(ConnStr))
            {
                Coon.Open();

                string Sql = "select * from user";
                using (MySqlCommand Comm = new MySqlCommand(Sql, Coon))
                {
                    //Adapter适配器
                    MySqlDataAdapter Ada = new MySqlDataAdapter(Comm);
                    DataTable dt = new DataTable();
                    //倒进
                    Ada.Fill(dt);

                    dataGridView1.DataSource = dt;
                }


            }
        }


        //点击查询

        private void button1_Click(object sender, EventArgs e)
        {

            string str = textBox1.Text;
            using (MySqlConnection Coon = new MySqlConnection(ConnStr))
            {
                Coon.Open();

                string Sql = "select * from user where username=@username";
                using (MySqlCommand Comm = new MySqlCommand(Sql, Coon))
                {
                    //Parameters参数 填充
                    Comm.Parameters.AddWithValue("@username", str);
                    MySqlDataAdapter Ada = new MySqlDataAdapter(Comm);
                    DataTable dt = new DataTable();
                    Ada.Fill(dt);
                    dataGridView1.DataSource = dt;
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Coon = new MySqlConnection(ConnStr))
            {
                Coon.Open();


                //string Sql = "delete from user where username=@username";
                //string Sql = "update  user set gender=@gender,age=@age where id=@id";
                string Sql = "insert into user(username,age,gender,banji,password)value(@username,@age,@gender,@banji,@password)";
                using (MySqlCommand Comm = new MySqlCommand(Sql, Coon))
                {
                    //增删改没有表格不需要适配器，只有查数据搬运需要适配器
                    //Parameters参数 
                    //Comm.Parameters.AddWithValue("@username", str);
                    //    MySqlDataAdapter Ada = new MySqlDataAdapter(Comm);
                    //    DataTable dt = new DataTable();
                    //    Ada.Fill(dt);
                    //    dataGridView1.DataSource = dt;
                    //}
                    //Comm.Parameters.AddWithValue("@username", "王帅");
                    //Comm.Parameters.AddWithValue("@id",2);
                    //Comm.Parameters.AddWithValue("gender", "女");
                    //Comm.Parameters.AddWithValue("age", 112);
                    Comm.Parameters.AddWithValue("@username", "王帅");
                    Comm.Parameters.AddWithValue("@age", 112);
                    Comm.Parameters.AddWithValue("@gender", "女");
                    Comm.Parameters.AddWithValue("@banji", "02班");
                    Comm.Parameters.AddWithValue("@password", "123456");

                    // ExecuteNonQuery执行没有查询
                    int row =Comm.ExecuteNonQuery();
                    if(row> 0)
                    {
                        MessageBox.Show("成功");
                    }
                    else
                    {
                        MessageBox.Show("失败");
                    }
                }
            }
        }
    }
}


