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
            label5 = new Label();
            roles = new TextBox();
            Close = new Button();
            label1 = new Label();
            w_name = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 104);
            label5.Name = "label5";
            label5.Size = new Size(157, 19);
            label5.TabIndex = 7;
            label5.Text = "Спектакли и роли:";
            // 
            // roles
            // 
            roles.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            roles.Location = new Point(175, 101);
            roles.Multiline = true;
            roles.Name = "roles";
            roles.ScrollBars = ScrollBars.Vertical;
            roles.Size = new Size(699, 233);
            roles.TabIndex = 8;
            roles.TabStop = false;
            // 
            // Close
            // 
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Close.ForeColor = Color.White;
            Close.Location = new Point(738, 340);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 9;
            Close.Text = "Закрыть";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 10;
            label1.Text = "ФИО:";
            // 
            // w_name
            // 
            w_name.AutoSize = true;
            w_name.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            w_name.Location = new Point(175, 29);
            w_name.Name = "w_name";
            w_name.Size = new Size(51, 19);
            w_name.TabIndex = 11;
            w_name.Text = "label2";
            // 
            // WorkerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 388);
            Controls.Add(w_name);
            Controls.Add(label1);
            Controls.Add(Close);
            Controls.Add(roles);
            Controls.Add(label5);
            Name = "WorkerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о сотруднике театра";
            Deactivate += WorkerView_Deactivate;
            Load += WorkerView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox roles;
        private Button Close;
        private Label label1;
        private Label w_name;
    }
}