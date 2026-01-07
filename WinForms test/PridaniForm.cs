namespace WinForms_test
{
    public partial class PridaniForm : Form
    {
        public PridaniForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            NastavLimity();
        }

        private void ZpetDoEditace_Click(object sender, EventArgs e)
        {
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
