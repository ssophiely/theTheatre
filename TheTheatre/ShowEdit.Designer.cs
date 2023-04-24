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
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            Close = new Button();
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
            textBox1.Location = new Point(200, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(573, 27);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 77);
            label2.Name = "label2";
            label2.Size = new Size(116, 19);
            label2.TabIndex = 6;
            label2.Text = "Дата и время:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(200, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(573, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 140);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(573, 76);
            textBox2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 140);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 10;
            label5.Text = "Описание:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(200, 247);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(573, 28);
            comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 247);
            label3.Name = "label3";
            label3.Size = new Size(42, 19);
            label3.TabIndex = 14;
            label3.Text = "Зал:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(200, 305);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(573, 92);
            checkedListBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 305);
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
            Close.Location = new Point(637, 403);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 18;
            Close.Text = "Изменить";
            Close.UseVisualStyleBackColor = false;
            // 
            // ShowEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(Close);
            Controls.Add(label4);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ShowEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение данных о спектакле";
            Deactivate += ShowEdit_Deactivate;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private Button Close;
    }
}