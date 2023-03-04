using Microsoft.AspNetCore.Mvc;
using tsproject.Core.Services;
using tsproject.WebAPI.Controllers.bases;

namespace tsproject.WebAPI.Controllers
{
    [Route("api/notepads")]
    public class NotepadsController:BaseController
    {
        private readonly INotepadService _notepadService;

        public NotepadsController(INotepadService notepadService)
        {
            _notepadService = notepadService;
        }

        [HttpGet]
        [Route("getnotepads/{directoryname}")]
        public async Task<IActionResult> GetNotepadsByUser([FromRoute]string directoryname)
        {
            var result = await _notepadService.GetNotepadByUserAsync(directoryname);
            return Ok(result);
        }

    }
}
