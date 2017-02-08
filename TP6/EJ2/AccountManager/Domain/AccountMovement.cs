using System;

namespace AccountManager.Domain
{/// <summary>
/// Clase que representa los movimientos de una cuenta
/// </summary>
    public class AccountMovement
    {

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public String Description { get; set; }

        public double Amount { get; set; }

        public AccountMovement()        {        }

        public AccountMovement(DateTime pDate, String pDescription, double pAmount)
        {
            this.Date = pDate;
            this.Description = pDescription;
            this.Amount = pAmount;
        }
    }
}
