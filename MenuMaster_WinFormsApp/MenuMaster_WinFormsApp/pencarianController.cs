using Newtonsoft.Json;
using System;

namespace MenuMaster_WinFormsApp
{
    internal class pencarianController
    {
        
        public void Mencari(String input)
        {
            // Memanggil kelas isiMakanan
            pencarianModel data = new pencarianModel();

            // Membaca File JSON
            string dataJson = File.ReadAllText("E:/kuliah semester 4/KPL (Kontruksi Perangkat Lunak)/Tugas/Fitur Pencarian/MenuMaster_WinFormsApp/MenuMaster_WinFormsApp/makanan.json");

            // Convert JSON menjadi Array
            var obj = JsonConvert.DeserializeObject<List<pencarianModel>>(dataJson);
            
            Console.WriteLine(obj?[0]);

            var salah = 1;
            for (int i = 0; i < obj?.Count; i++)
            {
                
                if (input == obj[i].nama || input == obj[i].toko)
                {
                    PencarianTersedia panggilTersedia;
                    panggilTersedia = new PencarianTersedia();
                    panggilTersedia.Show();
                    
                    break;
                }
                else
                {
                    if ( salah == obj?.Count )
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
