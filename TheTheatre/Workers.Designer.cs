﻿namespace TheTheatre
{
    partial class Workers
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
            if (!ReturnForm.Visible)
            {
                ReturnForm.Close();
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            workers_t = new DataGridView();
            Name_ = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Experience = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Del = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            workexp_nud = new NumericUpDown();
            worker_add = new Button();
            position_cb = new ComboBox();
            fullname_tb = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            Close = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)workers_t).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)workexp_nud).BeginInit();
            SuspendLayout();
            // 
            // workers_t
            // 
            workers_t.AllowDrop = true;
            workers_t.AllowUserToAddRows = false;
            workers_t.AllowUserToDeleteRows = false;
            workers_t.AllowUserToOrderColumns = true;
            workers_t.AllowUserToResizeColumns = false;
            workers_t.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            workers_t.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            workers_t.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            workers_t.BackgroundColor = Color.White;
            workers_t.BorderStyle = BorderStyle.None;
            workers_t.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            workers_t.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            workers_t.ColumnHeadersHeight = 35;
            workers_t.Columns.AddRange(new DataGridViewColumn[] { Name_, Position, Experience, Edit, Del });
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.Window;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            workers_t.DefaultCellStyle = dataGridViewCellStyle17;
            workers_t.Dock = DockStyle.Top;
            workers_t.Location = new Point(0, 0);
            workers_t.Name = "workers_t";
            workers_t.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            workers_t.RowHeadersVisible = false;
            workers_t.RowHeadersWidth = 70;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            workers_t.RowsDefaultCellStyle = dataGridViewCellStyle18;
            workers_t.RowTemplate.Height = 29;
            workers_t.ShowCellToolTips = false;
            workers_t.Size = new Size(991, 176);
            workers_t.TabIndex = 10;
            workers_t.CellContentClick += table_CellContentClick;
            // 
            // Name_
            // 
            Name_.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.SelectionBackColor = Color.White;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            Name_.DefaultCellStyle = dataGridViewCellStyle12;
            Name_.DividerWidth = 1;
            Name_.FillWeight = 320F;
            Name_.HeaderText = "Имя";
            Name_.MinimumWidth = 6;
            Name_.Name = "Name_";
            // 
            // Position
            // 
            dataGridViewCellStyle13.SelectionBackColor = Color.White;
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            Position.DefaultCellStyle = dataGridViewCellStyle13;
            Position.DividerWidth = 1;
            Position.HeaderText = "Должность";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            Position.Width = 125;
            // 
            // Experience
            // 
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.SelectionBackColor = Color.White;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            Experience.DefaultCellStyle = dataGridViewCellStyle14;
            Experience.DividerWidth = 1;
            Experience.HeaderText = "Стаж";
            Experience.MinimumWidth = 6;
            Experience.Name = "Experience";
            Experience.Width = 125;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.Lavender;
            dataGridViewCellStyle15.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            Edit.DefaultCellStyle = dataGridViewCellStyle15;
            Edit.DividerWidth = 1;
            Edit.FillWeight = 80F;
            Edit.FlatStyle = FlatStyle.Popup;
            Edit.HeaderText = "";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.Text = "Редактировать";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Del
            // 
            Del.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.Plum;
            dataGridViewCellStyle16.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            Del.DefaultCellStyle = dataGridViewCellStyle16;
            Del.DividerWidth = 1;
            Del.FillWeight = 70F;
            Del.FlatStyle = FlatStyle.Popup;
            Del.HeaderText = "";
            Del.MinimumWidth = 6;
            Del.Name = "Del";
            Del.Resizable = DataGridViewTriState.True;
            Del.Text = "Удалить";
            Del.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 253, 242);
            groupBox1.Controls.Add(workexp_nud);
            groupBox1.Controls.Add(worker_add);
            groupBox1.Controls.Add(position_cb);
            groupBox1.Controls.Add(fullname_tb);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 224);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить работника театра";
            // 
            // workexp_nud
            // 
            workexp_nud.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            workexp_nud.Location = new Point(198, 133);
            workexp_nud.Name = "workexp_nud";
            workexp_nud.Size = new Size(147, 27);
            workexp_nud.TabIndex = 11;
            // 
            // worker_add
            // 
            worker_add.BackColor = Color.FromArgb(253, 219, 109);
            worker_add.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            worker_add.Location = new Point(825, 177);
            worker_add.Name = "worker_add";
            worker_add.Size = new Size(136, 36);
            worker_add.TabIndex = 9;
            worker_add.Text = "Добавить";
            worker_add.UseVisualStyleBackColor = false;
            worker_add.Click += add_Click;
            // 
            // position_cb
            // 
            position_cb.BackColor = Color.White;
            position_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            position_cb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            position_cb.ForeColor = Color.Black;
            position_cb.FormattingEnabled = true;
            position_cb.Items.AddRange(new object[] { "Режиссер-постановщик", "Актер", "Звукорежиссер", "Художник" });
            position_cb.Location = new Point(198, 87);
            position_cb.Name = "position_cb";
            position_cb.Size = new Size(593, 27);
            position_cb.TabIndex = 9;
            // 
            // fullname_tb
            // 
            fullname_tb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            fullname_tb.Location = new Point(198, 42);
            fullname_tb.Name = "fullname_tb";
            fullname_tb.Size = new Size(593, 27);
            fullname_tb.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 87);
            label6.Name = "label6";
            label6.Size = new Size(94, 19);
            label6.TabIndex = 5;
            label6.Text = "Должность:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 141);
            label3.Name = "label3";
            label3.Size = new Size(144, 19);
            label3.TabIndex = 2;
            label3.Text = "Стаж работы (лет):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 0;
            label1.Text = "ФИО:";
            // 
            // Close
            // 
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Close.ForeColor = Color.White;
            Close.Location = new Point(843, 435);
            Close.Name = "Close";
            Close.Size = new Size(136, 36);
            Close.TabIndex = 3;
            Close.Text = "Закрыть";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(701, 435);
            button1.Name = "button1";
            button1.Size = new Size(136, 36);
            button1.TabIndex = 4;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Workers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(991, 480);
            Controls.Add(groupBox1);
            Controls.Add(workers_t);
            Controls.Add(button1);
            Controls.Add(Close);
            Name = "Workers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Люди театра";
            Load += Workers_Load;
            ((System.ComponentModel.ISupportInitialize)workers_t).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)workexp_nud).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView workers_t;
        private GroupBox groupBox1;
        private NumericUpDown workexp_nud;
        private Button worker_add;
        private ComboBox position_cb;
        private TextBox fullname_tb;
        private Label label6;
        private Label label3;
        private Label label1;
        private Button Close;
        private Button button1;
        private DataGridViewTextBoxColumn Name_;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Experience;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Del;
    }
}