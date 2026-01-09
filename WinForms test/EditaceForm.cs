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
            NastavovacGridu.NastavSloupecProHry(ZobrazeniProEditaci);
            NastavDataGrid();
            zdroj.DataSource = databaze.Hry;
            ZobrazeniProEditaci.DataSource = zdroj;
        }

        private void ZpetButton_Click(object sender, EventArgs e) // Návrat do hlavního menu
        {
            hlavniMenu.Show();
            this.Close();
        }

        private void TextBoxFiltrace_TextChanged(object sender, EventArgs e) // Filtrace her podle názvu
        {
            var hledanyText = TextBoxFiltrace.Text.Trim();

            if (string.IsNullOrEmpty(hledanyText))
            {
                zdroj.DataSource = databaze.Hry;
                return;
            }
            var filtrovane = databaze.Hry.Where(h => h.NazevHry.Contains(hledanyText, StringComparison.CurrentCultureIgnoreCase)).ToList();

            zdroj.DataSource = filtrovane;
            zdroj.ResetBindings(false); // Obnoví zobrazení
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            var pridaniForm = new PridaniForm(databaze);
            pridaniForm.ShowDialog(this);
        }

        private void DeleteGameButton_Click(object sender, EventArgs e)
        {
            var hra = ZobrazeniProEditaci.CurrentRow?.DataBoundItem as Hra; // Získání vybrané hry z konkrétního řádku
            if (hra == null)
            {
                MessageBox.Show("Vyber hru, kterou chceš odebrat.");
                return;
            }
            // Potvrzení smazání hry
            var potvrzeni = MessageBox.Show($"Opravdu chceš odebrat hru \"{hra.NazevHry}\"?", "Potvrzení",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            // Pokud uživatel potvrdí, hra se smaže z databáze a BindingSource se obnoví
            if (potvrzeni == DialogResult.Yes)
            {
                databaze.SmazatHru(hra);
                zdroj.ResetBindings(false);
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
            // Po uložení (OK) obnovíme BindingSource, aby se zobrazil správně i filtr.
            if (vysledek == DialogResult.OK)
            {
                zdroj.ResetBindings(false);
            }
        }


        private void SaveGameButton_Click(object sender, EventArgs e) // Uložení změn do souboru
        {
            try
            {
                databaze.UlozHryDoSouboru();
                MessageBox.Show("Změny byly uloženy.", "Uloženo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba při ukládání",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NastavDataGrid() // Nastavení DataGridView pro zobrazení dat
        {
            ZobrazeniProEditaci.AutoGenerateColumns = false;
            ZobrazeniProEditaci.ReadOnly = true;
            ZobrazeniProEditaci.AllowUserToAddRows = false;
            ZobrazeniProEditaci.AllowUserToDeleteRows = false;
            ZobrazeniProEditaci.MultiSelect = false;
            ZobrazeniProEditaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ZobrazeniProEditaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
