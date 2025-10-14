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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
