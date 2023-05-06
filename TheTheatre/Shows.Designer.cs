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
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle31 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle32 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle33 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            Close = new Button();
            Back = new Button();
            table = new DataGridView();
            Name_ = new DataGridViewTextBoxColumn();
            See = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            Del = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            participants_t = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            listBox1 = new ListBox();
            button2 = new Button();
            label11 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label9 = new Label();
            label3 = new Label();
            label8 = new Label();
            add = new Button();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label10 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)participants_t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Close
            // 
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Close.ForeColor = Color.White;
            Close.Location = new Point(843, 683);
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
            Back.Location = new Point(701, 683);
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
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.WrapMode = DataGridViewTriState.True;
            table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            table.BackgroundColor = Color.White;
            table.BorderStyle = BorderStyle.None;
            table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = SystemColors.Control;
            dataGridViewCellStyle30.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle30.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = DataGridViewTriState.True;
            table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.ColumnHeadersVisible = false;
            table.Columns.AddRange(new DataGridViewColumn[] { Name_, See, Edit, Del });
            dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = SystemColors.Window;
            dataGridViewCellStyle35.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle35.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = DataGridViewTriState.True;
            table.DefaultCellStyle = dataGridViewCellStyle35;
            table.Dock = DockStyle.Top;
            table.Location = new Point(0, 0);
            table.Name = "table";
            table.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            table.RowHeadersVisible = false;
            table.RowHeadersWidth = 70;
            dataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle36.WrapMode = DataGridViewTriState.True;
            table.RowsDefaultCellStyle = dataGridViewCellStyle36;
            table.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            table.RowTemplate.Height = 50;
            table.ShowCellToolTips = false;
            table.Size = new Size(991, 176);
            table.TabIndex = 7;
            table.CellContentClick += table_CellContentClick;
            // 
            // Name_
            // 
            Name_.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.SelectionBackColor = Color.White;
            dataGridViewCellStyle31.SelectionForeColor = Color.Black;
            dataGridViewCellStyle31.WrapMode = DataGridViewTriState.True;
            Name_.DefaultCellStyle = dataGridViewCellStyle31;
            Name_.FillWeight = 320F;
            Name_.HeaderText = "Название";
            Name_.MinimumWidth = 6;
            Name_.Name = "Name_";
            Name_.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // See
            // 
            See.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = Color.LightYellow;
            dataGridViewCellStyle32.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle32.SelectionForeColor = Color.Black;
            See.DefaultCellStyle = dataGridViewCellStyle32;
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
            dataGridViewCellStyle33.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = Color.Lavender;
            dataGridViewCellStyle33.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle33.SelectionForeColor = Color.Black;
            Edit.DefaultCellStyle = dataGridViewCellStyle33;
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
            dataGridViewCellStyle34.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = Color.Plum;
            dataGridViewCellStyle34.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle34.SelectionForeColor = Color.Black;
            Del.DefaultCellStyle = dataGridViewCellStyle34;
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
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(numericUpDown4);
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(add);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 427);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить спектакль";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(participants_t);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(6, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(955, 207);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавить участника спектакля";
            // 
            // participants_t
            // 
            participants_t.AllowDrop = true;
            participants_t.AllowUserToAddRows = false;
            participants_t.AllowUserToDeleteRows = false;
            participants_t.AllowUserToOrderColumns = true;
            dataGridViewCellStyle37.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.WrapMode = DataGridViewTriState.True;
            participants_t.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            participants_t.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            participants_t.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            participants_t.BackgroundColor = Color.White;
            participants_t.BorderStyle = BorderStyle.None;
            participants_t.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.BackColor = SystemColors.Control;
            dataGridViewCellStyle38.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle38.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = DataGridViewTriState.True;
            participants_t.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            participants_t.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            participants_t.ColumnHeadersVisible = false;
            participants_t.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewButtonColumn3 });
            dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.BackColor = SystemColors.Window;
            dataGridViewCellStyle41.Font = new Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle41.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle41.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = DataGridViewTriState.True;
            participants_t.DefaultCellStyle = dataGridViewCellStyle41;
            participants_t.Location = new Point(471, 15);
            participants_t.Name = "participants_t";
            participants_t.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            participants_t.RowHeadersVisible = false;
            participants_t.RowHeadersWidth = 70;
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle42.WrapMode = DataGridViewTriState.True;
            participants_t.RowsDefaultCellStyle = dataGridViewCellStyle42;
            participants_t.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            participants_t.RowTemplate.Height = 50;
            participants_t.ShowCellToolTips = false;
            participants_t.Size = new Size(478, 186);
            participants_t.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.SelectionBackColor = Color.White;
            dataGridViewCellStyle39.SelectionForeColor = Color.Black;
            dataGridViewCellStyle39.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle39;
            dataGridViewTextBoxColumn1.FillWeight = 320F;
            dataGridViewTextBoxColumn1.HeaderText = "Участник";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.BackColor = Color.Plum;
            dataGridViewCellStyle40.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle40.SelectionForeColor = Color.Black;
            dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle40;
            dataGridViewButtonColumn3.FillWeight = 70F;
            dataGridViewButtonColumn3.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn3.HeaderText = "Удалить";
            dataGridViewButtonColumn3.MinimumWidth = 6;
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            dataGridViewButtonColumn3.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn3.Text = "Удалить";
            dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Items.AddRange(new object[] { "один", "два", "триииииииииииииииииииииииииииииии" });
            listBox1.Location = new Point(6, 50);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(448, 72);
            listBox1.TabIndex = 21;
            // 
            // button2
            // 
            button2.BackColor = Color.Violet;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(318, 165);
            button2.Name = "button2";
            button2.Size = new Size(136, 36);
            button2.TabIndex = 25;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 30);
            label11.Name = "label11";
            label11.Size = new Size(77, 17);
            label11.TabIndex = 22;
            label11.Text = "Сотрудник:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(70, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(384, 25);
            textBox3.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 139);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 23;
            label5.Text = "Роль:";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(854, 73);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(107, 27);
            numericUpDown4.TabIndex = 19;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(606, 73);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(107, 27);
            numericUpDown3.TabIndex = 18;
            // 
            // label9
            // 
            label9.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(745, 70);
            label9.Name = "label9";
            label9.Size = new Size(103, 40);
            label9.TabIndex = 17;
            label9.Text = "Максимальная цена билета:";
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(506, 73);
            label3.Name = "label3";
            label3.Size = new Size(94, 37);
            label3.TabIndex = 16;
            label3.Text = "Минимальная цена билета:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(854, 37);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 15;
            label8.Text = "мин";
            // 
            // add
            // 
            add.BackColor = Color.Violet;
            add.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(825, 385);
            add.Name = "add";
            add.Size = new Size(136, 36);
            add.TabIndex = 9;
            add.Text = "Создать";
            add.UseVisualStyleBackColor = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(773, 29);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(75, 27);
            numericUpDown2.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(748, 37);
            label7.Name = "label7";
            label7.Size = new Size(16, 17);
            label7.TabIndex = 13;
            label7.Text = "ч";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(660, 30);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(75, 27);
            numericUpDown1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(506, 33);
            label4.Name = "label4";
            label4.Size = new Size(138, 17);
            label4.TabIndex = 11;
            label4.Text = "Продолжительность:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(606, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(355, 27);
            comboBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 73);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(340, 77);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 27);
            textBox1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(506, 123);
            label6.Name = "label6";
            label6.Size = new Size(33, 17);
            label6.TabIndex = 5;
            label6.Text = "Зал:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 84);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 1;
            label2.Text = "Описание:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(14, 186);
            button1.Name = "button1";
            button1.Size = new Size(202, 36);
            button1.TabIndex = 20;
            button1.Text = "Сортировать таблицу";
            button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(245, 195);
            label10.Name = "label10";
            label10.Size = new Size(26, 19);
            label10.TabIndex = 20;
            label10.Text = "по";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(289, 191);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(222, 28);
            comboBox2.TabIndex = 20;
            // 
            // Shows
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(991, 731);
            Controls.Add(comboBox2);
            Controls.Add(label10);
            Controls.Add(button1);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)participants_t).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close;
        private Button Back;
        private DataGridView table;
        private GroupBox groupBox1;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button add;
        private Label label4;
        private Label label8;
        private NumericUpDown numericUpDown2;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private Label label9;
        private Label label3;
        private Button button1;
        private Label label10;
        private ComboBox comboBox2;
        private DataGridViewTextBoxColumn Name_;
        private DataGridViewButtonColumn See;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Del;
        private ListBox listBox1;
        private Label label11;
        private TextBox textBox3;
        private Label label5;
        private GroupBox groupBox2;
        private Button button2;
        private DataGridView participants_t;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
    }
}