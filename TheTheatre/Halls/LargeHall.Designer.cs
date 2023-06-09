﻿namespace TheTheatre.Halls
{
    partial class LargeHall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LargeHall));
            Close = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Close
            // 
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Close.ForeColor = Color.White;
            Close.Location = new Point(617, 541);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 19;
            Close.Text = "Закрыть";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(734, 520);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // LargeHall
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(759, 585);
            Controls.Add(pictureBox1);
            Controls.Add(Close);
            MaximizeBox = false;
            MaximumSize = new Size(777, 632);
            MinimizeBox = false;
            MinimumSize = new Size(777, 632);
            Name = "LargeHall";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Большой зал";
            Deactivate += LargeHall_Deactivate;
            Load += LargeHall_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Close;
        private PictureBox pictureBox1;
    }
}