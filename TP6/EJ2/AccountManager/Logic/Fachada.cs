using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountManager.DAL.EntityFramework;

namespace AccountManager.Logic
{
    class Fachada
    {
        private ClientOperations iCliente;
        private AccountOperations iCuenta;

        public Fachada(UnitOfWork pUnitOfWork)
        {
            this.iCliente = new ClientOperations(pUnitOfWork);
            this.iCuenta = new AccountOperations(pUnitOfWork);
        }

        public ClientOperations Cliente { get { return this.iCliente; } }
        public AccountOperations Cuenta { get { return this.iCuenta; } }
    }
}
