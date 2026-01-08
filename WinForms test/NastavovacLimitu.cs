using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_test
{
    internal class NastavovacLimitu
    {
        public static void NastavRokVydani(NumericUpDown rokNum, int minimalniRok = 1950)
        {
            rokNum.Minimum = minimalniRok;
            rokNum.Maximum = DateTime.Now.Year + 1;

            if (rokNum.Value < rokNum.Minimum || rokNum.Value > rokNum.Maximum)
                rokNum.Value = DateTime.Now.Year;
        }

        public static void NastavAchievementy(NumericUpDown splneneNum, NumericUpDown celkemNum)
        {
            splneneNum.Minimum = 0;
            celkemNum.Minimum = 0;

            // max splněných podle celkem (aktuální hodnota)
            splneneNum.Maximum = celkemNum.Value;

            // Když už je splněných víc než celkem, srovnáme
            if (splneneNum.Value > celkemNum.Value)
                splneneNum.Value = celkemNum.Value;
        }
    }
}
