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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            Close = new Button();
            Back = new Button();
            table = new DataGridView();
            Name_ = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            See = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            Del = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            allworkers_t = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            inshow_t = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            max_price = new NumericUpDown();
            min_price = new NumericUpDown();
            label9 = new Label();
            label3 = new Label();
            label8 = new Label();
            add = new Button();
            minutes = new NumericUpDown();
            label7 = new Label();
            hour = new NumericUpDown();
            label4 = new Label();
            hall = new ComboBox();
            discription = new TextBox();
            show_name = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allworkers_t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inshow_t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)max_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)min_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hour).BeginInit();
            SuspendLayout();
            // 
            // Close
            // 
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Close.ForeColor = Color.White;
            Close.Location = new Point(989, 630);
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
            Back.Location = new Point(847, 630);
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
            table.Columns.AddRange(new DataGridViewColumn[] { Name_, id, See, Edit, Del });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            table.DefaultCellStyle = dataGridViewCellStyle8;
            table.Dock = DockStyle.Top;
            table.Location = new Point(0, 0);
            table.Name = "table";
            table.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            table.RowHeadersVisible = false;
            table.RowHeadersWidth = 70;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            table.RowsDefaultCellStyle = dataGridViewCellStyle9;
            table.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            table.RowTemplate.Height = 50;
            table.ShowCellToolTips = false;
            table.Size = new Size(1137, 176);
            table.TabIndex = 7;
            table.CellContentClick += table_CellContentClick;
            // 
            // Name_
            // 
            Name_.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Name_.DefaultCellStyle = dataGridViewCellStyle3;
            Name_.FillWeight = 320F;
            Name_.HeaderText = "Название";
            Name_.MinimumWidth = 6;
            Name_.Name = "Name_";
            Name_.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // id
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            id.DefaultCellStyle = dataGridViewCellStyle4;
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            id.Width = 6;
            // 
            // See
            // 
            See.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.LightYellow;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightYellow;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            See.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Lavender;
            dataGridViewCellStyle6.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            Edit.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Plum;
            dataGridViewCellStyle7.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            Del.DefaultCellStyle = dataGridViewCellStyle7;
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
            groupBox1.Controls.Add(max_price);
            groupBox1.Controls.Add(min_price);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(add);
            groupBox1.Controls.Add(minutes);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(hour);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(hall);
            groupBox1.Controls.Add(discription);
            groupBox1.Controls.Add(show_name);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1113, 427);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить спектакль";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(allworkers_t);
            groupBox2.Controls.Add(inshow_t);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(6, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1101, 207);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавить участника спектакля";
            // 
            // allworkers_t
            // 
            allworkers_t.AllowDrop = true;
            allworkers_t.AllowUserToAddRows = false;
            allworkers_t.AllowUserToDeleteRows = false;
            allworkers_t.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            allworkers_t.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            allworkers_t.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allworkers_t.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            allworkers_t.BackgroundColor = Color.White;
            allworkers_t.BorderStyle = BorderStyle.None;
            allworkers_t.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            allworkers_t.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            allworkers_t.ColumnHeadersHeight = 25;
            allworkers_t.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewButtonColumn1 });
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            allworkers_t.DefaultCellStyle = dataGridViewCellStyle15;
            allworkers_t.Location = new Point(6, 24);
            allworkers_t.Name = "allworkers_t";
            allworkers_t.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            allworkers_t.RowHeadersVisible = false;
            allworkers_t.RowHeadersWidth = 70;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            allworkers_t.RowsDefaultCellStyle = dataGridViewCellStyle16;
            allworkers_t.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            allworkers_t.RowTemplate.Height = 50;
            allworkers_t.ShowCellToolTips = false;
            allworkers_t.Size = new Size(544, 175);
            allworkers_t.TabIndex = 26;
            allworkers_t.CellContentClick += allworkers_t_CellContentClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.SelectionBackColor = Color.White;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewTextBoxColumn2.DividerWidth = 1;
            dataGridViewTextBoxColumn2.FillWeight = 220F;
            dataGridViewTextBoxColumn2.HeaderText = "Имя";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DividerWidth = 1;
            dataGridViewTextBoxColumn3.FillWeight = 160F;
            dataGridViewTextBoxColumn3.HeaderText = "Должность";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewTextBoxColumn4.HeaderText = "ID";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Visible = false;
            dataGridViewTextBoxColumn4.Width = 54;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.Plum;
            dataGridViewCellStyle14.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewButtonColumn1.DividerWidth = 1;
            dataGridViewButtonColumn1.FillWeight = 120F;
            dataGridViewButtonColumn1.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn1.HeaderText = "";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn1.Text = "Добавить роль";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // inshow_t
            // 
            inshow_t.AllowDrop = true;
            inshow_t.AllowUserToAddRows = false;
            inshow_t.AllowUserToDeleteRows = false;
            inshow_t.AllowUserToOrderColumns = true;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            inshow_t.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            inshow_t.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            inshow_t.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            inshow_t.BackgroundColor = Color.White;
            inshow_t.BorderStyle = BorderStyle.None;
            inshow_t.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = SystemColors.Control;
            dataGridViewCellStyle18.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            inshow_t.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            inshow_t.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inshow_t.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, role, dataGridViewTextBoxColumn5, dataGridViewButtonColumn3 });
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = SystemColors.Window;
            dataGridViewCellStyle22.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            inshow_t.DefaultCellStyle = dataGridViewCellStyle22;
            inshow_t.Location = new Point(579, 24);
            inshow_t.Name = "inshow_t";
            inshow_t.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            inshow_t.RowHeadersVisible = false;
            inshow_t.RowHeadersWidth = 70;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Font = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            inshow_t.RowsDefaultCellStyle = dataGridViewCellStyle23;
            inshow_t.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            inshow_t.RowTemplate.Height = 50;
            inshow_t.ShowCellToolTips = false;
            inshow_t.Size = new Size(522, 177);
            inshow_t.TabIndex = 21;
            inshow_t.CellContentClick += inshow_t_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.SelectionBackColor = Color.White;
            dataGridViewCellStyle19.SelectionForeColor = Color.Black;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewTextBoxColumn1.DividerWidth = 1;
            dataGridViewTextBoxColumn1.FillWeight = 180F;
            dataGridViewTextBoxColumn1.HeaderText = "Участник";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // role
            // 
            role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            role.DividerWidth = 1;
            role.FillWeight = 200F;
            role.HeaderText = "Роль";
            role.MinimumWidth = 6;
            role.Name = "role";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle20.Format = "N0";
            dataGridViewCellStyle20.NullValue = null;
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewTextBoxColumn5.HeaderText = "ID";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Visible = false;
            dataGridViewTextBoxColumn5.Width = 54;
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = Color.Plum;
            dataGridViewCellStyle21.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle21.SelectionForeColor = Color.Black;
            dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewButtonColumn3.DividerWidth = 1;
            dataGridViewButtonColumn3.FillWeight = 80F;
            dataGridViewButtonColumn3.FlatStyle = FlatStyle.Popup;
            dataGridViewButtonColumn3.HeaderText = "";
            dataGridViewButtonColumn3.MinimumWidth = 6;
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            dataGridViewButtonColumn3.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn3.Text = "Удалить";
            dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            // 
            // max_price
            // 
            max_price.Location = new Point(1000, 74);
            max_price.Name = "max_price";
            max_price.Size = new Size(107, 25);
            max_price.TabIndex = 19;
            // 
            // min_price
            // 
            min_price.Location = new Point(736, 74);
            min_price.Name = "min_price";
            min_price.Size = new Size(97, 25);
            min_price.TabIndex = 18;
            // 
            // label9
            // 
            label9.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(891, 71);
            label9.Name = "label9";
            label9.Size = new Size(103, 40);
            label9.TabIndex = 17;
            label9.Text = "Максимальная цена билета:";
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(585, 74);
            label3.Name = "label3";
            label3.Size = new Size(94, 37);
            label3.TabIndex = 16;
            label3.Text = "Минимальная цена билета:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(972, 40);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 15;
            label8.Text = "мин";
            // 
            // add
            // 
            add.BackColor = Color.Violet;
            add.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(971, 385);
            add.Name = "add";
            add.Size = new Size(136, 36);
            add.TabIndex = 9;
            add.Text = "Создать";
            add.UseVisualStyleBackColor = false;
            // 
            // minutes
            // 
            minutes.Location = new Point(891, 30);
            minutes.Name = "minutes";
            minutes.Size = new Size(75, 25);
            minutes.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(817, 38);
            label7.Name = "label7";
            label7.Size = new Size(16, 17);
            label7.TabIndex = 13;
            label7.Text = "ч";
            // 
            // hour
            // 
            hour.Location = new Point(736, 30);
            hour.Name = "hour";
            hour.Size = new Size(75, 25);
            hour.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(585, 34);
            label4.Name = "label4";
            label4.Size = new Size(138, 17);
            label4.TabIndex = 11;
            label4.Text = "Продолжительность:";
            // 
            // hall
            // 
            hall.BackColor = Color.White;
            hall.DropDownStyle = ComboBoxStyle.DropDownList;
            hall.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hall.FormattingEnabled = true;
            hall.Items.AddRange(new object[] { "Малый", "Большой" });
            hall.Location = new Point(685, 127);
            hall.Name = "hall";
            hall.Size = new Size(422, 25);
            hall.TabIndex = 9;
            // 
            // discription
            // 
            discription.Location = new Point(120, 73);
            discription.Multiline = true;
            discription.Name = "discription";
            discription.Size = new Size(436, 77);
            discription.TabIndex = 8;
            // 
            // show_name
            // 
            show_name.Location = new Point(120, 33);
            show_name.Name = "show_name";
            show_name.Size = new Size(436, 25);
            show_name.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(585, 124);
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
            // Shows
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1137, 669);
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
            ((System.ComponentModel.ISupportInitialize)allworkers_t).EndInit();
            ((System.ComponentModel.ISupportInitialize)inshow_t).EndInit();
            ((System.ComponentModel.ISupportInitialize)max_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)min_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)hour).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Close;
        private Button Back;
        private DataGridView table;
        private GroupBox groupBox1;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox show_name;
        private TextBox discription;
        private ComboBox hall;
        private Button add;
        private Label label4;
        private Label label8;
        private NumericUpDown minutes;
        private Label label7;
        private NumericUpDown hour;
        private NumericUpDown max_price;
        private NumericUpDown min_price;
        private Label label9;
        private Label label3;
        private GroupBox groupBox2;
        private DataGridView inshow_t;
        private DataGridViewTextBoxColumn Name_;
        private DataGridViewTextBoxColumn id;
        private DataGridViewButtonColumn See;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Del;
        private DataGridView allworkers_t;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}