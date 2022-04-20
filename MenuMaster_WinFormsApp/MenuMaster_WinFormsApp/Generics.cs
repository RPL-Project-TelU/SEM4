using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaster_WinFormsApp
{
    public class Generics<T>
    {
        List<T> nama;
        List<T> username;
        List<T> password;
        List<T> email;
        List<T> handphone;
        List<T> alamat;

        public Generics()
        {
            nama = new List<T>();
            username = new List<T>();
            password = new List<T>();
            email = new List<T>();
            handphone = new List<T>();
            alamat = new List<T>();

        }

        public void AddNama(T data)
        {
            nama.Add(data);
         
        }
        public void AddUsername(T data)
        {
            
            username.Add(data);
         
        }

        public void AddPassword(T data)
        {
            
            password.Add(data);
            
        }

        public void AddEmail(T data)
        {
           
            email.Add(data);
           
        }

        public void AddHandphone(T data)
        {
            handphone.Add(data);
        }

        public void AddAlamat(T data)
        {
            alamat.Add(data);
        }

       

    }

    
}
