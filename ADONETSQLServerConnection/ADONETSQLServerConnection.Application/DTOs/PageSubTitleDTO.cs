namespace ADONETSQLServerConnection.Application.DTOs
{
    public class PageSubTitleDTO
    {
        public int IdPageSubTitle { get; set; }

        public string SubTitle { get; set; }

        public string SubtitleDescription { get; set; }

        public string ButtonLinkTex { get; set; }

        public string LinkUrl { get; set; }

        public int IdPageTitle { get; set; }

        public PageTitleDTO PageTitle { get; set; }
    }
}
