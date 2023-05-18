namespace TheTheatre.Halls
{
    public partial class LargeHall : Form
    {
        public LargeHall()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LargeHall_Deactivate(object sender, EventArgs e)
        {
            Close();
        }

        private void LargeHall_Load(object sender, EventArgs e)
        {

        }
    }
}
