﻿using System;
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
    public partial class ShowEdit : Form
    {
        public ShowEdit()
        {
            InitializeComponent();
        }

        private void ShowEdit_Deactivate(object sender, EventArgs e)
        {
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {

        }

    }
}