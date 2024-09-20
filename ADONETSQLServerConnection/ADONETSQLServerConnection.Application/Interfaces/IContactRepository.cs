using ADONETSQLServerConnection.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETSQLServerConnection.Application.Interfaces
{
    public interface IContactRepository
    {
        ContactDTO GetContact(int id);

        IEnumerable<ContactDTO> GetAll();
    }
}
