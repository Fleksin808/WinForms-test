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

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            var seznam = new SeznamHerForm(this, databaze);
            this.Hide();
            seznam.Show();           
        }

        private void EditaceButton_Click(object sender, EventArgs e)
        {
            var editace = new EditaceForm(this);
            this.Hide();
            editace.Show();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var vyhledavani = new VyhledavaniForm(this);
            this.Hide();
            vyhledavani.Show();        
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Program se ukonèil...");
            Close();
        }

    }
}
