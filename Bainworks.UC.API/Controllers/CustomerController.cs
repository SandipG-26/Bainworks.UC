using Bainworks.UC.Service;
using Microsoft.AspNetCore.Mvc;


namespace Bainworks.UC.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
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
