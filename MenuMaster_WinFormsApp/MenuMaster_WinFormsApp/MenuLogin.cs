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

namespace MenuMaster_WinFormsApp
{
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection konek = new SqlConnection (@"Data Source=DESKTOP-55FDHPN\AHMADFADHIL;Initial Catalog=MenuMaster;Integrated Security=True");
            SqlDataAdapter adr = new SqlDataAdapter("select count (*) from Login where NamaUser = '" + textBox1.Text + "' and PasswordUser = '" + textBox2.Text + "'", konek);
            DataTable dt = new DataTable();

            adr.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MenuUtama panggil = new MenuUtama();
                panggil.Show();
            }
            else
            {
                MessageBox.Show("username atau password salah", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrasi panggil = new Registrasi();
            panggil.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)//button english
        {
            button3.Text = "registration";
        }

        private void button5_Click(object sender, EventArgs e)//button indonesia
        {

        }
    }
}