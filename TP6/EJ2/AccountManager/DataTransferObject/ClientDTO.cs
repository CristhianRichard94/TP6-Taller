using System;
using AccountManager.Domain;


namespace AccountManager.DTO
{
    public class ClientDTO
    {

        public int Id { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String DocumentNumber { get; set; }
        public DocumentType DocumentType { get; set; }

        public ClientDTO()
        {
            this.Id = -1;
            this.LastName = "";
            this.FirstName = "";
           
        }
    }
}
