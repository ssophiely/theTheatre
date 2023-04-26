using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTheatre
{
    public partial class People : Form
    {
        public Form ReturnForm;

        public People()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
            ReturnForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnForm.Show();
            this.Close();
        }

        private void People_Load(object sender, EventArgs e)
        {
            table.RowTemplate.MinimumHeight = 35;
            table.Rows.Add("Работник");
            table.Rows.Add("Работник");
            table.Rows.Add("Работник");
            table.Rows.Add("Работник");
            table.Rows.Add("Работник");
            table[0, 0].Selected = false;
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 1)
            {
                new WorkerView().Show();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 2)
            {
                new WorkerEdit().Show();
            }
            else
            {
                // удалить
            }
        }

        private void add_Click(object sender, EventArgs e)
        {

        }
    }
}
