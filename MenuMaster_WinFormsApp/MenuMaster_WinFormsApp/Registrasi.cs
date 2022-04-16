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
    public partial class Registrasi : Form
    {
        string conn = @"Data Source=DESKTOP-M5KITNF;Initial Catalog=Registrasi;Integrated Security=True ";
        public Registrasi()
        {
            InitializeComponent();
        }

       

        private void label_Nama_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label_ConfirmPass_Click(object sender, EventArgs e)
        {

        }
        private void txt_Nama_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_NamaAwal_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_NamaAkhir_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_ConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_registrasi_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "" || txt_Pass.Text == "")
            {
                MessageBox.Show("lengkapi username dan password");
            }
            else if (txt_Pass.Text != txt_ConfirmPass.Text)
            {
                MessageBox.Show("Password tidak sama");
            }
            else if (txt_Email.Text == ""||!Regex.IsMatch(txt_Email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("email harus terisi dan terdiri huruf besar,keci serta angka");
            }
            else
            {
                using (SqlConnection sqlconn = new SqlConnection(conn))
                {
                    sqlconn.Open();
                    SqlCommand sqlcmd = new SqlCommand("UserAdd", sqlconn);
                    sqlcmd.Parameters.AddWithValue("@NamaUser", txt_Username.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@NamaAwal", txt_NamaAwal.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@NamaAkhir", txt_NamaAkhir.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@Email", txt_Email.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@PasswordUser", txt_Pass.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("@ConfirmPassword", txt_ConfirmPass.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("berhasil dibuat");
                    Clear();
                    
                }
            }
            
        }

        void Clear()
        {
            txt_Username.Text = txt_NamaAwal.Text = txt_NamaAkhir.Text = txt_Email.Text = txt_Pass.Text = txt_ConfirmPass.Text = "";
        }
        private void Registrasi_Load(object sender, EventArgs e)
        {
            
        }

        private void label_Nama_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
