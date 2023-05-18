namespace TheTheatre
{
    partial class EnterRole
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
            role = new TextBox();
            Enter_role = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 41);
            label1.Name = "label1";
            label1.Size = new Size(120, 19);
            label1.TabIndex = 0;
            label1.Text = "Введите роль:";
            // 
            // role
            // 
            role.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            role.Location = new Point(170, 37);
            role.Name = "role";
            role.Size = new Size(457, 27);
            role.TabIndex = 1;
            // 
            // Enter_role
            // 
            Enter_role.BackColor = Color.Black;
            Enter_role.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Enter_role.ForeColor = Color.White;
            Enter_role.Location = new Point(491, 88);
            Enter_role.Name = "Enter_role";
            Enter_role.Size = new Size(136, 36);
            Enter_role.TabIndex = 4;
            Enter_role.Text = "ОК";
            Enter_role.UseVisualStyleBackColor = false;
            Enter_role.Click += Enter_role_Click;
            // 
            // EnterRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(639, 136);
            Controls.Add(Enter_role);
            Controls.Add(role);
            Controls.Add(label1);
            Name = "EnterRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Роль";
            Load += EnterRole_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox role;
        private Button Enter_role;
    }
}