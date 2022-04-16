using System;
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

namespace FiturPencarian
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        class makanan
        {

            [JsonProperty("nama")]
            public string nama { get; set; }

            [JsonProperty("toko")]
            public string toko { get; set; }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            bool Bool = bool.Parse(input);

            // Membaca File JSON
            String jsonString = File.ReadAllText("E:/kuliah semester 4/KPL (Kontruksi Perangkat Lunak)/Tugas/Pencarian Menu Master/SEM4/MenuMaster_WinFormsApp/MenuMaster_WinFormsApp/FiturPencarian/FiturPencarian/makanan.json");

            // Convert JSON menjadi Array
            dynamic data = JsonConvert.DeserializeObject(jsonString);

            for (int i = 0; i < data.Count; i++)
            {
                if (Bool = data[i])
                {
                    HalamanHasilPencarian panggil = new HalamanHasilPencarian();
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