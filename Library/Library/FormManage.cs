using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormManage : Form
    {
        public FormManage()
        {
            InitializeComponent();
        }
        public static string Bid;
        public static string Bname;
        public static string Author;
        public static string Publisher;
        public static float Price;
        public static string Num;




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadBooks()//加载
        {
            dgv.Rows.Clear();
            Dao dao = new Dao();
            dao.connect();
            string sql = "select * from T_Book";
            SqlDataReader reader = dao.read(sql);
            while(reader .Read ())
            {
                dgv.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString());

            }
            reader.Close();
            dao.DaoClose();
        }
        private void FormManage_Load(object sender, EventArgs e)
        {
            LoadBooks();
            //在窗体加载的同时将数据库中的图书信息显示到网格控件中
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text.Trim();

            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from T_Book where Bname like '%{key}%' or Author like '%{key}%' or Publisher like '%{key}%' or Price like '%{key}%'";
            SqlDataReader reader = dao.read(sql);

            dgv.Rows.Clear();

            while (reader.Read())
            {
                dgv.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                    reader[3].ToString(), reader[4].ToString(), reader[5].ToString());

            }
            reader.Close();
            dao.DaoClose();
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            dao.connect();
            string sql = $"delete T_Book where Bid = '{int.Parse(lb1ID.Text)}'";
            if(dao.Execute(sql)>0)
            {

                lb1ID.Text = "NULL";
                LoadBooks();
                dao.DaoClose();
                MessageBox.Show("下架成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                dao.DaoClose();
                MessageBox.Show("删除失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("选中无效数据", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string id = dgv.CurrentRow.Cells[0].Value.ToString();
            lb1ID.Text = id;

            Bid = dgv.CurrentRow.Cells[0].Value.ToString();
            Bname = dgv.CurrentRow.Cells[1].Value.ToString();
            Author = dgv.CurrentRow.Cells[2].Value.ToString();
            Publisher = dgv.CurrentRow.Cells[3].Value.ToString();
            Price = float.Parse(dgv.CurrentRow.Cells[4].Value.ToString());
            Num = dgv.CurrentRow.Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUpdateBook form = new FormUpdateBook();
            form.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormUpdateBook form = new FormUpdateBook();
            form.ShowDialog();
        }
    }
}
