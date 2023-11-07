using Bogcha.Infrastructure.Services.AuthorizedPickUpServices.AuthorizedPickUpDTOs;

namespace Bogcha.API.Controllers.AuthorizedPickUpControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorizedPickUpContoller : ControllerBase
    {
        private IAuthorizedPickUpService _authorizedPickUp;

        public AuthorizedPickUpContoller(IAuthorizedPickUpService authorizedPickUp)
        {
            _authorizedPickUp = authorizedPickUp;
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            var res = await _authorizedPickUp.GetAllAsync();
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(string ChId)
        {
            var res = await _authorizedPickUp.GetByIdAsync(ChId);
            return Ok(res);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(CreateAuthorizedPickUpDTO str)
        {
            var res = await _authorizedPickUp.CreateAsync(str);
            return Ok(res);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(string ChId, UpdateAuthorizedPickUpDTO str)
        {
            var res = await _authorizedPickUp.UpdateAsync(ChId, str);
            return Ok(res);
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteStudentAsync(string ChId)
        {
            var res = await _authorizedPickUp.DeleteAsync(ChId);
            return Ok(res);
        }
    }
}
