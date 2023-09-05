namespace FSG.HCM.NewModules
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
            listView1 = new ListView();
            ProjListLable = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 58);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 449);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ProjListLable
            // 
            ProjListLable.AutoSize = true;
            ProjListLable.Location = new Point(43, 29);
            ProjListLable.Name = "ProjListLable";
            ProjListLable.Size = new Size(56, 17);
            ProjListLable.TabIndex = 1;
            ProjListLable.Text = "项目列表";
            // 
            // button1
            // 
            button1.Location = new Point(1034, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "新增项目";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(730, 32);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 3;
            label1.Text = "项目名称";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(787, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 23);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 528);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(ProjListLable);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "项目管理";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label ProjListLable;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}