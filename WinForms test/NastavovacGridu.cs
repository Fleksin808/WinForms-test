using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_test
{
    internal class NastavovacGridu
    {
        public static void NastavSloupec(DataGridView grid, string nazevSloupce, string property)
        {
            var column = grid.Columns[nazevSloupce];
            if (column == null)
                throw new InvalidOperationException($"Sloupec '{nazevSloupce}' nebyl nalezen v DataGridView.");

            column.DataPropertyName = property;
        }

        public static void NastavSloupecProHry(DataGridView grid)
        {
            NastavSloupec(grid, "id", "Id");
            NastavSloupec(grid, "hra", "NazevHry");
            NastavSloupec(grid, "zanr", "Zanr");
            NastavSloupec(grid, "studio", "VyvojarskeStudio");
            NastavSloupec(grid, "rokVydani", "RokVydani");
            NastavSloupec(grid, "achievementSplnene", "AchievementySplnene");
            NastavSloupec(grid, "achievementCelkem", "AchievementyCelkem");
        }
    }
}
