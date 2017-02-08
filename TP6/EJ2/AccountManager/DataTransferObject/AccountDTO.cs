using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.DTO
{
    /// <summary>
    /// La clase DTO se utiliza para comunicar la fachada con la interfaz gráfica
    /// </summary>
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
