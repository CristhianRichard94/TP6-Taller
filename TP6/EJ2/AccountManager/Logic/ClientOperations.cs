using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountManager.DAL.EntityFramework;
using AccountManager.Domain;
using AccountManager.DTO;

namespace AccountManager.Logic
{
    class ClientOperations
    {

        private UnitOfWork iUOW;

        public ClientOperations(UnitOfWork pUnit)
        {
            this.iUOW = pUnit;
        }
    
        public void AltaClient (ClientDTO pClient)
        {

        }
    }
}
