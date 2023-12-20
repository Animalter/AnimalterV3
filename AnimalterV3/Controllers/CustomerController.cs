using AnimalterV3.Busssines.Abstract;
using AnimalterV3.Dto;
using AnimalterV3.Entity.Concrete;
using AnimalterV3.Utilities.Abstract;
using AnimalterV3.Utilities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimalterV3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        #region Fields
        private readonly ICustomerService _customerService;
        #endregion

        #region ctor
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        #endregion

        #region methods
        [HttpGet]
        public async Task<List<Customer>> GetAllCustomer()
        {
            return _customerService.Getall();
        }
        [HttpPost]
        public async Task<IUtilityResult> AddCustomer(CustomerDto customer)
        {
            return _customerService.Add(customer);
        }
        [HttpPut]
        public async Task<IUtilityResult> updateCustomer(CustomerDto customer)
        {
            return _customerService.Update(customer);
        }
        [HttpDelete]
        public async Task<IUtilityResult> deleteCustomer(CustomerDto customer)
        {
            return _customerService.Delete(customer);
        }

        #endregion





    }
}
