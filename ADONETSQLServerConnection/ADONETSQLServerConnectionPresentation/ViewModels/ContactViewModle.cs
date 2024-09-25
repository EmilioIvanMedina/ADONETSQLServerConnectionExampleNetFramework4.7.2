using ADONETSQLServerConnection.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADONETSQLServerConnectionPresentation.ViewModels
{
    public class ContactViewModle
    {
        public string Title { get; set; }
        public string Message { get; set; }

        public IEnumerable<ContactDTO> Contacts { get; set; }
    }
}