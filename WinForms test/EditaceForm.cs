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
        private MainMenu hlavniMenu;
        public EditaceForm(MainMenu menu)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            hlavniMenu = menu;
        }

        private void EditaceForm_Load(object sender, EventArgs e)
        {

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
