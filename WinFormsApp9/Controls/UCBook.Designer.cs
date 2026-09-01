namespace WinFormsApp9.Controls
{
    partial class UCBook
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            label2 = new Label();
            labname = new AntdUI.Input();
            label3 = new Label();
            label4 = new Label();
            labauthor = new AntdUI.Input();
            lablabel = new AntdUI.Input();
            label5 = new Label();
            labprice = new AntdUI.InputNumber();
            button1 = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(122, 26);
            label1.Name = "label1";
            label1.Size = new Size(166, 62);
            label1.TabIndex = 0;
            label1.Text = "";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 118);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 1;
            label2.Text = "图书名称：";
            // 
            // labname
            // 
            labname.Location = new Point(170, 118);
            labname.Name = "labname";
            labname.PlaceholderText = "请输入图书名称";
            labname.Size = new Size(118, 26);
            labname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 166);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 1;
            label3.Text = "图书作者：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 224);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 1;
            label4.Text = "图书价格：";
            // 
            // labauthor
            // 
            labauthor.Location = new Point(170, 166);
            labauthor.Name = "labauthor";
            labauthor.PlaceholderText = "请输入图书作者";
            labauthor.Size = new Size(118, 26);
            labauthor.TabIndex = 2;
            // 
            // lablabel
            // 
            lablabel.Location = new Point(170, 266);
            lablabel.Multiline = true;
            lablabel.Name = "lablabel";
            lablabel.PlaceholderText = "请输入图书标签";
            lablabel.Size = new Size(150, 134);
            lablabel.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 277);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 1;
            label5.Text = "图书标签：";
            // 
            // labprice
            // 
            labprice.Location = new Point(170, 224);
            labprice.Name = "labprice";
            labprice.PlaceholderText = "请输入图书价格";
            labprice.Size = new Size(118, 26);
            labprice.TabIndex = 3;
            labprice.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(145, 406);
            button1.Name = "button1";
            button1.Size = new Size(107, 39);
            button1.TabIndex = 4;
            button1.Click += this.button1_Click;
            // 
            // UCBook
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(labprice);
            Controls.Add(lablabel);
            Controls.Add(labauthor);
            Controls.Add(labname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCBook";
            Size = new Size(410, 451);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Label label1;
        private Label label2;
        private AntdUI.Input labname;
        private Label label3;
        private Label label4;
        private AntdUI.Input labauthor;
        private AntdUI.Input lablabel;
        private Label label5;
        private AntdUI.InputNumber labprice;
        private AntdUI.Button button1;
    }
}
