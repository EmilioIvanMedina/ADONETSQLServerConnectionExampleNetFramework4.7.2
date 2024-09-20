using ADONETSQLServerConnection.Application.DTOs;
using System.Collections.Generic;

namespace ADONETSQLServerConnection.Application.Interfaces
{
    public interface IPageTitleRepository
    {
        PageTitleDTO GetPageTitle(int pageIndex);

        IEnumerable<PageTitleDTO> GetPageTitlesByMenuItem(int idMenuItem);
    }
}
