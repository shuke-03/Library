namespace Library
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.租书情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看租书情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.下架图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.租书情况ToolStripMenuItem,
            this.图书ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1363, 50);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 租书情况ToolStripMenuItem
            // 
            this.租书情况ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看租书情况ToolStripMenuItem});
            this.租书情况ToolStripMenuItem.Name = "租书情况ToolStripMenuItem";
            this.租书情况ToolStripMenuItem.Size = new System.Drawing.Size(143, 40);
            this.租书情况ToolStripMenuItem.Text = "租书情况";
            // 
            // 查看租书情况ToolStripMenuItem
            // 
            this.查看租书情况ToolStripMenuItem.Name = "查看租书情况ToolStripMenuItem";
            this.查看租书情况ToolStripMenuItem.Size = new System.Drawing.Size(288, 44);
            this.查看租书情况ToolStripMenuItem.Text = "查看租书情况";
            // 
            // 图书ToolStripMenuItem
            // 
            this.图书ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加图书ToolStripMenuItem,
            this.修改图书ToolStripMenuItem,
            this.下架图书ToolStripMenuItem,
            this.搜索图书ToolStripMenuItem});
            this.图书ToolStripMenuItem.Name = "图书ToolStripMenuItem";
            this.图书ToolStripMenuItem.Size = new System.Drawing.Size(143, 40);
            this.图书ToolStripMenuItem.Text = "图书管理";
            this.图书ToolStripMenuItem.Click += new System.EventHandler(this.图书ToolStripMenuItem_Click);
            // 
            // 添加图书ToolStripMenuItem
            // 
            this.添加图书ToolStripMenuItem.Name = "添加图书ToolStripMenuItem";
            this.添加图书ToolStripMenuItem.Size = new System.Drawing.Size(270, 44);
            this.添加图书ToolStripMenuItem.Text = "添加图书";
            this.添加图书ToolStripMenuItem.Click += new System.EventHandler(this.添加图书ToolStripMenuItem_Click);
            // 
            // 搜索图书ToolStripMenuItem
            // 
            this.搜索图书ToolStripMenuItem.Name = "搜索图书ToolStripMenuItem";
            this.搜索图书ToolStripMenuItem.Size = new System.Drawing.Size(270, 44);
            this.搜索图书ToolStripMenuItem.Text = "搜索图书";
            this.搜索图书ToolStripMenuItem.Click += new System.EventHandler(this.搜索图书ToolStripMenuItem_Click);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(143, 40);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 1;
            // 
            // 下架图书ToolStripMenuItem
            // 
            this.下架图书ToolStripMenuItem.Name = "下架图书ToolStripMenuItem";
            this.下架图书ToolStripMenuItem.Size = new System.Drawing.Size(270, 44);
            this.下架图书ToolStripMenuItem.Text = "下架图书";
            this.下架图书ToolStripMenuItem.Click += new System.EventHandler(this.下架图书ToolStripMenuItem_Click);
            // 
            // 修改图书ToolStripMenuItem
            // 
            this.修改图书ToolStripMenuItem.Name = "修改图书ToolStripMenuItem";
            this.修改图书ToolStripMenuItem.Size = new System.Drawing.Size(270, 44);
            this.修改图书ToolStripMenuItem.Text = "修改图书";
            this.修改图书ToolStripMenuItem.Click += new System.EventHandler(this.修改图书ToolStripMenuItem_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 829);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 租书情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看租书情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜索图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 下架图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改图书ToolStripMenuItem;
    }
}