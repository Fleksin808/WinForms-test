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

        private Menu hlavniMenu;
        public SeznamHerForm(Menu menu)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            hlavniMenu = menu;
        }

        private void ZpetDoMenuButton_Click(object sender, EventArgs e)
        {
            hlavniMenu.Show();
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SeznamHerForm_Load(object sender, EventArgs e)
        {
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
        }
    }
}
