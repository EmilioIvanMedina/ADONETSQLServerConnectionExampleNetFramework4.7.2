using ADONETSQLServerConnection.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETSQLServerConnection.Application.Interfaces
{
    public interface IMenuItemReposiotory
    {
        MenuItemDTO GetMenuItem(int id);

        IEnumerable<MenuItemDTO> GetMenuItems();
    }
}
