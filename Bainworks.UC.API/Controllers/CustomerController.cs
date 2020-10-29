using Brainworks.UC.Data;
using Brainworks.UC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Brainworks.UC.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController :ControllerBase  
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService) 
            {
            this._customerService = customerService;
            }
        [HttpGet("getallcustomers")]
        public IActionResult GetAllCustomers()
        {
             return Ok(this._customerService.GetAllCustomers());
        }
        [HttpGet("getcustomerbyemail/{email}")]
        public IActionResult GetCustomerByEmail(string email)
        {
            return Ok(this._customerService.GetByEmail(email));
        }
        [HttpPost("addcustomer")]
        public IActionResult AddCustomers(Customer customer)
        {
            return Ok(this._customerService.AddCustomers(customer));
        }
        [HttpPut("updatecustomer")]
        public IActionResult UpdateCustomers(Customer customer)
        {
            return Ok(this._customerService.UpdateCustomers(customer));
        }
        [HttpDelete("deletecustomer/{userId}")]
        public IActionResult DeleteCustomers(int customerId)
        {
            return Ok(this._customerService.DeleteCustomers(customerId));
        }
    }
}
