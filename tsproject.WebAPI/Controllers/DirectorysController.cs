using tsproject.Core.Services;
using Microsoft.AspNetCore.Mvc;
using tsproject.WebAPI.Controllers.bases;

namespace tsproject.WebAPI.Controllers
{
    [Route("api/directorys")]
    public class DirectorysController:BaseController
    {
        private readonly IDirectoryService _directoryService;
        public DirectorysController(IDirectoryService directoryService)
        {
            _directoryService = directoryService;
        }
        [HttpGet]
        [Route("getdirectorys")]
        public async Task<IActionResult> GetDirectoryByUser()
        {
            var result = await _directoryService.GetDirectoryByUserAsync(1);
            return Ok(result);
        }

    }
}
