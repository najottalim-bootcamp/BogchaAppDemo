using Bogcha.Services.Services.RegularHealthCheckServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bogcha.API.Controllers.RegularHealthCheckControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RegularHealthCheckController : ControllerBase
    {
        private readonly IRegularHealthCheckService _regularService;
        public RegularHealthCheckController(IRegularHealthCheckService context)
        {
            _regularService= context;
        }
        [HttpPost]
        public async ValueTask<IActionResult> GetAll()
        {
            return Ok(await _regularService.GetAllAsync());
        }
        [HttpPost]
        public async ValueTask<IActionResult> GetById(int id)
        {
            return Ok(await _regularService.GetByIdAsync(id));
        }
        [HttpPost]
        public async ValueTask<IActionResult> UpdateAsync(RegularHealthCheck regularHealthCheck)
        {
            return Ok(await _regularService.UpdateAsync(regularHealthCheck));
        }
        [HttpPost]
        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _regularService.DeleteAsync(id));
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(RegularHealthCheck regularHealthCheck)
        {
            return Ok(await _regularService.CreateAsync(regularHealthCheck));
        }

    }
}
