using ADONETSQLServerConnection.Application.DTOs;
using System.Collections.Generic;

namespace ADONETSQLServerConnection.Application.Interfaces
{
    public interface IPageSubTitleRepository
    {
        PageSubTitleDTO GetPageSubTitle(int id);

        IEnumerable<PageSubTitleDTO> GetAllSubTitleByPageTitle(int pageTitleId);
    }
}
