using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountManager.DAL.EntityFramework;
using AccountManager.Domain;

namespace AccountManager.Logic
{
    public class Facade
    {
        private ClientOperations iClient;
        private AccountOperations iAccount;
        /// <summary>
        /// Constructor de la fachada, utiliza un mapeador personalizado para transformar los obejetos DTO para la base de datos
        /// </summary>
        /// <param name="pUOW"></param>
        public Facade(UnitOfWork pUOW)
        {
            AutoMapper.Mapper.Initialize(c => c.AddProfile(new Mapeador()));
            this.iClient = new ClientOperations(pUOW);
            this.iAccount = new AccountOperations(pUOW);
        }

        public ClientOperations Client { get { return this.iClient; } }
        public AccountOperations Account { get { return this.iAccount; } }
    }
}
