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
    public partial class Shows : Form
    {
        public Form ReturnForm;

        public Shows()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
            ReturnForm.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            ReturnForm.Show();
            this.Close();
        }

        private void Shows_Load(object sender, EventArgs e)
        {
            //this.table.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            table.RowTemplate.MinimumHeight = 35;
            table.Rows.Add("Спеееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееектакль");
            table.Rows.Add("Спектакль");
            table.Rows.Add("Спектакль");
            table.Rows.Add("Спектакль");
            table.Rows.Add("Спектакль");
            table[0, 0].Selected = false;
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 1)
            {
                new ShowView().Show();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 2)
            {
                new ShowEdit().Show();
            }
            else
            {
                // удалить
            }
        }
    }
}
