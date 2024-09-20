using System;
using System.Collections.Generic;

namespace ADONETSQLServerConnection.DataAccess.DataAccess
{
    internal class DabaBaseAccess : IDataBaseAcess, IDisposable
    {
        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ExecuteQuery<T>(string query)
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }
    }
}
