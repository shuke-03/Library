using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static int id;
        public static string name;

        //管理员登录的方法
        private void AdminLogin()
        {
            //获取账号密码
            //用户输入的
            int id = int.Parse(txtId.Text);
            string pwd = txtPassword.Text;
            //从
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from T_Admin where AdminID='{id}'and Pwd='{pwd}'";
            SqlDataReader reader = dao.read(sql);
            if(reader .Read() == true)//表里有该用户的信息
            {
                Form1.id = id;
                sql = $"select [Name] from T_Admin where AdminID ='{id}'";
                reader = dao.read(sql);
                reader.Read();
                Form1.name = reader[0].ToString();

                txtId.Text = "";
                txtPassword.Text = "";

                reader.Close();
                dao.DaoClose();
                //登录成功
                FormAdmin form = new FormAdmin();
                form.ShowDialog();
            }
            else
            {
                //登录失败
                MessageBox.Show("账号或密码错误", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

        }

        //用户登录
        private void UserLogin()
        {
            //获取账号密码
            //用户输入的
            int id = int.Parse(txtId.Text);
            string pwd = txtPassword.Text;
            //从
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from T_User where Uid='{id}'and Pwd='{pwd}'";
            SqlDataReader reader = dao.read(sql);
            if (reader.Read() == true)//表里有该用户的信息
            {
                Form1.id = id;
                sql = $"select Uname from T_User where [Uid] ='{id}'";
                reader = dao.read(sql);
                reader.Read();
                Form1.name = reader[0].ToString();

                txtId.Text = "";
                txtPassword.Text = "";

                reader.Close();
                dao.DaoClose();
                //登录成功
                FormUser form = new FormUser();
                form.ShowDialog();
            }
            else
            {
                //登录失败
                MessageBox.Show("账号或密码错误", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }


        }

  

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //判断文本框是否有内容
            if(txtId.Text==""||txtPassword.Text=="")
            {
                MessageBox.Show("有空项？", "消息",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                return;
            }
            //判断登录的对象
            if(rbtnAdmin .Checked ==true)//管理员登录
            {
                AdminLogin();
            }
            if (rbtnUser.Checked == true)//用户登录
            {
                UserLogin();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认退出吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))

            {
                //退出
                this.Close();
            }
        }
    }
}
