namespace ADONETSQLServerConnection.Application.DTOs
{
    public class ContactDTO
    {
        public int IdContact { get; set; }

        public string Contact{ get; set; }

        public string ContactName { get; set; }

        public int IdContactType { get; set; }

        public ContactTypeDTO ContactType { get; set; }
    }
}
