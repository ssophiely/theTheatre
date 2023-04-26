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

namespace TheTheatre
{
    public partial class ShowView : Form
    {
        private Form sh;
        private Form lh;
        public ShowView()
        {
            InitializeComponent();
        }

        private void ShowView_Deactivate(object sender, EventArgs e)
        {
            if (sh == null && lh == null)
                Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void view_hall_Click(object sender, EventArgs e)
        {
            lh = new LargeHall();
            lh.Show();
        }
    }
}
