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
            using (TheTheatreContext db = new TheTheatreContext())
            {
                workers_t.Rows.Clear();
                var workers = db.TheatreWorkers.Include(u => u.Position).ToList();
                foreach (TheatreWorker w in workers)
                {
                    workers_t.Rows.Add(w.Fullname, w.Position.PosName, w.TheatreWorkerId, w.Experience);
                }
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
                e.ColumnIndex == 4)
            {
                new WorkerView(Convert.ToInt32(workers_t[2, e.RowIndex].Value)) { ReturnForm = this }.ShowDialog();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 5)
            {
                new WorkerEdit(Convert.ToInt32(workers_t[2, e.RowIndex].Value)) { ReturnForm = this }.ShowDialog();
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.ColumnIndex == 6)
            {
                using (TheTheatreContext db = new TheTheatreContext())
                {
                    var worker = db.TheatreWorkers.Where(w => w.TheatreWorkerId ==
                    Convert.ToInt32(workers_t[2, e.RowIndex].Value)).First();
                    db.TheatreWorkers.Remove(worker);
                    db.SaveChanges();
                    Table_Update();
                    MessageBox.Show(
                      $"Сотрудник {worker.Fullname} удален",
                      "Информация",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information,
                      MessageBoxDefaultButton.Button1,
                      MessageBoxOptions.DefaultDesktopOnly);
                    this.Activate();
                }
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
                this.Activate();
                return;
            }
            string fn = fullname_tb.Text;
            int experience = (int)workexp_nud.Value;
            int positionId = position_cb.SelectedIndex + 1;

            using (TheTheatreContext db = new TheTheatreContext())
            {
                db.TheatreWorkers.Add(new TheatreWorker { Fullname = fn, Experience = experience, PositionId = positionId });
                db.SaveChanges();
            }
            Table_Update();
            position_cb.SelectedIndex = -1;
            fullname_tb.Text = "";
            workexp_nud.Value = 0;
            MessageBox.Show(
                       $"Создан новый сотрудник - {fn}",
                       "Информация",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
            this.Activate();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            filter_cb.SelectedIndex = -1;
            find_tb.Text = "";
            findl.Text = "";
            filterl.Text = "";
            Table_Update();
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            string filter = filter_cb.Text;
            if (filter == "")
            {
                MessageBox.Show(
                       "Заполните поле",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
                this.Activate();
                return;
            };
            List<DataGridViewRow> list = new List<DataGridViewRow>();
            for (int i = 0; i < workers_t.Rows.Count; i++)
            {
                if (workers_t.Rows[i].Cells[1].Value.ToString() == filter)
                    list.Add(workers_t.Rows[i]);
            }
            workers_t.Rows.Clear();
            foreach (DataGridViewRow row in list)
            {
                workers_t.Rows.Add(row);
            }
            filterl.Text = $"Применен фильтр. Найдено совпадений: {workers_t.Rows.Count}";
        }

        private void Find_Click(object sender, EventArgs e)
        {
            string find = find_tb.Text;
            if (find == "")
            {
                MessageBox.Show(
                       "Заполните поле",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
                this.Activate();
                return;
            };
            List<DataGridViewRow> list = new List<DataGridViewRow>();
            for (int i = 0; i < workers_t.Rows.Count; i++)
            {
                if (workers_t.Rows[i].Cells[0].Value.ToString().ToLower().Contains(find.ToLower())
                    || workers_t.Rows[i].Cells[3].Value.ToString().Contains(find))
                    list.Add(workers_t.Rows[i]);
            }
            workers_t.Rows.Clear();
            foreach (DataGridViewRow row in list)
            {
                workers_t.Rows.Add(row);
            }
            findl.Text = $"Применен поиск. Найдено совпадений: {workers_t.Rows.Count}";
        }
    }
}
