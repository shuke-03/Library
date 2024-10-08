using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void 图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {//窗体加载的事件，显示信息
            this.label1.Text = $"管理员;{Form1.name} {Form1.id}";

        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认退出吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))

            {
                //退出
                this.Close();
            }
        }

        private void 添加图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddBook form = new FormAddBook();
            form.ShowDialog();
        }

        private void 修改图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManage form = new FormManage();
            form.ShowDialog();
        }

        private void 下架图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManage form = new FormManage();
            form.ShowDialog();
        }

        private void 搜索图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManage form = new FormManage();
            form.ShowDialog();
        }
    }
}
