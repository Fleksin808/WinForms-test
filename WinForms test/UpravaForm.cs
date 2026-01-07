namespace WinForms_test
{
    public partial class UpravaForm : Form
    {
        private readonly Databaze databaze;
        public UpravaForm(Databaze databaze)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.databaze = databaze;
        }

        private void ZpetDoEditace_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
