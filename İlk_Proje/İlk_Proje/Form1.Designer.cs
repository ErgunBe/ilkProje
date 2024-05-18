namespace İlk_Proje
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 192, 192);
            textBox1.Font = new Font("Georgia", 14.25F);
            textBox1.Location = new Point(124, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 29);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 192, 192);
            textBox2.Font = new Font("Georgia", 14.25F);
            textBox2.Location = new Point(124, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 29);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(255, 192, 192);
            textBox3.Font = new Font("Georgia", 14.25F);
            textBox3.Location = new Point(124, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 29);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14.25F);
            label1.Location = new Point(289, 59);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F);
            label2.Location = new Point(286, 103);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 14.25F);
            label3.Location = new Point(287, 145);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // button1
            // 
            button1.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(124, 188);
            button1.Name = "button1";
            button1.Size = new Size(223, 34);
            button1.TabIndex = 6;
            button1.Text = "Yazdır";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(38, 59);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 7;
            label4.Text = "Adınız:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(11, 103);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 8;
            label5.Text = "Soyadınız:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(35, 145);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 9;
            label6.Text = "meslek:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
