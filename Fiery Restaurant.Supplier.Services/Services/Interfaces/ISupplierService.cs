using FieryRestaurant_Supplier_Domain;
using FieryRestaurant_Supplier_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurant_Supplier_Services.Services.Interfaces
{
    public interface ISupplierService
    {
       
       // public SupplierDTO addNewSupplier(SupplierDTO supplier);
        public List<SupplierDTO> getAllSupplier();

        public SupplierDTO getSupplierById(int supplierId);
    }
}
