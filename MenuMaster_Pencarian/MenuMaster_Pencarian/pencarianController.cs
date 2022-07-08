using MenuMaster_Pencarian;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MenuMaster_WinFormsApp
{
    public class pencarianController
    {
        // Variabel bool untuk unit testing
        private static bool tersedia = false;

        public static bool getTersedia()
        {
            return tersedia;
        }

        public void Mencari(String input)
        {
            // Memanggil kelas isiMakanan
            pencarianModel data = new pencarianModel();

            // Membaca File JSON
            string dataJson = File.ReadAllText("C:/Users/desak/Downloads/Fitur Pencarian/Fitur Pencarian/MenuMaster_WinFormsApp/MenuMaster_WinFormsApp/makanan.json");

            // Convert JSON menjadi Array
            var obj = JsonConvert.DeserializeObject<List<pencarianModel>>(dataJson);


            Console.WriteLine(obj?[0]);

            var salah = 1;
            for (int i = 0; i < obj?.Count; i++)
            {

                if (input == obj[i].nama || input == obj[i].toko)
                {
                    pencarianTersedia panggilTersedia;
                    panggilTersedia = new pencarianTersedia();
                    panggilTersedia.Show();
                    tersedia = true;

                    break;
                }
                else
                {
                    if (salah == obj?.Count)
                    {
                        MessageBox.Show("Maaf, pencarian tidak tersedia");
                    }

                }
                salah++;
            }

            Console.ReadLine();
            

        }
    }
}
