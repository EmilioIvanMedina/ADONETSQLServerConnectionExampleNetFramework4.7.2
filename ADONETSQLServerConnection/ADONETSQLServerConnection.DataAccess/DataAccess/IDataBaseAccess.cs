using System.Collections.Generic;
using System.Data;

namespace ADONETSQLServerConnection.DataAccess.DataAccess
{
    public interface IDataBaseAccess
    {
        void OpenConnection();

        void CloseConnection();

        IEnumerable<T> ExecuteQuery<T>(string query);

        DataTable ExecuteQuery(string query);
    }
}
