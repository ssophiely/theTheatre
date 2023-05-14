using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTheatre.Halls
{
    public partial class SmallHall : Form
    {
        public SmallHall()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SmallHall_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
    }
}
