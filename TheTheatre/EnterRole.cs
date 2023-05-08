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
    public partial class EnterRole : Form
    {
        public Shows ReturnForm;
        private int _id;
        private string _name;

        public EnterRole(int id, string name)
        {
            InitializeComponent();
            _name = name;
            _id = id;
        }

        private void Enter_role_Click(object sender, EventArgs e)
        {
            if (role.Text == "")
            {
                MessageBox.Show(
                       "Заполните поле",
                       "Ошибка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            string roleName = role.Text;
            ReturnForm.InShow_AddRow(_name, roleName, _id);
            Close();
        }
    }
}
