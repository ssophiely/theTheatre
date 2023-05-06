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
            label3 = new Label();
            experience = new NumericUpDown();
            position = new ComboBox();
            Change = new Button();
            fullname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)experience).BeginInit();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 130);
            label3.Name = "label3";
            label3.Size = new Size(157, 19);
            label3.TabIndex = 6;
            label3.Text = "Стаж работы (лет):";
            // 
            // experience
            // 
            experience.Location = new Point(248, 127);
            experience.Name = "experience";
            experience.Size = new Size(154, 27);
            experience.TabIndex = 12;
            // 
            // position
            // 
            position.DropDownStyle = ComboBoxStyle.DropDownList;
            position.FormattingEnabled = true;
            position.Items.AddRange(new object[] { "Режиссер-постановщик", "Актер", "Звукорежиссер", "Художник" });
            position.Location = new Point(248, 76);
            position.Name = "position";
            position.Size = new Size(562, 28);
            position.TabIndex = 13;
            // 
            // Change
            // 
            Change.BackColor = Color.Black;
            Change.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Change.ForeColor = Color.White;
            Change.Location = new Point(674, 181);
            Change.Name = "Change";
            Change.Size = new Size(136, 36);
            Change.TabIndex = 15;
            Change.Text = "Изменить";
            Change.UseVisualStyleBackColor = false;
            Change.Click += Change_Click;
            // 
            // fullname
            // 
            fullname.Location = new Point(248, 28);
            fullname.Name = "fullname";
            fullname.Size = new Size(562, 27);
            fullname.TabIndex = 16;
            // 
            // WorkerEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(828, 225);
            Controls.Add(fullname);
            Controls.Add(Change);
            Controls.Add(position);
            Controls.Add(experience);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WorkerEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение данных о сотруднике";
            Deactivate += WorkerEdit_Deactivate;
            Load += WorkerEdit_Load;
            ((System.ComponentModel.ISupportInitialize)experience).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown experience;
        private ComboBox position;
        private Button Change;
        private TextBox fullname;
    }
}