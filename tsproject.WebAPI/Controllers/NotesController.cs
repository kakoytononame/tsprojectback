using Microsoft.AspNetCore.Mvc;
using tsproject.Core.Services;
using tsproject.WebAPI.Controllers.bases;

namespace tsproject.WebAPI.Controllers
{
    [Route("api/notes")]
    public class NotesController:BaseController
    {
        private readonly INoteService _noteService;
        public NotesController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet]
        [Route("getnotes/{notepadname}")]

        public async Task<IActionResult> GetNotesByUser([FromRoute]string notepadname)
        {
            var result= await _noteService.GetNoteInUserAsync(notepadname);
            return Ok(result);
        }

    }
}
