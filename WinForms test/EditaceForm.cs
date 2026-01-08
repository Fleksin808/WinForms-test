using System.Data;

namespace WinForms_test
{
    public partial class EditaceForm : Form
    {
        private readonly MainMenu hlavniMenu;
        private readonly Databaze databaze;
        private readonly BindingSource zdroj = new BindingSource();

        public EditaceForm(MainMenu menu, Databaze databaze)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            hlavniMenu = menu;
            this.databaze = databaze;
        }

        private void EditaceForm_Load(object sender, EventArgs e)
        {
            ZobrazeniProEditaci.AutoGenerateColumns = false;
            ZobrazeniProEditaci.ReadOnly = true;
            ZobrazeniProEditaci.AllowUserToAddRows = false;
            ZobrazeniProEditaci.AllowUserToDeleteRows = false;
            ZobrazeniProEditaci.MultiSelect = false;
            ZobrazeniProEditaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ZobrazeniProEditaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            zdroj.DataSource = databaze.Hry;
            ZobrazeniProEditaci.DataSource = zdroj;

            ZobrazeniProEditaci.Columns["id"].DataPropertyName = "Id";
            ZobrazeniProEditaci.Columns["hra"].DataPropertyName = "NazevHry";
            ZobrazeniProEditaci.Columns["zanr"].DataPropertyName = "Zanr";
            ZobrazeniProEditaci.Columns["studio"].DataPropertyName = "VyvojarskeStudio";
            ZobrazeniProEditaci.Columns["rokVydani"].DataPropertyName = "RokVydani";
            ZobrazeniProEditaci.Columns["achievementSplnene"].DataPropertyName = "AchievementySplnene";
            ZobrazeniProEditaci.Columns["achievementCelkem"].DataPropertyName = "AchievementyCelkem";
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ZpetButton_Click(object sender, EventArgs e)
        {
            hlavniMenu.Show();
            this.Close();
        }

        private void TextBoxFiltrace_TextChanged(object sender, EventArgs e)
        {
            var hledanyText = TextBoxFiltrace.Text.Trim();

            if (string.IsNullOrEmpty(hledanyText))
            {
                zdroj.DataSource = databaze.Hry;
                return;
            }
            var filtrovane = databaze.Hry.Where(h => h.NazevHry.Contains(hledanyText, StringComparison.CurrentCultureIgnoreCase)).ToList();

            zdroj.DataSource = filtrovane;
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            var pridaniForm = new PridaniForm(databaze);
            pridaniForm.ShowDialog(this);
        }

        private void DeleteGameButton_Click(object sender, EventArgs e)
        {
            var hra = ZobrazeniProEditaci.CurrentRow?.DataBoundItem as Hra;
            if (hra == null)
            {
                MessageBox.Show("Vyber hru, kterou chceš odebrat.");
                return;
            }

            var potvrzeni = MessageBox.Show($"Opravdu chceš odebrat hru \"{hra.NazevHry}\"?", "Potvrzení",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (potvrzeni == DialogResult.Yes)
            {
                databaze.SmazatHru(hra);
            }
        }

        private void EditGameButton_Click(object sender, EventArgs e)
        {
            var hra = ZobrazeniProEditaci.CurrentRow?.DataBoundItem as Hra;
            if (hra == null)
            {
                MessageBox.Show("Vyber hru, kterou chceš upravit.");
                return;
            }
            // Dialog je vytvořen v using bloku, aby se po zavření korektně uvolnily systémové prostředky (Dispose).
            using var upravaForm = new UpravaForm(databaze, hra);
            var vysledek = upravaForm.ShowDialog(this);
            // Po uložení (OK) obnovíme BindingSource, aby se zobrazil správně i při filtrování
            if (vysledek == DialogResult.OK)
            {
                zdroj.ResetBindings(false);
            }
        }
    }
}
