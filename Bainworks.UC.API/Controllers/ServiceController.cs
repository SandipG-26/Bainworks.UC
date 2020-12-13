using Brainworks.UC.Services;
using Brainworks.UC.ViewModel;
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
        [HttpGet("getallservices")]
        public IActionResult GetAllServices()
        {
            return Ok(this._serviceServices.GetAllServices());
        }
        [HttpGet("getservicetype")]
        public IActionResult GetAllServices(string servicetype)
        {
            return Ok(this._serviceServices.GetByServieType(servicetype));
        }
        [HttpPost("add")]
        public IActionResult AddService(ServiceViewModel service)
        {
            return Ok(this._serviceServices.AddService(service));
        }
    }
}
