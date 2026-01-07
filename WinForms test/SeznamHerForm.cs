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

        private void ZpetDoMenuButton_Click(object sender, EventArgs e)
        {
            hlavniMenu.Show();
            this.Close();
        }

        private void ZobrazeniZaznamuHer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SeznamHerForm_Load(object sender, EventArgs e)
        {
            // Nastavení DataGridView pro zobrazení dat
            ZobrazeniZaznamuHer.AutoGenerateColumns = false;
            ZobrazeniZaznamuHer.DataSource = databaze.Hry;
            ZobrazeniZaznamuHer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ZobrazeniZaznamuHer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Zakázat úpravy přímo v DataGridView ve formě přímého psaní do buněk
            ZobrazeniZaznamuHer.ReadOnly = true;
            ZobrazeniZaznamuHer.AutoGenerateColumns = false;
            ZobrazeniZaznamuHer.AllowUserToAddRows = false;
            ZobrazeniZaznamuHer.AllowUserToDeleteRows = false;
            ZobrazeniZaznamuHer.MultiSelect = false;

            // vytvořit exception pro případ, že tabulka je prázdná
            ZobrazeniZaznamuHer.Columns["id"].DataPropertyName = "Id";
            ZobrazeniZaznamuHer.Columns["hra"].DataPropertyName = "NazevHry";
            ZobrazeniZaznamuHer.Columns["zanr"].DataPropertyName = "Zanr";
            ZobrazeniZaznamuHer.Columns["studio"].DataPropertyName = "VyvojarskeStudio";
            ZobrazeniZaznamuHer.Columns["rokVydani"].DataPropertyName = "RokVydani";
            ZobrazeniZaznamuHer.Columns["achievementSplnene"].DataPropertyName = "AchievementySplnene";
            ZobrazeniZaznamuHer.Columns["achievementCelkem"].DataPropertyName = "AchievementyCelkem";
        }
    }
}
