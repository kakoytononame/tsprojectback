using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tsproject.Core.DTO;
using tsproject.Core.Repository;
using tsproject.Core.Services;

namespace tsproject.Application.Services
{
    public class NoteService:INoteService
    {
        private readonly INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        
        public async Task<IEnumerable<NoteDTO>> GetNoteInUserAsync(string name)
        {
            IEnumerable<NoteDTO> notes = await _noteRepository.GetNotesbyUserAsync(name);
            return notes;
        }
    }
}
