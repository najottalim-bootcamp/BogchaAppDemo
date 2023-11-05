using Bogcha.Services.Services.Accident_RecordsServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bogcha.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Accident_RecordsController : ControllerBase
    {
        private readonly IAccident_RecordsService _accident_records_service;
        public Accident_RecordsController(IAccident_RecordsService context) { _accident_records_service = context; }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync() 
        {
            var d = await _accident_records_service.GetAllAsync();
            return Ok(d);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(Accident_Records accident_Records)
        {
            var d = await _accident_records_service.CreateAsync(accident_Records);
            return Ok(d);
        }
        
    }
}
