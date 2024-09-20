using ADONETSQLServerConnection.Application.DTOs;
using ADONETSQLServerConnection.Application.Interfaces;
using System.Collections.Generic;

namespace ADONETSQLServerConnection.DataAccess.Repositories
{
    internal class PageSubTitleRepository : IPageSubTitleRepository
    {
        public IEnumerable<PageSubTitleDTO> GetAllSubTitleByPageTitle(int pageTitleId)
        {
            throw new System.NotImplementedException();
        }

        public PageSubTitleDTO GetPageSubTitle(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
