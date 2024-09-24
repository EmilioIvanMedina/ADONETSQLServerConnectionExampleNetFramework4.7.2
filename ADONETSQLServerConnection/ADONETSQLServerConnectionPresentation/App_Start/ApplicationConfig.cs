using System.Configuration;

namespace ADONETSQLServerConnectionPresentation.App_Start
{
    public class ApplicationConfig
    {
        public string ConnectionString { get;  }
        public ApplicationConfig()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["WebSiteDatabase"].ConnectionString;
        }
    }
}