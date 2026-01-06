using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_test
{
    public partial class EditaceForm : Form
    {
        private readonly MainMenu hlavniMenu;
        private readonly Databaze databaze;
       
        public EditaceForm(MainMenu menu, Databaze databaze)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            hlavniMenu = menu;
            this.databaze = databaze;
        }

        private void EditaceForm_Load(object sender, EventArgs e)
        {
            ZobrazeniProEditaci.AutoGenerateColumns = false;
            ZobrazeniProEditaci.ReadOnly = true;
            ZobrazeniProEditaci.AllowUserToAddRows = false;
            ZobrazeniProEditaci.AllowUserToDeleteRows = false;
            ZobrazeniProEditaci.MultiSelect = false;
            ZobrazeniProEditaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ZobrazeniProEditaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ZobrazeniProEditaci.DataSource = databaze.Hry;

            ZobrazeniProEditaci.Columns["id"].DataPropertyName = "Id";
            ZobrazeniProEditaci.Columns["hra"].DataPropertyName = "NazevHry";
            ZobrazeniProEditaci.Columns["zanr"].DataPropertyName = "Zanr";
            ZobrazeniProEditaci.Columns["studio"].DataPropertyName = "VyvojarskeStudio";
            ZobrazeniProEditaci.Columns["rokVydani"].DataPropertyName = "RokVydani";
            ZobrazeniProEditaci.Columns["achievementSplnene"].DataPropertyName = "AchievementySplnene";
            ZobrazeniProEditaci.Columns["achievementCelkem"].DataPropertyName = "AchievementyCelkem";
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ZpetButton_Click(object sender, EventArgs e)
        {
            hlavniMenu.Show();
            this.Close();
        }
    }
}
