using AutoMapper;
using FieryRestaurant_Supplier_Domain;
using FieryRestaurant_Supplier_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieryRestaurant_Supplier_Services.Mapping
{
    public class SupplierMapping : Profile
    {
        public SupplierMapping()
        {
            this.CreateMap<Supplier, SupplierDTO>();
            this.CreateMap<Address, SupplierDTO>();
            this.CreateMap<Business, BusinessDTO>();
        }
    }
}
