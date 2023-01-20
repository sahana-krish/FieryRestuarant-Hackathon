using FieryRestaurant_Supplier_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurant_Supplier_Model.Repository.Interfaces
{
    public interface ISupplier
    {
        public void addNewSupplier(Supplier supplier);
        public List<Supplier> getAllSupplier();

        public Supplier getSupplierById(int supplierId);

    }
}
