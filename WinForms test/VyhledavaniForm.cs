using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms_test
{
    public partial class VyhledavaniForm : Form
    {
        private MainMenu hlavniMenu;
        public VyhledavaniForm(MainMenu menu)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            hlavniMenu = menu;
        }

        private void VyhledavaniForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("[r] - Pro vyhledání hry podle roku vydání");
            Console.WriteLine("[d] - Pro vyhledání hry podle vývojářského studia");
            Console.WriteLine("[z] - Pro vyhledání hry podle žánru");
        }
    }
}
