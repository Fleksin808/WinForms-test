namespace WinForms_test
{
    public partial class MainMenu : Form
    {
        private readonly Databaze databaze = new();
        public MainMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var seznam = new SeznamHerForm(this, databaze);
            this.Hide();
            seznam.Show();
        }

        private void EditaceButton_Click(object sender, EventArgs e)
        {
            var editace = new EditaceForm(this, databaze);
            this.Hide();
            editace.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Program se ukonèil...");
            Close();
        }

    }
}
