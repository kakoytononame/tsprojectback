using tsproject.Core.DTO;

namespace tsproject.Core.Services
{
    public interface INotepadService
    {
        Task<IEnumerable<NotepadDTO>> GetNotepadByUserAsync(string path);
    }
}
