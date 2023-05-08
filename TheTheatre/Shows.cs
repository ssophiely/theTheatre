using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheTheatre.Models;

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
            table.RowTemplate.MinimumHeight = 35;
            table.Rows.Add("Спеееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееееектакль");
            table.Rows.Add("Спектакль");
            table.Rows.Add("Спектакль");
            table.Rows.Add("Спектакль");
            table.Rows.Add("Спектакль");
            table[0, 0].Selected = false;

            inshow_t.RowTemplate.MinimumHeight = 25;
            allworkers_t.RowTemplate.MinimumHeight = 25;
            Allworkers_Update();

        }

        public void Allworkers_Update()
        {
            using (ThetheatreContext db = new ThetheatreContext())
            {
                allworkers_t.Rows.Clear();
                var list = inshow_t.Rows.Cast<DataGridViewRow>().Select(r => Convert.ToInt32(r.Cells[2].Value)).ToList();
                var workers = db.TheatreWorkers.Include(u => u.Position).ToList();
                foreach (TheatreWorker w in workers)
                {
                    if (!list.Contains(w.TheatreWorkerId))
                        allworkers_t.Rows.Add(w.Fullname, w.Position.PosName, w.TheatreWorkerId);
                }
            }
            if (allworkers_t.Rows.Count > 0)
            {
                allworkers_t[0, 0].Selected = false;
            }
        }

        public void InShow_AddRow(string name, string role, int id)
        {
            inshow_t.Rows.Add(name, role, id);
            Allworkers_Update();
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

        private void allworkers_t_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 3)
            {
                new EnterRole(Convert.ToInt32(allworkers_t[2, e.RowIndex].Value),
                    allworkers_t[0, e.RowIndex].Value.ToString())
                { ReturnForm = this }.ShowDialog();
            }
        }

        private void inshow_t_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               e.ColumnIndex == 3)
            {
                inshow_t.Rows.RemoveAt(e.RowIndex);
            }
            Allworkers_Update();
        }
    }
}
