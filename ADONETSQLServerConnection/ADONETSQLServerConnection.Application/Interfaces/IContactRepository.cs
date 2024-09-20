using ADONETSQLServerConnection.Application.DTOs;
using System.Collections.Generic;

namespace ADONETSQLServerConnection.Application.Interfaces
{
    public interface IContactRepository
    {
        ContactDTO GetContact(int id);

        IEnumerable<ContactDTO> GetAll();
    }
}
