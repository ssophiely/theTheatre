namespace TheTheatre
{
    partial class ShowEdit
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            Close = new Button();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label9 = new Label();
            label2 = new Label();
            label8 = new Label();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 4;
            label1.Text = "Название:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(507, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(266, 220);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(507, 76);
            textBox2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 220);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 10;
            label5.Text = "Описание:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(266, 326);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(507, 28);
            comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 326);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 14;
            label3.Text = "Зал:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(266, 384);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(507, 92);
            checkedListBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 384);
            label4.Name = "label4";
            label4.Size = new Size(172, 19);
            label4.TabIndex = 17;
            label4.Text = "Участие принимали:";
            // 
            // Close
            // 
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Close.ForeColor = Color.White;
            Close.Location = new Point(637, 486);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 18;
            Close.Text = "Изменить";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(267, 160);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(222, 27);
            numericUpDown4.TabIndex = 28;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(266, 111);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(222, 27);
            numericUpDown3.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(22, 168);
            label9.Name = "label9";
            label9.Size = new Size(230, 19);
            label9.TabIndex = 26;
            label9.Text = "Максимальная цена билета:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 119);
            label2.Name = "label2";
            label2.Size = new Size(224, 19);
            label2.TabIndex = 25;
            label2.Text = "Минимальная цена билета:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(453, 71);
            label8.Name = "label8";
            label8.Size = new Size(36, 19);
            label8.TabIndex = 24;
            label8.Text = "мин";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(372, 63);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(75, 27);
            numericUpDown2.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(347, 71);
            label7.Name = "label7";
            label7.Size = new Size(18, 19);
            label7.TabIndex = 22;
            label7.Text = "ч";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(266, 63);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(75, 27);
            numericUpDown1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 71);
            label6.Name = "label6";
            label6.Size = new Size(175, 19);
            label6.TabIndex = 20;
            label6.Text = "Продолжительность:";
            // 
            // ShowEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 534);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(numericUpDown2);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(Close);
            Controls.Add(label4);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ShowEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение данных о спектакле";
            Deactivate += ShowEdit_Deactivate;
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private Button Close;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private Label label9;
        private Label label2;
        private Label label8;
        private NumericUpDown numericUpDown2;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Label label6;
    }
}