using ADONETSQLServerConnection.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETSQLServerConnection.Application.Configurations
{
    public class ApplicationConfig : IApplicationConfig
    {
        private readonly string _connectionString;

        public string ConnectionString => _connectionString;

        public ApplicationConfig(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
