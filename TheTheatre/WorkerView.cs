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
    public partial class WorkerView : Form
    {
        public Form ReturnForm;
        private int _id;
        public WorkerView(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void WorkerView_Deactivate(object sender, EventArgs e)
        {
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WorkerView_Load(object sender, EventArgs e)
        {
            using (TheTheatreContext db = new TheTheatreContext())
            {
                TheatreWorker worker = db.TheatreWorkers.Include(w => w.Roles).Where(w => w.TheatreWorkerId == _id).First();
                w_name.Text = worker.Fullname;
                foreach (Role role in worker.Roles)
                {
                    roles.Text += $"{role.RoleName} - {role.ShowName}" + '\r' + '\n';
                }
            }
        }
    }
}
