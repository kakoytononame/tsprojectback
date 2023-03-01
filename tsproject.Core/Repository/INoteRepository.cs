using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tsproject.Core.DTO;

namespace tsproject.Core.Repository
{
    public interface INoteRepository
    {
        public Task<IEnumerable<NoteDTO>> GetNotesbyUserAsync(int userId);
    }
}
