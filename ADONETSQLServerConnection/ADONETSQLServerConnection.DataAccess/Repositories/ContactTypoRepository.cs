using ADONETSQLServerConnection.Application.DTOs;
using ADONETSQLServerConnection.Application.Interfaces;
using System.Collections.Generic;

namespace ADONETSQLServerConnection.DataAccess.Repositories
{
    internal class ContactTypoRepository : IContactTypeRepository
    {
        public IEnumerable<ContactTypeDTO> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ContactTypeDTO GetContactType(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
