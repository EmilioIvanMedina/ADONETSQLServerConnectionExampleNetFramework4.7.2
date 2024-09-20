namespace ADONETSQLServerConnection.Application.DTOs
{
    public class PageTitleDTO
    {
        public int IdPageTitle { get; set; }
        
        public string Title { get; set; }

        public string TitleDescription { get; set; }

        public string ButtonLinkText { get; set; }

        public string LinkUrl { get; set; }

        public int IdMenuItem { get; set; }

        public MenuItemDTO MenuItem { get; set; }
    }
}
