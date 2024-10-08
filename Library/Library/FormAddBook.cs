using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Library
{
    public partial class FormAddBook : Form
    {
        public FormAddBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {//添加图书
            Dao dao = new Dao();
            dao.connect();
            string sql = $"insert into T_Book values('{int.Parse(txtID.Text)}','{txtName.Text}','{txtAuthor.Text}'," +
                $"'{txtPublisher.Text}','{float.Parse(txtPrice.Text)}','{int.Parse(txtNum.Text)}')";
            try
            {
                if (dao.Execute(sql) > 0)
                {
                    dao.DaoClose();
                    MessageBox.Show("添加成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    dao.DaoClose();
                    MessageBox.Show("添加失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                dao.DaoClose();
                MessageBox.Show("ERROR", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
            

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
