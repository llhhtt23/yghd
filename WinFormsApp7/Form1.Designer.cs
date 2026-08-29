namespace WinFormsApp7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AllCbox = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            ChildPan = new Panel();
            ChildPan.SuspendLayout();
            SuspendLayout();
            // 
            // AllCbox
            // 
            AllCbox.AutoSize = true;
            AllCbox.Location = new Point(262, 107);
            AllCbox.Name = "AllCbox";
            AllCbox.Size = new Size(51, 21);
            AllCbox.TabIndex = 0;
            AllCbox.Text = "全选";
            AllCbox.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(25, 7);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(39, 21);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "胸";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(13, 34);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(39, 21);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "背";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(13, 61);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(39, 21);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "肩";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(13, 88);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(39, 21);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "腿";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(13, 115);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(51, 21);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "手臂";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(13, 151);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(51, 21);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "腹肌";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // ChildPan
            // 
            ChildPan.Controls.Add(checkBox2);
            ChildPan.Controls.Add(checkBox7);
            ChildPan.Controls.Add(checkBox3);
            ChildPan.Controls.Add(checkBox6);
            ChildPan.Controls.Add(checkBox4);
            ChildPan.Controls.Add(checkBox5);
            ChildPan.Location = new Point(261, 134);
            ChildPan.Name = "ChildPan";
            ChildPan.Size = new Size(108, 239);
            ChildPan.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChildPan);
            Controls.Add(AllCbox);
            Name = "Form1";
            Text = "Form1";
            ChildPan.ResumeLayout(false);
            ChildPan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox AllCbox;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private Panel ChildPan;
    }
}
