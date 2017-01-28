using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountManager.DAL.EntityFramework;

namespace AccountManager.Logic
{
    class AccountOperations
    {
        private UnitOfWork iUOW;

        public AccountOperations (UnitOfWork pUnit)
        {
            this.iUOW = pUnit;
        }


    }
}
