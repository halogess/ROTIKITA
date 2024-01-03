using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROTIKITA.Contracts
{
    public class JenisRotiStatus
    {
        public const int ACTIVE = 1;
        public const int INACTIVE = 0;
    }
    public class JenisRotiVisible
    {
        public JenisRotiVisible(string jenisCode, string name, int price, int expiration)
        {
            this.JenisCode = jenisCode;
            this.Name = name;
            this.Price = price;
            this.Expiration = expiration;
        }

        public string JenisCode { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Expiration { get; set; }
    }
    public class RotiVisible
    {
        public RotiVisible(string jenisCode, string kodeRoti, string nama, int price, int quantity, DateTime expiration)
        {
            this.JenisCode = jenisCode;
            this.KodeRoti = kodeRoti;
            this.Name = nama;
            this.Price = price;
            this.Quantity = quantity;
            this.Expiration = expiration;
        }

        public string JenisCode { get; set; }
        public string KodeRoti { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Expiration { get; set; }
    }
    public class RotiCartVisible
    {
        public RotiCartVisible(string kode, string name, int price, int quantity, DateTime expiration)
        {
            this.Kode = kode;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Expiration = expiration;
        }
        public string Kode { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Expiration { get; set; }
    }
    public class BuyRotiItemVo
    {
        public string KodeRoti { get; private set; }
        public string Nama { get; private set; }
        public int Harga { get; private set; }
        public int Qty { get; private set; }
        public int Subtotal { get; private set; }

        public BuyRotiItemVo(string kodeRoti, string nama, int harga, int qty, int subtotal)
        {
            KodeRoti = kodeRoti;
            Nama = nama;
            Harga = harga;
            Qty = qty;
            Subtotal = subtotal;
        }
    }
}
