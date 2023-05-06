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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            (sender as System.Windows.Forms.Timer).Enabled = false;
            this.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Info_Shown(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer() { Interval = 5000, Enabled = true };
            timer.Tick += new EventHandler(timer_Tick);
        }
    }
}
