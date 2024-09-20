using System.Collections.Generic;

namespace ADONETSQLServerConnection.DataAccess.DataAccess
{
    internal interface IDataBaseAcess
    {
        void OpenConnection();

        void CloseConnection();

        IEnumerable<T> ExecuteQuery<T>(string query);
    }
}
