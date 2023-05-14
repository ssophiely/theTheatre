﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheTheatre.Halls;
using TheTheatre.Models;

namespace TheTheatre
{
    public partial class ShowView : Form
    {
        private Form sh;
        private Form lh;
        private Show _show;

        public ShowView(string name)
        {
            InitializeComponent();
            using (TheTheatreContext db = new TheTheatreContext())
            {
                _show = db.Shows.Include(sh => sh.Roles).Include(sh => sh.TheatreWorkers).
                    Where(sh => sh.ShowName == name).First();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void view_hall_Click(object sender, EventArgs e)
        {
            if (_show.Hall == "Малый")
            {
                sh = new SmallHall();
                sh.Show();
            }
            else
            {
                lh = new LargeHall();
                lh.Show();
            }
        }

        private void ShowView_Load(object sender, EventArgs e)
        {
            sh_name.Text = _show.ShowName;
            duration.Text = _show.Duration.ToString() + " ч";
            minprice.Text = _show.Minprice.ToString() + " руб";
            maxprice.Text = _show.Maxprice.ToString() + " руб";
            description.Text = _show.Description;
            hall.Text = _show.Hall;

            foreach (Role role in _show.Roles)
            {
                roles.Text += $"{role.TheatreWorker.Fullname} - {role.RoleName}" + '\r' + '\n';
            }
        }
    }
}
