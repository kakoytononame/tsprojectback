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

    public  class DirectoryService:IDirectoryService
    {
        private readonly IDirectoryRepository _directoryrepository;
        
        public DirectoryService(IDirectoryRepository directoryRepository)
        {
            _directoryrepository = directoryRepository;
        }

        public async Task<IEnumerable<DirectoryDTO>> GetDirectoryByUserAsync(int id)
        {
            IEnumerable<DirectoryDTO> directorys = await _directoryrepository.GetDirectorysbyUserAsync(id);
            return directorys;
        }
    }
}
