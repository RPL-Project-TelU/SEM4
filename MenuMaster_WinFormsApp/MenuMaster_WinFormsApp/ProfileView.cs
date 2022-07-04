using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuMaster_WinFormsApp
{
    public partial class ProfileView : Form
    {
        public ProfileView()
        {
            InitializeComponent();
        }
        
        private void Simpan_Click(object sender, EventArgs e)
        {
            ProfileController data = new ProfileController();
            String Nama = textBox1.Text;
            String Username = textBox2.Text;
            String Email = textBox3.Text;
            String Handphone = textBox4.Text;
            String Alamat = textBox5.Text;

            String listbox = listBox1.ToString();

            data.profil ( Nama, Username, Email, Handphone, Alamat);

            listBox1.Items.Add(Nama);
            listBox1.Items.Add(Username);
            listBox1.Items.Add(Email);
            listBox1.Items.Add(Handphone);
            listBox1.Items.Add(Alamat);
        }


        private void Kembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuUtama objUI = new MenuUtama();
            objUI.ShowDialog();
            this.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
