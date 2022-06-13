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
            /*SqlConnection konek = new SqlConnection (@"Data Source=DESKTOP-55FDHPN\AHMADFADHIL;Initial Catalog=MenuMaster;Integrated Security=True");
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
            */

        }
    }
}