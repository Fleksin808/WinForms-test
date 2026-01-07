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
                var novaHra = new Hra
                {
                    NazevHry = PridaniNazevBox.Text.Trim(),
                    Zanr = PridaniZanrBox.Text.Trim(),
                    VyvojarskeStudio = PridaniStudioBox.Text.Trim(),
                    RokVydani = (int)PridaniRokNum.Value,
                    AchievementySplnene = (int)PridaniSplnenychNum.Value,
                    AchievementyCelkem = (int)PridaniCelkemNum.Value
                };

                // jednoduchá povinná pole
                if (string.IsNullOrWhiteSpace(novaHra.NazevHry))
                    throw new ArgumentException("Název hry je povinný.");
                if (string.IsNullOrWhiteSpace(novaHra.Zanr))
                    throw new ArgumentException("Žánr je povinný.");

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

        private void PridaniCelkemNum_ValueChanged(object sender, EventArgs e)
        {
            PridaniSplnenychNum.Maximum = PridaniCelkemNum.Value;

            if (PridaniSplnenychNum.Value > PridaniCelkemNum.Value)
            {
                PridaniSplnenychNum.Value = PridaniCelkemNum.Value;
            }
        }

        private void NastavLimity()
        {
            PridaniRokNum.Minimum = 1950;
            PridaniRokNum.Maximum = DateTime.Now.Year + 1;
            PridaniRokNum.Value = DateTime.Now.Year;

            PridaniSplnenychNum.Minimum = 0;
            PridaniSplnenychNum.Maximum = PridaniCelkemNum.Value;
            PridaniCelkemNum.Minimum = 0;
        }
    }
}
