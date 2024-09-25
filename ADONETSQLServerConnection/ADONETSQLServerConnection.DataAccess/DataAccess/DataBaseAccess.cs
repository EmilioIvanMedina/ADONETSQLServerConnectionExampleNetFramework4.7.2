using ADONETSQLServerConnection.Application.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ADONETSQLServerConnection.DataAccess.DataAccess
{
    public class DataBaseAccess : IDataBaseAccess
    {
        private readonly SqlConnection _connection;
        private readonly IApplicationConfig _applicationConfig;

        private bool ConnectionIsOpen => _connection != null && _connection.State == ConnectionState.Open;

        public DataBaseAccess(IApplicationConfig applicationConfig)
        {
            _applicationConfig = applicationConfig;
        }

        public void CloseConnection()
        {
            if (ConnectionIsOpen)
            {
                _connection.Close();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<T> ExecuteQuery<T>(string query)
        {
            return TryAutomapping<T>(ExecuteQuery(query));
        }

        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(_applicationConfig.ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    var adapter = new SqlDataAdapter(cmd);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public void OpenConnection()
        {
            if (_connection == null && _connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                CloseConnection();
                _connection.Dispose();
            }
        }

        private IEnumerable<T> TryAutomapping<T>(DataTable data)
        {
            try
            {
                var mapConfig = new MapperConfiguration(cfg => cfg.CreateMap<IEnumerable<T>, DataTable>());
                var mapper = new Mapper(mapConfig);
                return mapper.Map<IEnumerable<T>>(data);
            }
            catch (Exception ex)
            {
                throw new Exception("This data cannot be automapped.", ex);
            }
        }
    }
}
