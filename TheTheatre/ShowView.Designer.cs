﻿namespace TheTheatre
{
    partial class ShowView
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
            w_name = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            Close = new Button();
            view_hall = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // w_name
            // 
            w_name.AutoSize = true;
            w_name.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            w_name.Location = new Point(217, 33);
            w_name.Name = "w_name";
            w_name.Size = new Size(51, 19);
            w_name.TabIndex = 4;
            w_name.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 33);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 3;
            label1.Text = "Название:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(217, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 75);
            label3.Name = "label3";
            label3.Size = new Size(175, 19);
            label3.TabIndex = 5;
            label3.Text = "Продолжительность:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 124);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 7;
            label5.Text = "Описание:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(217, 124);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(667, 76);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 220);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(667, 98);
            textBox1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 220);
            label4.Name = "label4";
            label4.Size = new Size(172, 19);
            label4.TabIndex = 10;
            label4.Text = "Участие принимали:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 340);
            label6.Name = "label6";
            label6.Size = new Size(42, 19);
            label6.TabIndex = 12;
            label6.Text = "Зал:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(217, 340);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 13;
            label7.Text = "label3";
            // 
            // Close
            // 
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Close.ForeColor = Color.White;
            Close.Location = new Point(748, 380);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 14;
            Close.Text = "Закрыть";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // view_hall
            // 
            view_hall.BackColor = Color.Gray;
            view_hall.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            view_hall.ForeColor = Color.White;
            view_hall.Location = new Point(587, 380);
            view_hall.Name = "view_hall";
            view_hall.Size = new Size(155, 36);
            view_hall.TabIndex = 15;
            view_hall.Text = "Посмотреть зал";
            view_hall.UseVisualStyleBackColor = false;
            view_hall.Click += view_hall_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(666, 33);
            label8.Name = "label8";
            label8.Size = new Size(51, 19);
            label8.TabIndex = 17;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(413, 33);
            label9.Name = "label9";
            label9.Size = new Size(224, 19);
            label9.TabIndex = 16;
            label9.Text = "Минимальная цена билета:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(666, 75);
            label10.Name = "label10";
            label10.Size = new Size(60, 19);
            label10.TabIndex = 19;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(413, 75);
            label11.Name = "label11";
            label11.Size = new Size(230, 19);
            label11.TabIndex = 18;
            label11.Text = "Максимальная цена билета:";
            // 
            // ShowView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(907, 428);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(view_hall);
            Controls.Add(Close);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(w_name);
            Controls.Add(label1);
            Name = "ShowView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о спектакле";
            Deactivate += ShowView_Deactivate;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label w_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button Close;
        private Button view_hall;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}