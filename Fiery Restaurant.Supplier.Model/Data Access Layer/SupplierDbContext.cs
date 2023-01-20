using FieryRestaurant_Supplier_Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurant_Supplier_Model.Data_Access_Layer
{
    public class SupplierDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=SupplierDataBase;Integrated Security=True;Pooling=False");
        }

        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<Business> business { get; set; }

    }
}
