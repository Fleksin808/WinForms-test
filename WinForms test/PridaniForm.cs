namespace WinForms_test
{
    public partial class PridaniForm : Form
    {
        private readonly Databaze databaze;
        public PridaniForm(Databaze databaze)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            NastavLimity();
            this.databaze = databaze;
        }

        private void ZpetDoEditace_Click(object sender, EventArgs e)
        {
            try
            {
                var novaHra = new Hra();
                
                PrevodnikFormulareNaHru.ZapisZFormuDoObjektu(novaHra, PridaniNazevBox, PridaniZanrBox, PridaniStudioBox,  PridaniRokNum, PridaniSplnenychNum, PridaniCelkemNum);

                // Jednoduchá povinná pole
                if (string.IsNullOrWhiteSpace(novaHra.NazevHry))
                    throw new ArgumentException("Název hry je povinný.");
                if (string.IsNullOrWhiteSpace(novaHra.Zanr))
                    throw new ArgumentException("Žánr je povinný.");
                if (string.IsNullOrWhiteSpace(novaHra.VyvojarskeStudio))
                    throw new ArgumentException("Vývojářské studio je povinné.");

                novaHra.ValidaceDat();

                databaze.PridatHru(novaHra);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void PridaniCelkemNum_ValueChanged(object sender, EventArgs e) // Upraví maximum pro splněné achievementy
        {
            PridaniSplnenychNum.Maximum = PridaniCelkemNum.Value;

            if (PridaniSplnenychNum.Value > PridaniCelkemNum.Value)
            {
                PridaniSplnenychNum.Value = PridaniCelkemNum.Value;
            }
        }

        private void NastavLimity()
        {
            NastavovacLimitu.NastavRokVydani(PridaniRokNum);
            NastavovacLimitu.NastavAchievementy(PridaniSplnenychNum, PridaniCelkemNum);
        }
    }
}
