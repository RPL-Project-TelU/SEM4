using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuMaster_Keranjang
{
    internal class Product
    {
        public string Deskripsi { get; set; }
        public double Cost { get; set; }
        public int NumberOrdered { get; set; }

        public Product(string deskripsi, double cost)
        {
            this.Deskripsi = deskripsi;
            this.Cost = cost;
        }
    }
}
