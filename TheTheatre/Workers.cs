using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Workers : Form
    {
        public Form ReturnForm;
        private ThetheatreContext db = new ThetheatreContext();

        public Workers()
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

        private void Workers_Load(object sender, EventArgs e)
        {
            workers_t.RowTemplate.MinimumHeight = 35;
            Table_Update();
        }

        public void Table_Update()
        {
            db = new ThetheatreContext();
            workers_t.Rows.Clear();
            var workers = db.TheatreWorkers.Include(u => u.Position).ToList();
            foreach (TheatreWorker w in workers)
            {
                workers_t.Rows.Add(w.Fullname, w.Position.PosName, w.Experience);
            }
            if (workers_t.Rows.Count > 0)
            {
                workers_t[0, 0].Selected = false;
            }
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 3)
            {
                new WorkerEdit(2) { ReturnForm = this }.Show();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 4)
            {
                var worker = db.TheatreWorkers.Where(w => w.TheatreWorkerId == e.RowIndex + 1).First();
                db.TheatreWorkers.Remove(worker);
                db.SaveChanges();
                Table_Update();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (fullname_tb.Text == "" || position_cb.Text == "")
            {
                MessageBox.Show(
                       "Заполните все поля",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            string fn = fullname_tb.Text;
            int experience = (int)workexp_nud.Value;
            int positionId = position_cb.SelectedIndex + 1;

            db.TheatreWorkers.Add(new TheatreWorker { Fullname = fn, Experience = experience, PositionId = positionId });
            db.SaveChanges();
            Table_Update();
        }


    }
}
