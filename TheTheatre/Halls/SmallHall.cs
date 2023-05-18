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

        private void SmallHall_Load(object sender, EventArgs e)
        {

        }
    }
}
