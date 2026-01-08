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
                // Přepíšeme hodnoty do stejného objektu
                ZapisZFormuDoObjektu();

                OverPovinnaPole();

                hra.ValidaceDat();

                databaze.UlozHryDoSouboru(); // 

                DialogResult = DialogResult.OK; // Rozpoznáno jako úspěch
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NastavLimity()
        {
            NastavovacLimitu.NastavRokVydani(UpravaRokNum);
            NastavovacLimitu.NastavAchievementy(UpravaSplneneNum, UpravaCelkemNum);
        }

        private void NactiDataDoFormu()
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

        private void ZapisZFormuDoObjektu()
        {
            hra.NazevHry = UpravaNazevBox.Text.Trim();
            hra.Zanr = UpravaZanrBox.Text.Trim();
            hra.VyvojarskeStudio = UpravaStudioBox.Text.Trim();
            hra.RokVydani = (int)UpravaRokNum.Value;
            hra.AchievementySplnene = (int)UpravaSplneneNum.Value;
            hra.AchievementyCelkem = (int)UpravaCelkemNum.Value;
        }

        private void OverPovinnaPole()
        {
            if (string.IsNullOrWhiteSpace(hra.NazevHry))
                throw new ArgumentException("Název hry je povinný.");
            if (string.IsNullOrWhiteSpace(hra.Zanr))
                throw new ArgumentException("Žánr je povinný.");
        }


    }
}
