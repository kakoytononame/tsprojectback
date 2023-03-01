using tsproject.Core.DTO;
namespace tsproject.Core.Services
{
    public interface IDirectoryService
    {
        Task<IEnumerable<DirectoryDTO>> GetDirectoryByUserAsync(string path);
    }
}
