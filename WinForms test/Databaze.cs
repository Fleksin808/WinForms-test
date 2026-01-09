using System.ComponentModel;
using System.Xml.Linq;

namespace WinForms_test
{
    public class Databaze
    {
        private const string NazevSouboru = "DatabaseHer.xml";

        // BindingList je kolekce vhodná pro WinForms data binding:
        // - DataGridView automaticky reaguje na Add/Remove (změny kolekce)
        // - Formuláře tedy nemusí ručně překreslovat tabulku po přidání/mazání
        private readonly BindingList<Hra> hry = new();

        public BindingList<Hra> Hry => hry;

        public Databaze()
        {
            ZajistiExistenciSouboru();
            NactiHryZeSouboru();
        }

        // 1) Ověří zda soubor existuje. Pokud ne, vytvoří se se základním obsahem
        private void ZajistiExistenciSouboru()
        {
            if (File.Exists(NazevSouboru))
                return;

            var dokument = new XDocument(
                new XElement("Hry",
                    new XElement("Hra",
                        new XAttribute("id", 1),
                        new XElement("NazevHry", "Ukazkova hra"),
                        new XElement("VyvojarskeStudio", "Studio"),
                        new XElement("RokVydani", DateTime.Now.Year),
                        new XElement("Zanr", "Zanr"),
                        new XElement("AchievementySplnene", 0),
                        new XElement("AchievementyCelkem", 0)
                    )
                )
            );

            dokument.Save(NazevSouboru);
        }

        // 2) Načtení her z XML do BindingList
        public void NactiHryZeSouboru()
        {
            hry.Clear();

            var dokument = XDocument.Load(NazevSouboru);
            var koren = dokument.Root;

            if (koren == null)
                throw new InvalidDataException("XML soubor nema korenovy element <Hry>.");

            foreach (var prvek in koren.Elements("Hra"))
            {
                var hra = new Hra
                {
                    Id = (int?)prvek.Attribute("id") ?? 0,
                    NazevHry = (string?)prvek.Element("NazevHry") ?? string.Empty,
                    VyvojarskeStudio = (string?)prvek.Element("VyvojarskeStudio") ?? string.Empty,
                    RokVydani = (int?)prvek.Element("RokVydani") ?? 0,
                    Zanr = (string?)prvek.Element("Zanr") ?? string.Empty,
                    AchievementySplnene = (int?)prvek.Element("AchievementySplnene") ?? 0,
                    AchievementyCelkem = (int?)prvek.Element("AchievementyCelkem") ?? 0
                };

                hra.ValidaceDat();
                hry.Add(hra);
            }

            // Pokud by XML existovalo, ale bylo prázdné (<Hry />), přidáme 1 ukázkový záznam
            if (!hry.Any())
            {
                PridatHru(new Hra
                {
                    NazevHry = "Ukazkova hra",
                    VyvojarskeStudio = "Studio",
                    RokVydani = DateTime.Now.Year,
                    Zanr = "Zanr",
                    AchievementySplnene = 0,
                    AchievementyCelkem = 1
                });
            }
        }

        // 3) Přidání hry
        public void PridatHru(Hra novaHra)
        {
            if (novaHra == null)
                throw new ArgumentNullException(nameof(novaHra));

            // Automatické vytvoření unikátního ID
            novaHra.Id = hry.Any() ? hry.Max(h => h.Id) + 1 : 1;

            novaHra.ValidaceDat();
            hry.Add(novaHra);

            UlozHryDoSouboru();
        }

        // 4) Smazání hry
        public void SmazatHru(Hra hraKeSmazani)
        {
            if (hraKeSmazani == null)
                throw new ArgumentNullException(nameof(hraKeSmazani));

            hry.Remove(hraKeSmazani);
            UlozHryDoSouboru();
        }

        // 5) Uložení všech her do XML
        public void UlozHryDoSouboru()
        {
            // Validace všech záznamů před uložením
            foreach (var hra in hry)
                hra.ValidaceDat();
            // Vytvoření nového XML dokumentu v paměti
            // Kořenový prvek <Hry> reprezentuje celý seznam her.
            var dokument = new XDocument(
                new XElement("Hry",
                    // Pomocí LINQ převedeme kolekci objektů Hra na XML strukturu.
                    // Pro každou hru se vytvoří samostatný element <Hra>.
                    hry.Select(h => new XElement("Hra",
                        // Atribut id slouží jako jednoznačný identifikátor hry.
                        new XAttribute("id", h.Id),
                        // Jednotlivé vlastnosti objektu Hra jsou uloženy jako samostatné XML elementy.
                        new XElement("NazevHry", h.NazevHry),
                        new XElement("VyvojarskeStudio", h.VyvojarskeStudio),
                        new XElement("RokVydani", h.RokVydani),
                        new XElement("Zanr", h.Zanr),
                        new XElement("AchievementySplnene", h.AchievementySplnene),
                        new XElement("AchievementyCelkem", h.AchievementyCelkem)
                    ))
                )
            );

            dokument.Save(NazevSouboru); // Uložení a přepsání souboru
        }
    }
}
