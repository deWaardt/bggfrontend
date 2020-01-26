using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BBGFrontEnd.Models
{
    public class Shop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public int Phone { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public List<bool> OpenDays { get; set; } // Lijst met 7 elementen die staan voor de dagen van de week.
    }

    public class ShopDBContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
    }
}