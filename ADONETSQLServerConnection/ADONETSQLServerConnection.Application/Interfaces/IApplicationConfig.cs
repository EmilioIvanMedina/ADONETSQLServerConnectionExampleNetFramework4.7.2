using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETSQLServerConnection.Application.Interfaces
{
    public interface IApplicationConfig
    {
        string ConnectionString { get; }
    }
}
