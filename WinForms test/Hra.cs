using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_test
{
    public class Hra
    {
        public int Id { get; set; }

        public string NazevHry { get; set; } = string.Empty;

        public string VyvojarskeStudio { get; set; } = string.Empty;

        public int RokVydani { get; set; }

        public string Zanr { get; set; } = string.Empty;

        public int AchievementySplnene { get; set; }

        public int AchievementyCelkem { get; set; }

        public void ValidaceDat() //Metoda pro validaci dat hry
        {
            if (string.IsNullOrWhiteSpace(NazevHry))
                throw new ArgumentException("Název hry nesmí být prázdný.");

            if (RokVydani < 1950 || RokVydani > DateTime.Now.Year + 1)
                throw new ArgumentException("Rok vydání je mimo povolený rozsah.");

            if (AchievementySplnene < 0 || AchievementyCelkem < 0)
                throw new ArgumentException("Achievementy nesmí být záporné.");

            if (AchievementySplnene > AchievementyCelkem)
                throw new ArgumentException(
                    "Počet splněných achievementů nesmí být větší než celkový počet.");
        }
    }
}
