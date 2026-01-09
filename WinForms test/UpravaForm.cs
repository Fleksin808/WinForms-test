namespace WinForms_test
{
    public partial class UpravaForm : Form
    {
        private readonly Databaze databaze;
        private readonly Hra hra;
        public UpravaForm(Databaze databaze, Hra hra)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.databaze = databaze;
            this.hra = hra;

            // Nastavení smysluplných limitů pro numUpDown
            NastavLimity();
            // Naplníme pole aktuálními hodnotami
            NactiDataDoFormu();
        }

        private void UlozitAZavrit_Click(object sender, EventArgs e)
        {
            try
            {
                // Zapíše hodnoty z formuláře, do instance zvoleného objektu "Hra"
                PrevodnikFormulareNaHru.ZapisZFormuDoObjektu(hra, UpravaNazevBox, UpravaZanrBox, UpravaStudioBox, UpravaRokNum, UpravaSplneneNum, UpravaCelkemNum);

                OverPovinnaPole(); // Ověří vyplnění povinných polí

                hra.ValidaceDat(); // Validace dat v objektu "Hra"

                databaze.UlozHryDoSouboru(); // Uloží změny do souboru XML

                DialogResult = DialogResult.OK; // Rozpoznáno jako úspěch
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NastavLimity() // Nastaví smysluplné limity pro numUpDown ovládací prvky
        {
            NastavovacLimitu.NastavRokVydani(UpravaRokNum);
            NastavovacLimitu.NastavAchievementy(UpravaSplneneNum, UpravaCelkemNum);
        }

        private void NactiDataDoFormu() // Načte hodnoty z instance zvoleného objektu "Hra" do formuláře
        {
            UpravaNazevBox.Text = hra.NazevHry;
            UpravaZanrBox.Text = hra.Zanr;
            UpravaStudioBox.Text = hra.VyvojarskeStudio;

            var rok = hra.RokVydani;
            if (rok < UpravaRokNum.Minimum) rok = (int)UpravaRokNum.Minimum;
            if (rok > UpravaRokNum.Maximum) rok = (int)UpravaRokNum.Maximum;
            UpravaRokNum.Value = rok;

            UpravaCelkemNum.Value = hra.AchievementyCelkem;
            UpravaSplneneNum.Maximum = UpravaCelkemNum.Value;
            UpravaSplneneNum.Value = Math.Min(hra.AchievementySplnene, hra.AchievementyCelkem);
        }       

        private void OverPovinnaPole() // Pokud nejsou vyplněna povinná pole, vyhodí výjimku
        {
            if (string.IsNullOrWhiteSpace(hra.NazevHry))
                throw new ArgumentException("Název hry je povinný.");
            if (string.IsNullOrWhiteSpace(hra.Zanr))
                throw new ArgumentException("Žánr je povinný.");
            if (string.IsNullOrWhiteSpace(hra.VyvojarskeStudio))
                throw new ArgumentException("Vývojářské studio je povinné.");
        }
    }
}
