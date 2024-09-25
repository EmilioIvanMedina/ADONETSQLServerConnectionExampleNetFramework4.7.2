using ADONETSQLServerConnection.Application.DTOs;
using ADONETSQLServerConnection.Application.Interfaces;
using ADONETSQLServerConnection.DataAccess.DataAccess;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ADONETSQLServerConnection.DataAccess.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDataBaseAccess _dataAccess;

        public ContactRepository(IDataBaseAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public IEnumerable<ContactDTO> GetAll()
        {
            var contactsDT = _dataAccess.ExecuteQuery("select * from Contact");
            
            var contacts = new List<ContactDTO>();

            foreach (DataRow contact in contactsDT.Rows)
            {
                contacts.Add(new ContactDTO
                {
                    Contact = contact["contact"].ToString(),
                    ContactName = contact["Contact_Name"].ToString(),
                    IdContactType = (int)contact["Id_Contact_Type"],
                    IdContact = (int)contact["Id_Contact"],
                });

            }

            return contacts;
        }

        public ContactDTO GetContact(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
