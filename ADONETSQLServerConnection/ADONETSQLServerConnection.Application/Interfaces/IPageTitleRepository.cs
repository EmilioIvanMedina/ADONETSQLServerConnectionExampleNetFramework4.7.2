using ADONETSQLServerConnection.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETSQLServerConnection.Application.Interfaces
{
    public interface IPageTitleRepository
    {
        PageTitleDTO GetPageTitle(int pageIndex);

        IEnumerable<PageTitleDTO> GetPageTitlesByMenuItem(int idMenuItem);
    }
}
