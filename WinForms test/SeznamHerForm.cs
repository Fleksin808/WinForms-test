using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinForms_test
{
    public partial class SeznamHerForm : Form
    {

        private readonly MainMenu hlavniMenu;
        private readonly Databaze databaze;
        public SeznamHerForm(MainMenu menu, Databaze databaze)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            hlavniMenu = menu;
            this.databaze = databaze;
        }

        private void ZpetDoMenuButton_Click(object sender, EventArgs e)
        {
            hlavniMenu.Show();
            this.Close();
        }

        private void ZobrazeniZaznamuHer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SeznamHerForm_Load(object sender, EventArgs e)
        {
            //Kontrola existence XML souboru, pokud neexistuje, vytvoření nového
            XDocument databaseHer;
            if (!File.Exists("DatabaseHer.xml"))
            {
                databaseHer = new XDocument(new XElement("Hry"));
                databaseHer.Save("DatabaseHer.xml");
            }
            else
            {
                databaseHer = XDocument.Load("DatabaseHer.xml");
            }

            // Načtení dat z XML souboru do DataSetu
            DataSet setDat = new DataSet();
            setDat.ReadXml("DatabaseHer.xml");
            // Nastavení DataGridView pro zobrazení dat
            ZobrazeniZaznamuHer.DataSource = setDat.Tables[0];
            ZobrazeniZaznamuHer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ZobrazeniZaznamuHer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Zakázat úpravy přímo v DataGridView ve formě přímého psaní do buněk
            ZobrazeniZaznamuHer.ReadOnly = true;
            ZobrazeniZaznamuHer.AutoGenerateColumns = false;
            ZobrazeniZaznamuHer.AllowUserToAddRows = false;
            ZobrazeniZaznamuHer.AllowUserToDeleteRows = false;
            ZobrazeniZaznamuHer.MultiSelect = false;

            // vytbořit exception pro případ, že tabulka je prázdná
            ZobrazeniZaznamuHer.Columns["id"].DataPropertyName = "id";
            ZobrazeniZaznamuHer.Columns["hra"].DataPropertyName = "NazevHry";
            ZobrazeniZaznamuHer.Columns["zanr"].DataPropertyName = "Zanr";
            ZobrazeniZaznamuHer.Columns["studio"].DataPropertyName = "VyvojarskeStudio";
            ZobrazeniZaznamuHer.Columns["rokVydani"].DataPropertyName = "RokVydani";
            ZobrazeniZaznamuHer.Columns["achievementSplnene"].DataPropertyName = "AchievementySplnene";
            ZobrazeniZaznamuHer.Columns["achievementCelkem"].DataPropertyName = "AchievementyCelkem";
        }
    }
}
