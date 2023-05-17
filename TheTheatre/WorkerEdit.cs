using Microsoft.EntityFrameworkCore;
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
    public partial class WorkerEdit : Form
    {
        private TheTheatreContext db = new TheTheatreContext();
        private TheatreWorker _worker;
        public Workers ReturnForm;
        public WorkerEdit(int ID)
        {
            InitializeComponent();
            _worker = db.TheatreWorkers.Include(w => w.Position).Where(w => w.TheatreWorkerId == ID).First(); 
        }

        private void WorkerEdit_Deactivate(object sender, EventArgs e)
        {
            Close();
        }

        private void WorkerEdit_Load(object sender, EventArgs e)
        {
            fullname.Text = _worker.Fullname;
            position.Text = _worker.Position.PosName;
            experience.Value = (decimal)_worker.Experience;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (fullname.Text != _worker.Fullname)
            {
                _worker.Fullname = fullname.Text;
                db.SaveChanges();
            }
            if (position.Text != _worker.Position.PosName)
            {
                _worker.PositionId = position.SelectedIndex + 1;
                db.SaveChanges();
            }
            if (experience.Value != _worker.Experience)
            {
                _worker.Experience = (int?)experience.Value;
                db.SaveChanges();
            }
            ReturnForm.Table_Update();
            MessageBox.Show(
                     $"Данные о сотруднике {_worker.Fullname} отредактированы",
                     "Информация",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button1,
                     MessageBoxOptions.DefaultDesktopOnly);
            this.Activate();
            Close();
        }
    }
}
