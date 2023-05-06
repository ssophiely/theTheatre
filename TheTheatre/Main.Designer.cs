namespace TheTheatre
{
    partial class Main
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
            Shows = new Button();
            People = new Button();
            Close = new Button();
            SuspendLayout();
            // 
            // Shows
            // 
            Shows.BackColor = Color.Violet;
            Shows.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Shows.Location = new Point(239, 92);
            Shows.Name = "Shows";
            Shows.Size = new Size(170, 82);
            Shows.TabIndex = 0;
            Shows.Text = "Спектакли";
            Shows.UseVisualStyleBackColor = false;
            Shows.Click += Shows_Click;
            // 
            // People
            // 
            People.BackColor = Color.FromArgb(253, 219, 109);
            People.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            People.Location = new Point(239, 186);
            People.Name = "People";
            People.Size = new Size(170, 82);
            People.TabIndex = 1;
            People.Text = "Работники театра";
            People.UseVisualStyleBackColor = false;
            People.Click += People_Click;
            // 
            // Close
            // 
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Close.ForeColor = Color.White;
            Close.Location = new Point(501, 312);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 2;
            Close.Text = "Закрыть";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(649, 360);
            Controls.Add(Close);
            Controls.Add(People);
            Controls.Add(Shows);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Театр";
            Load += Main_Load;
            Shown += Main_Shown;
            ResumeLayout(false);
        }

        #endregion

        private Button Shows;
        private Button People;
        private Button Close;
    }
}