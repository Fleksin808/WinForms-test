using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_test
{
    internal class PrevodnikFormulareNaHru
    {
        // Zapíše hodnoty z formuláře, do instance zvoleného objektu "Hra"
        public static void ZapisZFormuDoObjektu(Hra hra, TextBox nazevBox, TextBox zanrBox, TextBox studioBox, NumericUpDown rokNum, NumericUpDown splneneNum, NumericUpDown celkemNum)
        {
            hra.NazevHry = nazevBox.Text.Trim();
            hra.Zanr = zanrBox.Text.Trim();
            hra.VyvojarskeStudio = studioBox.Text.Trim();
            hra.RokVydani = (int)rokNum.Value;
            hra.AchievementySplnene = (int)splneneNum.Value;
            hra.AchievementyCelkem = (int)celkemNum.Value;
        }
    }
}
