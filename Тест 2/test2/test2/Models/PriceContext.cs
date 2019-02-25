using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace test2.Models
{
    public class PriceContext : DbContext
    {

        public DbSet<Price_tarif> Price_tarif { get; set; }
        public DbSet<Price_trend> Price_trend { get; set; }
        public DbSet<Tarif> Tarif { get; set; }
        public DbSet<Tarif_atribute> Tarif_atribute { get; set; }
    }
}