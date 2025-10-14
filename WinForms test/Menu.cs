namespace WinForms_test
{
    public partial class Menu : Form
    {
        public Menu()
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
            var seznam = new SeznamHerForm(this);
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
            Console.WriteLine("[r] - Pro vyhledání hry podle roku vydání");
            Console.WriteLine("[d] - Pro vyhledání hry podle vývojáøského studia");
            Console.WriteLine("[z] - Pro vyhledání hry podle žánru");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Program se ukonèil...");
            Close();
        }

    }
}
