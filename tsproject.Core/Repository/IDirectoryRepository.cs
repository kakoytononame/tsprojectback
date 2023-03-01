
using tsproject.Core.DTO;
using tsproject.Core.Repository;

namespace tsproject.Core.Repository
{
    public interface IDirectoryRepository
    {
        public Task<IEnumerable<DirectoryDTO>> GetDirectorysbyUserAsync(int userId);
        
    }


}