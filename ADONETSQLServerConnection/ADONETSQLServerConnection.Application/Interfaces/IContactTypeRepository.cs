﻿using ADONETSQLServerConnection.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETSQLServerConnection.Application.Interfaces
{
    internal interface IContactTypeRepository
    {
        ContactTypeDTO GetContactType(int id);

        IEnumerable<ContactTypeDTO> GetAll();
    }
}
