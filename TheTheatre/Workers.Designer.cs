namespace TheTheatre
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            workers_t = new DataGridView();
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
            filter_cb = new ComboBox();
            Filter = new Button();
            find_tb = new TextBox();
            Find = new Button();
            Reset = new Button();
            filterl = new Label();
            findl = new Label();
            Name_ = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Experience = new DataGridViewTextBoxColumn();
            roles = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            Del = new DataGridViewButtonColumn();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            workers_t.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            workers_t.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            workers_t.BackgroundColor = Color.White;
            workers_t.BorderStyle = BorderStyle.None;
            workers_t.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            workers_t.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            workers_t.ColumnHeadersHeight = 35;
            workers_t.Columns.AddRange(new DataGridViewColumn[] { Name_, Position, ID, Experience, roles, Edit, Del });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(255, 253, 242);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            workers_t.DefaultCellStyle = dataGridViewCellStyle10;
            workers_t.Dock = DockStyle.Top;
            workers_t.EnableHeadersVisualStyles = false;
            workers_t.Location = new Point(0, 0);
            workers_t.Name = "workers_t";
            workers_t.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            workers_t.RowHeadersVisible = false;
            workers_t.RowHeadersWidth = 70;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            workers_t.RowsDefaultCellStyle = dataGridViewCellStyle11;
            workers_t.RowTemplate.Height = 29;
            workers_t.ShowCellToolTips = false;
            workers_t.Size = new Size(1119, 176);
            workers_t.TabIndex = 10;
            workers_t.CellContentClick += table_CellContentClick;
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
            groupBox1.Location = new Point(12, 273);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1095, 224);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить сотрудника театра";
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
            worker_add.Location = new Point(953, 182);
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
            position_cb.Size = new Size(621, 27);
            position_cb.TabIndex = 9;
            // 
            // fullname_tb
            // 
            fullname_tb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            fullname_tb.Location = new Point(198, 42);
            fullname_tb.Name = "fullname_tb";
            fullname_tb.Size = new Size(621, 27);
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
            Close.Location = new Point(965, 503);
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
            button1.Location = new Point(823, 503);
            button1.Name = "button1";
            button1.Size = new Size(136, 36);
            button1.TabIndex = 4;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // filter_cb
            // 
            filter_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            filter_cb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            filter_cb.FormattingEnabled = true;
            filter_cb.Items.AddRange(new object[] { "Режиссер-постановщик", "Актер", "Звукорежиссер", "Художник" });
            filter_cb.Location = new Point(18, 190);
            filter_cb.Name = "filter_cb";
            filter_cb.Size = new Size(225, 27);
            filter_cb.TabIndex = 12;
            // 
            // Filter
            // 
            Filter.BackColor = Color.FromArgb(253, 219, 109);
            Filter.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Filter.Location = new Point(249, 184);
            Filter.Name = "Filter";
            Filter.Size = new Size(136, 36);
            Filter.TabIndex = 12;
            Filter.Text = "Фильтровать";
            Filter.UseVisualStyleBackColor = false;
            Filter.Click += Filter_Click;
            // 
            // find_tb
            // 
            find_tb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            find_tb.Location = new Point(616, 196);
            find_tb.Name = "find_tb";
            find_tb.Size = new Size(349, 27);
            find_tb.TabIndex = 13;
            // 
            // Find
            // 
            Find.BackColor = Color.FromArgb(253, 219, 109);
            Find.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Find.Location = new Point(971, 190);
            Find.Name = "Find";
            Find.Size = new Size(136, 36);
            Find.TabIndex = 14;
            Find.Text = "Найти";
            Find.UseVisualStyleBackColor = false;
            Find.Click += Find_Click;
            // 
            // Reset
            // 
            Reset.BackColor = Color.Black;
            Reset.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Reset.ForeColor = Color.White;
            Reset.Location = new Point(971, 229);
            Reset.Name = "Reset";
            Reset.Size = new Size(136, 36);
            Reset.TabIndex = 16;
            Reset.Text = "Сбросить";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // filterl
            // 
            filterl.AutoSize = true;
            filterl.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            filterl.ForeColor = Color.OliveDrab;
            filterl.Location = new Point(19, 220);
            filterl.Name = "filterl";
            filterl.Size = new Size(0, 17);
            filterl.TabIndex = 17;
            // 
            // findl
            // 
            findl.AutoSize = true;
            findl.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            findl.ForeColor = Color.OliveDrab;
            findl.Location = new Point(616, 226);
            findl.Name = "findl";
            findl.Size = new Size(0, 17);
            findl.TabIndex = 18;
            // 
            // Name_
            // 
            Name_.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            Name_.DefaultCellStyle = dataGridViewCellStyle3;
            Name_.DividerWidth = 1;
            Name_.FillWeight = 340F;
            Name_.HeaderText = "ФИО";
            Name_.MinimumWidth = 6;
            Name_.Name = "Name_";
            // 
            // Position
            // 
            Position.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            Position.DefaultCellStyle = dataGridViewCellStyle4;
            Position.DividerWidth = 1;
            Position.FillWeight = 170F;
            Position.HeaderText = "Должность";
            Position.MinimumWidth = 6;
            Position.Name = "Position";
            // 
            // ID
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            ID.DefaultCellStyle = dataGridViewCellStyle5;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 125;
            // 
            // Experience
            // 
            Experience.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            Experience.DefaultCellStyle = dataGridViewCellStyle6;
            Experience.DividerWidth = 1;
            Experience.FillWeight = 70F;
            Experience.HeaderText = "Стаж";
            Experience.MinimumWidth = 6;
            Experience.Name = "Experience";
            // 
            // roles
            // 
            roles.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 253, 242);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 253, 242);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            roles.DefaultCellStyle = dataGridViewCellStyle7;
            roles.DividerWidth = 1;
            roles.FillWeight = 80F;
            roles.FlatStyle = FlatStyle.Popup;
            roles.HeaderText = "";
            roles.MinimumWidth = 6;
            roles.Name = "roles";
            roles.Text = "Роли";
            roles.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.Lavender;
            dataGridViewCellStyle8.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            Edit.DefaultCellStyle = dataGridViewCellStyle8;
            Edit.DividerWidth = 1;
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
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.Plum;
            dataGridViewCellStyle9.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            Del.DefaultCellStyle = dataGridViewCellStyle9;
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
            // Workers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1119, 551);
            Controls.Add(findl);
            Controls.Add(filterl);
            Controls.Add(Reset);
            Controls.Add(Find);
            Controls.Add(find_tb);
            Controls.Add(Filter);
            Controls.Add(filter_cb);
            Controls.Add(groupBox1);
            Controls.Add(workers_t);
            Controls.Add(Close);
            Controls.Add(button1);
            Name = "Workers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сотрудники театра";
            Load += Workers_Load;
            ((System.ComponentModel.ISupportInitialize)workers_t).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)workexp_nud).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox filter_cb;
        private Button Filter;
        private TextBox find_tb;
        private Button Find;
        private Button Reset;
        private Label filterl;
        private Label findl;
        private DataGridViewTextBoxColumn Name_;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Experience;
        private DataGridViewButtonColumn roles;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Del;
    }
}