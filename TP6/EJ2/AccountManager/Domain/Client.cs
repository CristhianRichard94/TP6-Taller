using System;
using System.Collections.Generic;

namespace AccountManager.Domain
{/// <summary>
/// Clase que representa a un cliente
/// </summary>
    public class Client
    {

        public int Id { get; set; }

        public Document Document { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public virtual IList<Account> Accounts { get; set; }

    }
}
