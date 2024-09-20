using ADONETSQLServerConnection.Application.DTOs;
using ADONETSQLServerConnection.Application.Interfaces;
using System.Collections.Generic;

namespace ADONETSQLServerConnection.DataAccess.Repositories
{
    internal class ContactRepository : IContactRepository
    {
        public IEnumerable<ContactDTO> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ContactDTO GetContact(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
