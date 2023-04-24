namespace TheTheatre
{
    partial class WorkerEdit
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            w_name = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            Close = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 2;
            label1.Text = "ФИО:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 80);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 4;
            label2.Text = "Должность:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 130);
            label4.Name = "label4";
            label4.Size = new Size(157, 19);
            label4.TabIndex = 6;
            label4.Text = "Стаж работы (лет):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 182);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 8;
            label5.Text = "Спектакли:";
            // 
            // w_name
            // 
            w_name.AutoSize = true;
            w_name.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            w_name.Location = new Point(248, 30);
            w_name.Name = "w_name";
            w_name.Size = new Size(51, 19);
            w_name.TabIndex = 9;
            w_name.Text = "label1";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(248, 127);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(409, 27);
            numericUpDown1.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(248, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(409, 28);
            comboBox1.TabIndex = 13;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(248, 182);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(409, 158);
            checkedListBox1.TabIndex = 14;
            // 
            // Close
            // 
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Close.ForeColor = Color.White;
            Close.Location = new Point(521, 354);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 15;
            Close.Text = "Изменить";
            Close.UseVisualStyleBackColor = false;
            // 
            // WorkerEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(669, 402);
            Controls.Add(Close);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(w_name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WorkerEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение данных о сотруднике";
            Deactivate += WorkerEdit_Deactivate;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label w_name;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private CheckedListBox checkedListBox1;
        private Button Close;
    }
}