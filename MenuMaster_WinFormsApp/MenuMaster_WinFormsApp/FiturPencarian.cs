using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MenuMaster_WinFormsApp
{
    public partial class FiturPencarian : Form
    {
        public FiturPencarian()
        {
            InitializeComponent();
        }

        class Makanan
        {

            [JsonProperty("nama")]
            public string nama { get; set; }

            [JsonProperty("toko")]
            public string toko { get; set; }

        }

        private void kolomPencarian_TextChanged(object sender, EventArgs e)
        {

        }

        private void TombolCari_Click(object sender, EventArgs e)
        {
            //bool input = bool.Parse(input);
            string input = kolomPencarian.Text;
            
            Makanan data = new Makanan();

            // Membaca File JSON
            String jsonString = File.ReadAllText("E:/kuliah semester 4/KPL (Kontruksi Perangkat Lunak)/Tugas/Fitur Pencarian/MenuMaster_WinFormsApp/MenuMaster_WinFormsApp/makanan.json");

            // Convert JSON menjadi Array
            var deserial = JsonConvert.DeserializeObject<List<Makanan>>(jsonString);

            Console.WriteLine(deserial[0]);

            for (int i = 0; i<deserial.Count; i++)
            {
                if (input == deserial[i].nama || input == deserial[i].toko)
                {
                    PencarianTersedia panggil = new PencarianTersedia();
                    panggil.Show();
                }
                else
                {
                    PencarianTidakTersedia panggil = new PencarianTidakTersedia();
                    panggil.Show();
                }
            }
        }
    }
}
