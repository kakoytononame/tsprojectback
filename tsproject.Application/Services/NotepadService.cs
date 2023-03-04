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
    public class NotepadService:INotepadService
    {
        private readonly INotepadRepository _notepadRepository;

        public NotepadService(INotepadRepository notepadRpository)
        {
            _notepadRepository = notepadRpository;

        }

        public async Task<IEnumerable<NotepadDTO>> GetNotepadByUserAsync(string name)
        {
            IEnumerable<NotepadDTO> notepads = await _notepadRepository.GetNotepadsbyUserAsync(name);
            return notepads;
        }
    }
}
