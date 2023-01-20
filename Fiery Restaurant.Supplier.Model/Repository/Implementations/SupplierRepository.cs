using FieryRestaurant_Supplier_Domain;
using FieryRestaurant_Supplier_Model.Data_Access_Layer;
using FieryRestaurant_Supplier_Model.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurant_Supplier_Model.Repository.Implementations
{
    public class SupplierRepository : ISupplier
    {
        private SupplierDbContext db;

        public SupplierRepository()
        {
        }

        public SupplierRepository(SupplierDbContext supplierDbContext)
        {
            db= supplierDbContext;
        }

       
        public void addNewSupplier(Supplier supplier)
        {
            try
            {
                db.suppliers.Add(supplier);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Supplier> getAllSupplier()
        {
            try
            {
                return db.suppliers.ToList();
            }
            catch (Exception ex)
            {
                return new List<Supplier>();
            }
           
        }

        public Supplier getSupplierById(int supplierId)
        {
            try
            {
                return db.suppliers.Find(supplierId);

            }
            catch
            {
                return new Supplier();
            }
        }
    }
}
