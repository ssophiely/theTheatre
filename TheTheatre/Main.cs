using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;

namespace TheTheatre
{
    public partial class Main : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        public static extern IntPtr MessageBox(int hWnd, String text,
                              String caption, uint type);

        public Main()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Shows_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Shows() { ReturnForm = this }.Show();
        }

        private void People_Click(object sender, EventArgs e)
        {
            this.Hide();
            new People() { ReturnForm = this }.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            using (ThetheatreContext db = new ThetheatreContext())
            {

            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            new Info().ShowDialog();
        }
    }
}