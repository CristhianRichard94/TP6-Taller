using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.DTO
{
    public class AccountDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public double OverdraftLimit { get; set; }

        public AccountDTO()
        {
            this.Id = -1;
            this.Name = "";
            this.OverdraftLimit = 1000;
        }
    }
}
