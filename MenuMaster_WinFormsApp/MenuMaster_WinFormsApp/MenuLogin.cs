using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace MenuMaster_WinFormsApp
{
    public partial class MenuLogin : Form
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source=DESKTOP-55FDHPN\AHMADFADHIL;Initial Catalog=MenuMaster;Integrated Security=True");
        public MenuLogin()
        {
            InitializeComponent();
        }

        private void tombolLogin_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            if(textBox1.Text == "" & textBox2.Text == "" & textBox3.Text == "" & !Regex.IsMatch(textBox1.Text, @"^[a-zA-Z][\w.-][a-zA-Z0-9]@[a-zA-Z0-9][\w.-][a-zA-Z0-9].[a-zA-Z][a-zA-Z.]*[a-zA-Z]$"))//Parshing METHOD
            {
                MessageBox.Show("Username atau password masih kosong");//Programing Defensive METHOD
            }
            else if (textBox2.Text != "PasswordUser")
            {
                MessageBox.Show("Password tidak sama");
            }
            else
            {
                //SqlDataAdapter adr = new SqlDataAdapter("select count (*) from MenuMaster where NamaUser = '" + textBox1.Text + "' and PasswordUser = '" + textBox2.Text + "'", koneksi);
                SqlDataAdapter adr = new SqlDataAdapter("select NamaUser,PasswordUser,Pengguna,Gmail from MenuMaster where NamaUser = '"+textBox1.Text+"' OR Gmail = '"+ textBox3.Text+ "' AND PasswordUser = '"+textBox2.Text+"' ",koneksi);
                DataTable dt = new DataTable();
                adr.Fill(dt);

                //Table Driven METHOD
                if (dt.Rows.Count > 0)
                {                    
                    foreach(DataRow dr in dt.Rows)
                    {
                        if (dr["Pengguna"].ToString() == "admin")
                        {
                            this.Hide();
                            MenuAdmin MA = new MenuAdmin();
                            MA.Show();
                        }
                        else if(dr["Pengguna"].ToString() == "customer")
                        {
                            this.Hide();
                            MenuUtama MU = new MenuUtama();
                            MU.Show();
                        }
                        else if(dr["Pengguna"].ToString() == "penjual")
                        {
                            this.Hide();
                            MenuPenjual MJ = new MenuPenjual();
                            MJ.Show();
                        }
                        else if(dr["Pengguna"].ToString() == "driver")
                        {
                            this.Hide();
                            MenuDriver MD = new MenuDriver();
                            MD.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("username atau password salah", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);//Programing Defensive METHOD
                }
                //Table Driven METHOD
            }
            koneksi.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void tombolclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cekKoneksi_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                MessageBox.Show("Koneksi Berhasil");
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}