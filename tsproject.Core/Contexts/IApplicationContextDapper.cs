using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsproject.Core.Contexts
{
    public interface IApplicationContextDapper
    {
        public IDbConnection CreateConnection();
    }
}
