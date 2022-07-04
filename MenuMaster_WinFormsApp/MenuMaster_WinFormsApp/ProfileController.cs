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
    internal class ProfileController
    {
        public void profil (String Nama,
            String Username, 
            String Email,
            String Handphone, 
            String Alamat ) {

            Generics<string> g = new Generics<string>();
            try
            {

                if (String.IsNullOrEmpty(Nama) | String.IsNullOrEmpty(Username) | String.IsNullOrEmpty(Nama) | String.IsNullOrEmpty(Username) | String.IsNullOrEmpty(Email) | String.IsNullOrEmpty(Handphone) | String.IsNullOrEmpty(Alamat))
                {
                    throw new Exception("Text tidak boleh NULL");
                }
                else
                {

                    

                    g.AddNama(Nama);
                    g.AddNama(Username);
                    g.AddNama(Email);
                    g.AddNama(Handphone);
                    g.AddNama(Alamat);
                    g.AddUsername(Username);
                    g.AddEmail(Email);
                    g.AddHandphone(Handphone);
                    g.AddAlamat(Alamat);

                    MessageBox.Show("Data Berhasil disimpan");

                    
                }
            }
            catch { }
        }
    }
}
