using ADONETSQLServerConnection.Application.DTOs;
using ADONETSQLServerConnection.Application.Interfaces;
using System.Collections.Generic;

namespace ADONETSQLServerConnection.DataAccess.Repositories
{
    internal class PageTitleRepository : IPageTitleRepository
    {
        public PageTitleDTO GetPageTitle(int pageIndex)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PageTitleDTO> GetPageTitlesByMenuItem(int idMenuItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
