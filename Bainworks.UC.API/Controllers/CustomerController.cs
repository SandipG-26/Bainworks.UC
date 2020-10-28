using Brainworks.UC.Services;
using Microsoft.AspNetCore.Mvc;


namespace Brainworks.UC.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController     
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService) 
            {
            this._customerService = customerService;
            }
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
             return Ok(this._customerService.GetAllCustomers());
        }
    }
}
