using Bogcha.Infrastructure.Services.BlackListServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bogcha.API.Controllers.BlackListControllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class BlackListController : ControllerBase
{
    private IBlackListService _blackList;

    public BlackListController(IBlackListService blackList)
    {
        _blackList = blackList;
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetAllStudentsAsync()
    {
        var res = await _blackList.GetAllAsync();
        return Ok(res);
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetStudentByIdAsync(string ChId)
    {
        var res = await _blackList.GetByIdAsync(ChId);
        return Ok(res);
    }
    [HttpPost]
    public async ValueTask<IActionResult> CreateStudentAsync(BlackList str)
    {
        var res = await _blackList.CreateAsync(str);
        return Ok(res);
    }
    [HttpPut]
    public async ValueTask<IActionResult> UpdateStudentAsync(BlackList str)
    {
        var res = await _blackList.UpdateAsync(str);
        return Ok(res);
    }
    [HttpDelete]
    public async ValueTask<IActionResult> DeleteStudentAsync(string ChId)
    {
        var res = await _blackList.DeleteAsync(ChId);
        return Ok(res);
    }
}
