using Bogcha.DataAccess.Repositories.AssessmentRecKGRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bogcha.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IAssessmentRecKGRepository _repository;

        public TestController(IAssessmentRecKGRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async ValueTask< IActionResult> Get()
        {
            var res = await _repository.GetAllAsync();
            return Ok(res);
        }
    }
}
