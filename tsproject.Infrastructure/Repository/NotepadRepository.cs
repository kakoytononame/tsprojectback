using Dapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tsproject.Core.Contexts;
using tsproject.Core.DTO;
using tsproject.Core.Repository;

namespace tsproject.Infrastructure.Repository
{
    public class NotepadRepository:INotepadRepository
    {
        private readonly IApplicationContextDapper _contextDapper;
        //private readonly IApplicationContextEF _contextEf;
        private readonly ILogger<NotepadRepository> _logger;

        public NotepadRepository(IApplicationContextDapper contextDapper, ILogger<NotepadRepository> logger
            )
        {
            _contextDapper = contextDapper;
            _logger = logger;
            //_contextEf = contextEf;
        }

        public async Task<IEnumerable<NotepadDTO>> GetNotepadsbyUserAsync(string name)
        {

            string queryMessages = @"select directorys_has_notepads.notepads_name as 'Name' from directorys_has_notepads where directorys_name=@name";
            using IDbConnection connection = _contextDapper.CreateConnection();
            var result = await connection.QueryAsync<NotepadDTO>(queryMessages, new
            {
                name=name
            });
            _logger.LogInformation(queryMessages);

            return result;
        }

        
    }
}
