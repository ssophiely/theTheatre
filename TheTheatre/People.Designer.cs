namespace TheTheatre
{
    partial class People
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            table = new DataGridView();
            Name_ = new DataGridViewTextBoxColumn();
            See = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            Del = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            add = new Button();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            Close = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // table
            // 
            table.AllowDrop = true;
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.AllowUserToOrderColumns = true;
            table.AllowUserToResizeColumns = false;
            table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            table.BackgroundColor = Color.White;
            table.BorderStyle = BorderStyle.None;
            table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.ColumnHeadersVisible = false;
            table.Columns.AddRange(new DataGridViewColumn[] { Name_, See, Edit, Del });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            table.DefaultCellStyle = dataGridViewCellStyle6;
            table.Dock = DockStyle.Top;
            table.Location = new Point(0, 0);
            table.Name = "table";
            table.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            table.RowHeadersVisible = false;
            table.RowHeadersWidth = 70;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            table.RowsDefaultCellStyle = dataGridViewCellStyle7;
            table.RowTemplate.Height = 29;
            table.ShowCellToolTips = false;
            table.Size = new Size(991, 251);
            table.TabIndex = 10;
            table.CellContentClick += table_CellContentClick;
            // 
            // Name_
            // 
            Name_.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name_.FillWeight = 320F;
            Name_.HeaderText = "Название";
            Name_.MinimumWidth = 6;
            Name_.Name = "Name_";
            Name_.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // See
            // 
            See.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightYellow;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            See.DefaultCellStyle = dataGridViewCellStyle3;
            See.FillWeight = 80F;
            See.FlatStyle = FlatStyle.Popup;
            See.HeaderText = "Подробнее";
            See.MinimumWidth = 6;
            See.Name = "See";
            See.Resizable = DataGridViewTriState.True;
            See.Text = "Подробнее";
            See.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Lavender;
            dataGridViewCellStyle4.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            Edit.DefaultCellStyle = dataGridViewCellStyle4;
            Edit.FillWeight = 80F;
            Edit.FlatStyle = FlatStyle.Popup;
            Edit.HeaderText = "Редактировать";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.Text = "Редактировать";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Del
            // 
            Del.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Plum;
            dataGridViewCellStyle5.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            Del.DefaultCellStyle = dataGridViewCellStyle5;
            Del.FillWeight = 70F;
            Del.FlatStyle = FlatStyle.Popup;
            Del.HeaderText = "Удалить";
            Del.MinimumWidth = 6;
            Del.Name = "Del";
            Del.Resizable = DataGridViewTriState.True;
            Del.Text = "Удалить";
            Del.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 253, 242);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(add);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 283);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 253);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить работника театра";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(689, 34);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(272, 27);
            numericUpDown1.TabIndex = 11;
            // 
            // add
            // 
            add.BackColor = Color.FromArgb(253, 219, 109);
            add.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(825, 211);
            add.Name = "add";
            add.Size = new Size(136, 36);
            add.TabIndex = 9;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(136, 115);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(334, 114);
            checkedListBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(689, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(272, 27);
            comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 27);
            textBox1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(507, 115);
            label6.Name = "label6";
            label6.Size = new Size(94, 19);
            label6.TabIndex = 5;
            label6.Text = "Должность:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 115);
            label5.Name = "label5";
            label5.Size = new Size(87, 19);
            label5.TabIndex = 4;
            label5.Text = "Спектакли:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(507, 42);
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
            Close.Location = new Point(843, 555);
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
            button1.Location = new Point(701, 555);
            button1.Name = "button1";
            button1.Size = new Size(136, 36);
            button1.TabIndex = 4;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // People
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(991, 596);
            Controls.Add(groupBox1);
            Controls.Add(table);
            Controls.Add(button1);
            Controls.Add(Close);
            Name = "People";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Люди театра";
            Load += People_Load;
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView table;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private Button add;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label1;
        private Button Close;
        private Button button1;
        private DataGridViewTextBoxColumn Name_;
        private DataGridViewButtonColumn See;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Del;
    }
}