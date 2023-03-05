using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tsproject.Core.Contexts;

namespace tsproject.Infrastructure.Contexts
{
    public class ApplicationContextDapper:IApplicationContextDapper
    {
        private readonly IConfiguration _configuration;

        public ApplicationContextDapper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            return new MySqlConnection(_configuration.GetConnectionString("MySqlConnection"));
        }
    }
}
