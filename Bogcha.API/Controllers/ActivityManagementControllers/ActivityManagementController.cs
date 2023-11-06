﻿using Bogcha.Services.Services.ActivityManagementServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bogcha.API.Controllers.ActivityManagementControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ActivityManagementController : ControllerBase
    {
        private readonly IActivityManagementService _activityManagement;
        public ActivityManagementController(IActivityManagementService context) 
        {
            _activityManagement = context;
        }
        [HttpPost]
        public async ValueTask<IActionResult> GetAll()
        {
            return Ok(await _activityManagement.GetAllAsync());
        }
        [HttpPost]
        public async ValueTask<IActionResult> GetById(int id)
        {
            return Ok(await _activityManagement.GetByIdAsync(id));
        }
        [HttpPost]
        public async ValueTask<IActionResult> UpdateAsync(ActivityManagement activityManagement)
        {
            return Ok(await _activityManagement.UpdateAsync(activityManagement));
        }
        [HttpPost]
        public async ValueTask<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _activityManagement.DeleteAsync(id));
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(ActivityManagement activityManagement)
        {
            return Ok(await _activityManagement.CreateAsync(activityManagement));
        }
    }
}