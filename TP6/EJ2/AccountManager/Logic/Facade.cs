using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountManager.DAL.EntityFramework;

namespace AccountManager.Logic
{
    public class Facade
    {
        private ClientOperations iClient;
        private AccountOperations iAccount;

        public Facade(UnitOfWork pUOW)
        {
            this.iClient = new ClientOperations(pUOW);
            this.iAccount = new AccountOperations(pUOW);
        }

        public ClientOperations Cliente { get { return this.iClient; } }
        public AccountOperations Cuenta { get { return this.iAccount; } }
    }
}
