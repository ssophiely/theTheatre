namespace TheTheatre
{
    partial class Shows
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Close = new Button();
            Back = new Button();
            table = new DataGridView();
            Name_ = new DataGridViewTextBoxColumn();
            See = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            Del = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            add = new Button();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            // Back
            // 
            Back.BackColor = Color.Gray;
            Back.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Back.ForeColor = Color.White;
            Back.Location = new Point(701, 555);
            Back.Name = "Back";
            Back.Size = new Size(136, 36);
            Back.TabIndex = 5;
            Back.Text = "Назад";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // table
            // 
            table.AllowDrop = true;
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            table.DefaultCellStyle = dataGridViewCellStyle7;
            table.Dock = DockStyle.Top;
            table.Location = new Point(0, 0);
            table.Name = "table";
            table.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            table.RowHeadersVisible = false;
            table.RowHeadersWidth = 70;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            table.RowsDefaultCellStyle = dataGridViewCellStyle8;
            table.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            table.RowTemplate.Height = 50;
            table.ShowCellToolTips = false;
            table.Size = new Size(991, 251);
            table.TabIndex = 7;
            table.CellContentClick += table_CellContentClick;
            // 
            // Name_
            // 
            Name_.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Name_.DefaultCellStyle = dataGridViewCellStyle3;
            Name_.FillWeight = 320F;
            Name_.HeaderText = "Название";
            Name_.MinimumWidth = 6;
            Name_.Name = "Name_";
            Name_.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // See
            // 
            See.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.LightYellow;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            See.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Lavender;
            dataGridViewCellStyle5.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            Edit.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Plum;
            dataGridViewCellStyle6.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            Del.DefaultCellStyle = dataGridViewCellStyle6;
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
            groupBox1.BackColor = Color.FromArgb(248, 244, 255);
            groupBox1.Controls.Add(add);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 267);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 282);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить спектакль";
            // 
            // add
            // 
            add.BackColor = Color.Violet;
            add.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(825, 241);
            add.Name = "add";
            add.Size = new Size(136, 36);
            add.TabIndex = 9;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(591, 143);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(370, 92);
            checkedListBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(145, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(294, 27);
            comboBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(591, 26);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(370, 98);
            textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(145, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(294, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 27);
            textBox1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 178);
            label6.Name = "label6";
            label6.Size = new Size(38, 19);
            label6.TabIndex = 5;
            label6.Text = "Зал:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(478, 178);
            label5.Name = "label5";
            label5.Size = new Size(89, 19);
            label5.TabIndex = 4;
            label5.Text = "Участники:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 105);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 2;
            label3.Text = "Дата и время:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(478, 26);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 1;
            label2.Text = "Описание:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 26);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // Shows
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(991, 596);
            Controls.Add(groupBox1);
            Controls.Add(table);
            Controls.Add(Back);
            Controls.Add(Close);
            Name = "Shows";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спектакли";
            Load += Shows_Load;
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Close;
        private Button Back;
        private DataGridView table;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private CheckedListBox checkedListBox1;
        private Button add;
        private DataGridViewTextBoxColumn Name_;
        private DataGridViewButtonColumn See;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Del;
    }
}