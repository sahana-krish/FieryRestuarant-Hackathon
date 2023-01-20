using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurant_Supplier_DTO
{
    public class SupplierDTO
    {
        public string Supplier_Id { get; set; }
        public string Supplier_Name { get; set; }
        public DateTime CreatedDate { get; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime LastModifiedBy { get; set; }
        public bool IsActive { get; set; }

    }
}
