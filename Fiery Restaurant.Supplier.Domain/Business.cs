using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurant_Supplier_Domain
{
    public class Business
    {
        [Key]
        public string Supplier_Id { get; set; }
        public string Business_Name { get; set; }
        public long License_No { get; set; }
        public DateTime LicenseDate { get; set; }
        public List<Supplier> Suppliers { get; set; }
    }
}
