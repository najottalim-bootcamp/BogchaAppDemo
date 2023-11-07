using Bogcha.Infrastructure.Services.BlackListServices;
using Bogcha.Infrastructure.Services.BlackListServices.BlackListDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bogcha.API.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class BlackListController : ControllerBase
{
    private IBlackListService _blackList;

    public BlackListController(IBlackListService blackList)
    {
        _blackList = blackList;
    }
    [HttpGet(Name = "getblack")]
    public async ValueTask<IActionResult> GetAllStudentsAsync()
    {
        var res = await _blackList.GetAllAsync();
        return Ok(res);
    }
    [HttpGet(Name = "getblackbyid")]
    public async ValueTask<IActionResult> GetStudentByIdAsync(string ChId)
    {
        var res = await _blackList.GetByIdAsync(ChId);
        return Ok(res);
    }
    [HttpPost(Name = "createblack")]
    public async ValueTask<IActionResult> CreateStudentAsync(CreateBlackListDTO str)
    {
        var res = await _blackList.CreateAsync(str);
        return Ok(res);
    }
    [HttpPut(Name = "putblack")]
    public async ValueTask<IActionResult> UpdateStudentAsync(string id, UpdateBlackListDTO str)
    {
        var res = await _blackList.UpdateAsync(id, str);
        return Ok(res);
    }
    [HttpDelete(Name = "delblack")]
    public async ValueTask<IActionResult> DeleteStudentAsync(string ChId)
    {
        var res = await _blackList.DeleteAsync(ChId);
        return Ok(res);
    }
}
