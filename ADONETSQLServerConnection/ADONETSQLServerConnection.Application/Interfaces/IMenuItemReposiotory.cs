using ADONETSQLServerConnection.Application.DTOs;
using System.Collections.Generic;

namespace ADONETSQLServerConnection.Application.Interfaces
{
    public interface IMenuItemReposiotory
    {
        MenuItemDTO GetMenuItem(int id);

        IEnumerable<MenuItemDTO> GetMenuItems();
    }
}
