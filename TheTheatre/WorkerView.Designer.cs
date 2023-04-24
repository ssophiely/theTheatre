namespace TheTheatre
{
    partial class WorkerView
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
            w_name = new Label();
            label2 = new Label();
            w_role = new Label();
            w_experience = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            Close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 1;
            label1.Text = "ФИО:";
            // 
            // w_name
            // 
            w_name.AutoSize = true;
            w_name.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            w_name.Location = new Point(195, 31);
            w_name.Name = "w_name";
            w_name.Size = new Size(51, 19);
            w_name.TabIndex = 2;
            w_name.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 77);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 3;
            label2.Text = "Должность:";
            // 
            // w_role
            // 
            w_role.AutoSize = true;
            w_role.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            w_role.Location = new Point(195, 77);
            w_role.Name = "w_role";
            w_role.Size = new Size(51, 19);
            w_role.TabIndex = 4;
            w_role.Text = "label2";
            // 
            // w_experience
            // 
            w_experience.AutoSize = true;
            w_experience.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            w_experience.Location = new Point(195, 120);
            w_experience.Name = "w_experience";
            w_experience.Size = new Size(51, 19);
            w_experience.TabIndex = 6;
            w_experience.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 121);
            label4.Name = "label4";
            label4.Size = new Size(157, 19);
            label4.TabIndex = 5;
            label4.Text = "Стаж работы (лет):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 173);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 7;
            label5.Text = "Спектакли:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(195, 169);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 183);
            textBox1.TabIndex = 8;
            // 
            // Close
            // 
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Close.ForeColor = Color.White;
            Close.Location = new Point(521, 358);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 9;
            Close.Text = "Закрыть";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // WorkerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(669, 402);
            Controls.Add(Close);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(w_experience);
            Controls.Add(label4);
            Controls.Add(w_role);
            Controls.Add(label2);
            Controls.Add(w_name);
            Controls.Add(label1);
            Name = "WorkerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о сотруднике театра";
            Deactivate += WorkerView_Deactivate;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label w_name;
        private Label label2;
        private Label w_role;
        private Label w_experience;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Button Close;
    }
}