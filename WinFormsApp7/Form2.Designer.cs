namespace WinFormsApp7
{
    partial class Form2
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
            button1 = new AntdUI.Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(117, 77);
            button1.Name = "button1";
            button1.Shape = AntdUI.TShape.Circle;
            button1.Size = new Size(138, 119);
            button1.TabIndex = 0;
            button1.Text = "button1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(193, 282);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(171, 37);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private RichTextBox richTextBox1;
    }
}