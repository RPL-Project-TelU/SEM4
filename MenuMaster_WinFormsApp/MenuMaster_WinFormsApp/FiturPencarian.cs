using Newtonsoft.Json;


namespace MenuMaster_WinFormsApp
{
    public partial class FiturPencarian : Form
    {
        public FiturPencarian()
        {
            InitializeComponent();
        }

       

        private void kolomPencarian_TextChanged(object sender, EventArgs e)
        {

        }

        private void TombolCari_Click(object sender, EventArgs e)
        {
            // Memanggil kelas Makanan
            Makanan data = new Makanan();

            // Membaca File JSON
            string dataJson = File.ReadAllText("E:/kuliah semester 4/KPL (Kontruksi Perangkat Lunak)/Tugas/Fitur Pencarian/MenuMaster_WinFormsApp/MenuMaster_WinFormsApp/makanan.json");

            
            
            String input = kolomPencarian.Text;

            // Convert JSON menjadi Array
            var obj = JsonConvert.DeserializeObject<List<Makanan>>(dataJson);

            Console.WriteLine(obj?[0]);
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
                    labelHasilPencarian.Text = ("Maaf, hidangan yang kamu cari tidak tersedia");
                }

            }

            Console.ReadLine();

        }



        private void labelHasilPencarian_Click(object sender, EventArgs e)
        {

        }
    }
}
