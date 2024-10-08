namespace Library
{
    partial class FormAddBook
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.t6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.Location = new System.Drawing.Point(155, 55);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(89, 18);
            this.t1.TabIndex = 2;
            this.t1.Text = " 图书编号";
            this.t1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(290, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(338, 28);
            this.txtID.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(290, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(338, 28);
            this.txtName.TabIndex = 5;
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Location = new System.Drawing.Point(155, 106);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(53, 18);
            this.t2.TabIndex = 4;
            this.t2.Text = " 书名";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(290, 149);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(338, 28);
            this.txtAuthor.TabIndex = 7;
            // 
            // t3
            // 
            this.t3.AutoSize = true;
            this.t3.Location = new System.Drawing.Point(155, 159);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(53, 18);
            this.t3.TabIndex = 6;
            this.t3.Text = " 作者";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(290, 203);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(338, 28);
            this.txtPublisher.TabIndex = 9;
            // 
            // t4
            // 
            this.t4.AutoSize = true;
            this.t4.Location = new System.Drawing.Point(155, 213);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(62, 18);
            this.t4.TabIndex = 8;
            this.t4.Text = "出版社";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(290, 258);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(338, 28);
            this.txtPrice.TabIndex = 11;
            // 
            // t5
            // 
            this.t5.AutoSize = true;
            this.t5.Location = new System.Drawing.Point(155, 268);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(62, 18);
            this.t5.TabIndex = 10;
            this.t5.Text = " 价格 ";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(290, 315);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(338, 28);
            this.txtNum.TabIndex = 13;
            // 
            // t6
            // 
            this.t6.AutoSize = true;
            this.t6.Location = new System.Drawing.Point(155, 325);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(44, 18);
            this.t6.TabIndex = 12;
            this.t6.Text = "库存";
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormAddBook";
            this.Text = "FormAddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label t1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label t2;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label t3;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label t4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label t5;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label t6;
    }
}