using System;
using AccountManager.Domain;
using System.Collections.Generic;


namespace AccountManager.DTO
{
    /// <summary>
    /// La clase DTO se utiliza para comunicar la fachada con la interfaz gráfica
    /// </summary>
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
