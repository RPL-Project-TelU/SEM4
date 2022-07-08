using MenuMaster_WinFormsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuMaster_Pencarian
{
    public partial class pencarianView : Form
    {
        public pencarianView()
        {
            InitializeComponent();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            pencarianController data = new pencarianController();

            String input = txtCari.Text;

            data.Mencari(input);
        }
    }
}
