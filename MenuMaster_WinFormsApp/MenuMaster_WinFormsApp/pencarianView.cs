using System;

namespace MenuMaster_WinFormsApp
{
    public partial class pencarianView : Form
    {
        public pencarianView()
        {
            InitializeComponent();
        }

        private void kolomPencarian_TextChanged(object sender, EventArgs e)
        {


        }

        private void TombolCari_Click(object sender, EventArgs e)
        {
            pencarianController data = new pencarianController();

            String input = kolomPencarian.Text;
          
            data.Mencari(input);

        }

        private void labelHasilPencarian_Click(object sender, EventArgs e)
        {

        }
    }
}
