using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Library
{
    public partial class FormUpdateBook : Form
    {
        public FormUpdateBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断文本框中是否有内容
            if (txtID.Text == "" || txtName.Text == "" || txtAuthor.Text == "" || txtPubisher.Text == "" || txtPrice.Text == "" || txtNum.Text == "")
            {
                MessageBox.Show("有空项", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //修改图书信息
            Dao dao = new Dao();
            dao.connect();
            string sql = $"update T_Book set Bid = '{txtID.Text}',Bname = '{txtName.Text}',Author = '{txtAuthor.Text}',Publisher = '{txtPubisher.Text}',Price = '{txtPrice.Text}',Num = '{txtNum.Text}' where Bid ='{FormManage.Bid}'";
            if (dao.Execute(sql) > 0)
            {
                //修改成功
                dao.DaoClose();
                MessageBox.Show("修改成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                //修改失败
                dao.DaoClose();
                MessageBox.Show("修改失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    

        

        private void FormUpdateBook_Load(object sender, EventArgs e)
        {
            txtID.Text = FormManage.Bid;
            txtName.Text = FormManage.Bname;
            txtAuthor.Text = FormManage.Author;

            txtPubisher.Text = FormManage.Publisher;
            txtPrice.Text = FormManage.Price.ToString();
            txtNum.Text = FormManage.Num;
        }
    }
}
