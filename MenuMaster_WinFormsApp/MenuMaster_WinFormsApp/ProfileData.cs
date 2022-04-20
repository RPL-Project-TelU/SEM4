using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaster_WinFormsApp
{
    internal class ProfileData
    {
        public string Nama { get; set; }
        public string Email { get; set; }

        public ProfileData(string nama, string email)
        {
            Nama = nama;
            Email = email;
        }
    }
}
