namespace WinForms_test
{
    public partial class MainMenu : Form
    {
        private readonly Databaze databaze = new();
        public MainMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // Spustí okno na celou obrazovku
            this.FormClosing += MainMenuFormClosing; // Pøidá událost pro potvrzení ukonèení aplikace
        }

        private void StartButton_Click(object sender, EventArgs e) // Otevøe formuláø se seznamem her a skryje hlavní menu
        {
            var seznam = new SeznamHerForm(this, databaze);
            this.Hide();
            seznam.Show();
        }

        private void EditaceButton_Click(object sender, EventArgs e) // Otevøe formuláø pro editaci her a skryje hlavní menu
        {
            var editace = new EditaceForm(this, databaze);
            this.Hide();
            editace.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e) // Ukonèí program
        {
            Console.WriteLine("Program se ukonèil...");
            Close();
        }

        private void MainMenuFormClosing(object? sender, FormClosingEventArgs e) // Metoda na potvrzení ukonèení aplikace
        {
            var potvrzeni = MessageBox.Show(
                "Opravdu chcete ukonèit aplikaci?",
                "Ukonèení",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (potvrzeni == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
