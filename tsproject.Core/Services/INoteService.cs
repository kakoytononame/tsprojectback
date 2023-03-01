using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tsproject.Core.DTO;

namespace tsproject.Core.Services
{
    public interface INoteService
    {
        Task<IEnumerable<NoteDTO>> GetNoteInUserAsync(string path);
    }
}
