using AutoMapper;
using FieryRestaurant_Supplier_Domain;
using FieryRestaurant_Supplier_DTO;
using FieryRestaurant_Supplier_Model.Repository.Implementations;
using FieryRestaurant_Supplier_Model.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FieryRestuarant_Hackathon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly IMapper _mapper;

        public SupplierController(IMapper mapper)
        {
            _mapper = mapper;
        }

        private ISupplier repo = new SupplierRepository();

        [HttpPost]
        [Route("AddNewSupplier")]

        public IActionResult addNewSupplier(Supplier supplier)
        {
            try
            {
                repo.addNewSupplier(supplier);
                return Created($"api/A/{supplier.Supplier_Id}", supplier);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet]
        [Route("SupplierList")]
        public IActionResult getAllSupplier()
        {
            try
            {
                var Supplier = getAllSupplier();
                SupplierDTO supplierDTO = _mapper.Map<SupplierDTO>(Supplier);
                return Ok(supplierDTO);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpGet]
        [Route("SupplierById")]

        public IActionResult getSupplierById(int id)
        {
            try
            {
                var Supplier = getSupplierById(id);
                SupplierDTO supplierDTO = _mapper.Map<SupplierDTO>(Supplier);
                return Ok(supplierDTO);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

    }
}
