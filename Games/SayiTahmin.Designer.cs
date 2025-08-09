namespace Games
{
    partial class SayiTahmin
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 0;
            label1.Text = "Sayı Giriniz: (1 ile 100 arasında)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(208, 59);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 2;
            button1.Text = "Tahmin Et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 63);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 104);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 105);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 5;
            label4.Text = "Code";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(452, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(452, 131);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
            button2.TabIndex = 7;
            button2.Text = "Kontrol";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SayiTahmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 183);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "SayiTahmin";
            Text = "Sayı Tahmin Oyunu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Button button2;
    }
}
