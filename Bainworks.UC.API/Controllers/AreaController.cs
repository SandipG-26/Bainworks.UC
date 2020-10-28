using Brainworks.UC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Brainworks.UC.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly IAreaService _areaService;
        public AreaController(IAreaService areaService)
        {
            this._areaService = areaService;
        }
        [HttpGet]
        public IActionResult GetAllAreas()
        {
            return Ok(this._areaService.GetAllAreas());
        }
    }
}
