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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        
        private void Simpan_Click(object sender, EventArgs e)
        {
            Generics<string> g=new Generics<string>();
            try
            {
                

                if (String.IsNullOrEmpty(textBox1.Text) | String.IsNullOrEmpty(textBox2.Text) | String.IsNullOrEmpty(textBox1.Text) | String.IsNullOrEmpty(textBox2.Text) | String.IsNullOrEmpty(textBox3.Text) | String.IsNullOrEmpty(textBox4.Text) | String.IsNullOrEmpty(textBox5.Text))
                {
                    throw new Exception("Text tidak boleh NULL");
                }
                else
                {
                    string Nama = textBox1.Text;
                    string Username = textBox2.Text;
                    string Email = textBox3.Text;
                    string Handphone = textBox4.Text;
                    string Alamat = textBox5.Text;

                    g.AddNama(Nama);
                    g.AddNama(Username);
                    g.AddNama(Email);
                    g.AddNama(Handphone);
                    g.AddNama(Alamat);

                    MessageBox.Show("Data Berhasil disimpan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
