using Bogcha.Infrastructure.Services.RegularHealthCheckServices.RegularHealthCheckDtos;

namespace Bogcha.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RegularHealthCheckController : ControllerBase
    {
        private readonly IRegularHealthCheckService _regularService;
        public RegularHealthCheckController(IRegularHealthCheckService context)
        {
            _regularService = context;
        }
        [HttpGet(Name = "getreg")]
        public async ValueTask<IActionResult> GetAll()
        {
            return Ok(await _regularService.GetAllAsync());
        }
        [HttpGet(Name = "getregbyid")]
        public async ValueTask<IActionResult> GetById(int id)
        {
            return Ok(await _regularService.GetByIdAsync(id));
        }
        [HttpPut(Name = "putreg")]
        public async ValueTask<IActionResult> UpdateAsync(int id, UpdateRegularHealthCheckDto regularHealthCheck)
        {
            return Ok(await _regularService.UpdateAsync(id, regularHealthCheck));
        }
        [HttpDelete(Name = "delreg")]
        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _regularService.DeleteAsync(id));
        }
        [HttpPost(Name = "createreg")]
        public async ValueTask<IActionResult> CreateAsync(CreateRegularHealthCheckDto regularHealthCheck)
        {
            return Ok(await _regularService.CreateAsync(regularHealthCheck));
        }

    }
}
