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
    public class NoteRepository:INoteRepository
    {
        private readonly IApplicationContextDapper _contextDapper;
        //private readonly IApplicationContextEF _contextEf;
        private readonly ILogger<NoteRepository> _logger;

        public NoteRepository(IApplicationContextDapper contextDapper, ILogger<NoteRepository> logger
            )
        {
            _contextDapper = contextDapper;
            _logger = logger;
            //_contextEf = contextEf;
        }

        public async Task<IEnumerable<NoteDTO>> GetNotesbyUserAsync(string name)
        {
            string queryMessages = @"select name as 'Name',text as 'text' from notes left join notepads_has_notes on notes_name=notes.name and notepads_name=@name";
            using IDbConnection connection = _contextDapper.CreateConnection();
            var result = await connection.QueryAsync<NoteDTO>(queryMessages, new
            {
                name = name,
               
            });
            _logger.LogInformation(queryMessages);

            return result;
        }
    }
}
