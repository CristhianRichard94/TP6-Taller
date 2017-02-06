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
        public class AccountMovementDTO
        {
            public int Id { get; set; }
            public String Description { get; set; }
            public DateTime Date { get; set; }
            public double Amount { get; set; }
        }
}
