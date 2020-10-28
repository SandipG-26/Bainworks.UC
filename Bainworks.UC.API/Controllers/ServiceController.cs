using Brainworks.UC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Brainworks.UC.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceServices _serviceServices;
        public ServiceController(IServiceServices serviceServices)
        {
            this._serviceServices = serviceServices;
        }
        [HttpGet]
        public IActionResult GetAllServices()
        {
            return Ok(this._serviceServices.GetAllServices());
        }
    }
}
