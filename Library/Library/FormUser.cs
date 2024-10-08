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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void 租借ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认退出吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))

            {
                //退出
                this.Close();
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            this.label1.Text = $"用户;{Form1.name} {Form1.id}";
        }
    }
}
