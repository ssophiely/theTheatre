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
    public partial class WorkerEdit : Form
    {
        public WorkerEdit()
        {
            InitializeComponent();
        }

        private void WorkerEdit_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
    }
}
