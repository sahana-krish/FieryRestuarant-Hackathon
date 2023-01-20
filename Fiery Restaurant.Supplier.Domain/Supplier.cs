using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurant_Supplier_Domain
{
    public class Supplier
    {
        [Key]
        public string Supplier_Id { get; set; }
        public string Supplier_Name { get;set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get;}
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public Address Address { get; set; }
        public Business Business { get; set; }


    }
}
