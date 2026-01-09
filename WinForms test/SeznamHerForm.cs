namespace WinForms_test
{
    public partial class SeznamHerForm : Form
    {

        private readonly MainMenu hlavniMenu;
        private readonly Databaze databaze;
        public SeznamHerForm(MainMenu menu, Databaze databaze)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            hlavniMenu = menu;
            this.databaze = databaze;
        }
        private void SeznamHerForm_Load(object sender, EventArgs e)
        {
            NastavovacGridu.NastavSloupecProHry(ZobrazeniZaznamuHer);
            NastavGridView();
            ZobrazeniZaznamuHer.DataSource = databaze.Hry;
        }

        private void ZpetDoMenuButton_Click(object sender, EventArgs e)
        {
            hlavniMenu.Show();
            this.Close();
        }


        private void NastavGridView()
        {
            // Nastavení DataGridView pro zobrazení dat
            ZobrazeniZaznamuHer.AutoGenerateColumns = false;
            ZobrazeniZaznamuHer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ZobrazeniZaznamuHer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Zakázat úpravy přímo v DataGridView ve formě přímého psaní do buněk
            ZobrazeniZaznamuHer.ReadOnly = true;
            ZobrazeniZaznamuHer.AutoGenerateColumns = false;
            ZobrazeniZaznamuHer.AllowUserToAddRows = false;
            ZobrazeniZaznamuHer.AllowUserToDeleteRows = false;
            ZobrazeniZaznamuHer.MultiSelect = false;
        }
    }
}
