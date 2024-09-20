using ADONETSQLServerConnection.Application.DTOs;
using System.Collections.Generic;

namespace ADONETSQLServerConnection.Application.Interfaces
{
    public interface IContactTypeRepository
    {
        ContactTypeDTO GetContactType(int id);

        IEnumerable<ContactTypeDTO> GetAll();
    }
}
