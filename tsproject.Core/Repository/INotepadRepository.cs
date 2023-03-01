using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tsproject.Core.DTO;

namespace tsproject.Core.Repository
{
    public interface INotepadRepository
    {
        public Task<IEnumerable<NotepadDTO>> GetNotepadsbyUserAsync(int userId);

    }
}
