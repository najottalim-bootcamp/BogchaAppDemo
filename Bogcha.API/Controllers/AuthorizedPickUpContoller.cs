using Bogcha.Infrastructure.Services.AuthorizedPickUpServices.AuthorizedPickUpDTOs;

namespace Bogcha.API.Controllers
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
        [HttpGet(Name = "hello")]
        public async ValueTask<IActionResult> GetAllStudentsAsync()
        {
            var res = await _authorizedPickUp.GetAllAsync();
            return Ok(res);
        }
        [HttpGet(Name = "getbyidstd")]
        public async ValueTask<IActionResult> GetStudentByIdAsync(string ChId)
        {
            var res = await _authorizedPickUp.GetByIdAsync(ChId);
            return Ok(res);
        }
        [HttpPost(Name = "createStudent")]
        public async ValueTask<IActionResult> CreateStudentAsync(CreateAuthorizedPickUpDTO str)
        {
            var res = await _authorizedPickUp.CreateAsync(str);
            return Ok(res);
        }
        [HttpPut(Name = "updatestd")]
        public async ValueTask<IActionResult> UpdateStudentAsync(string id, UpdateAuthorizedPickUpDTO str)
        {
            var res = await _authorizedPickUp.UpdateAsync(id, str);
            return Ok(res);
        }
        [HttpDelete(Name = "delstd")]
        public async ValueTask<IActionResult> DeleteStudentAsync(string ChId)
        {
            var res = await _authorizedPickUp.DeleteAsync(ChId);
            return Ok(res);
        }
    }
}
