using AutoMapper;
using FieryRestaurant_Supplier_Services.Services.Interfaces;
using FieryRestaurant_Supplier_Domain;
using FieryRestaurant_Supplier_DTO;
using FieryRestaurant_Supplier_Model.Data_Access_Layer;
using FieryRestaurant_Supplier_Model.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FieryRestaurant_Supplier_Model.Repository.Implementations;

namespace FieryRestaurant_Supplier_Services.Services.Implementations
{
    public class SupplierServiceRepository : ISupplierService
    {
        public ISupplier _supplier;
        private readonly IMapper _mapper;
        public SupplierDbContext db;
        public SupplierServiceRepository(SupplierDbContext supplierDbContext, IMapper mapper, ISupplier supplier)
        {
             db = supplierDbContext;
            _mapper = mapper;
            _supplier = new SupplierRepository(supplierDbContext);
        }

        public List<SupplierDTO> getAllSupplier()
        {
            List<Supplier> supplier1 = _supplier.getAllSupplier();
            List<SupplierDTO> getAllSuppliers = _mapper.Map<List<Supplier>, List<SupplierDTO>>(supplier1);
            return getAllSuppliers;
        }

        public SupplierDTO getSupplierById(int supplierId)
        {
            Supplier supplier = _supplier.getSupplierById(supplierId);
            var supplierDTO = _mapper.Map<Supplier, SupplierDTO>(_supplier.getSupplierById(supplierId));
            return supplierDTO;
        }

        //public SupplierDTO addNewSupplier(SupplierDTO supplier)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
