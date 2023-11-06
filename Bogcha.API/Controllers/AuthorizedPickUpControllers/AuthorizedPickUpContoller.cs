using Bogcha.Domain.Entities;
using Bogcha.Services.Services.AuthorizedPickUpServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async ValueTask<IActionResult> GetAllStudentsAsync()
        {
            var res = await _authorizedPickUp.GetAllAsync();
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetStudentByIdAsync(string ChId)
        {
            var res = await _authorizedPickUp.GetByIdAsync(ChId);
            return Ok(res);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateStudentAsync(AuthorizedPickUp str)
        {
            var res = await _authorizedPickUp.CreateAsync(str);
            return Ok(res);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateStudentAsync(string ChId, AuthorizedPickUp str)
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
