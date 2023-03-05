using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tsproject.Core.Context;
using tsproject.Core.Repository;
using tsproject.Core.Entities;
using tsproject.Core.DTO;
using tsproject.Infrastructure.Contexts;
using tsproject.Core.Contexts;
using System.Data;
using Dapper;


namespace tsproject.Infrastructure.Repository
{
    public class DirectoryRepository:IDirectoryRepository
    {
        private readonly IApplicationContextDapper _contextDapper;
        //private readonly IApplicationContextEF _contextEf;
        private readonly ILogger<DirectoryRepository> _logger;

        public DirectoryRepository(IApplicationContextDapper contextDapper, ILogger<DirectoryRepository> logger
            )
        {
            _contextDapper = contextDapper;
            _logger = logger;
            //_contextEf = contextEf;
        }


        public async Task<IEnumerable<DirectoryDTO>> GetDirectoryByUserAsync(int userId)
        {
            string queryMessages = @"select  directorys.name from directorys inner join users_has_directorys on users_id='1' group by directorys.name";

            using IDbConnection connection = _contextDapper.CreateConnection();

            var result = await connection.QueryAsync<DirectoryDTO>(queryMessages, new
            {
               
                userId = userId
            });

            _logger.LogInformation(queryMessages);

            return result;
        }
    }
}
