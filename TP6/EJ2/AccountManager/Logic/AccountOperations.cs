using AutoMapper;
using AccountManager.DAL.EntityFramework;
using AccountManager.Domain;
using AccountManager.DTO;
using System;
using System.Collections.Generic;

namespace AccountManager.Logic
{
    public class AccountOperations
    {
        private UnitOfWork iUOW;

        public AccountOperations (UnitOfWork pUnit)
        {
            this.iUOW = pUnit;
        }

        /// <summary>
        /// Crea una nueva cuenta
        /// </summary>
        /// <param name="pAccount"></param>
        public void CreateAccount(AccountDTO pAccount)
        {
           
            if (String.IsNullOrWhiteSpace(pAccount.Name))
            {
                throw new Exception("Introduzca un nombre para la cuenta");
            }
            ///Controla el límite al descubierto
            if (pAccount.OverdraftLimit > 1000)
            {
                throw new Exception("El límite de descubierto es 1000");
            }
            var client = this.iUOW.ClientRepository.Get(pAccount.ClientId);
            if (client == null)
            {
               throw new Exception("El cliente no existe");
            }
            try
            {
                Account account = Mapper.Map<Account>(pAccount);
                account.Movements = new List<AccountMovement>();
                account.Client = client;


                this.iUOW.AccountRepository.Add(account);
                this.iUOW.Complete();
            }
            catch (Exception)
            {
                throw new Exception("Se ha producido un error, intente nuevamente");
            }
        }

        /// <summary>
        /// Se modifica una cuenta que ya existe 
        /// </summary>
        /// <param name="pAccount"></param>
        public void UpdateAccount(AccountDTO pAccount)
        {

            if (pAccount.Id < 0)
            {
                throw new Exception("El ID ingresado es inválido");
            }
            if (String.IsNullOrWhiteSpace(pAccount.Name))
            {
                throw new Exception("Ingrese un Nombre para la cuenta");
            }
            //Controla el límite de descubierto
            if (pAccount.OverdraftLimit < 1000)
            {
                throw new Exception("El límite de descubierto es 1000");
            }
            var client = this.iUOW.ClientRepository.Get(pAccount.ClientId);
            if (client == null)
            {
                throw new Exception("El cliente ingresado no existe");
            }
            var account = this.iUOW.AccountRepository.Get(pAccount.Id);
            if (account == null)
            {
                throw new Exception("La cuenta que desea modificar no existe en el sistema");
            }
            account.Name = pAccount.Name;
            account.OverdraftLimit = pAccount.OverdraftLimit;
            account.Client = client;

            this.iUOW.Complete();
        }

        /// <summary>
        /// Se elimina una cuenta que ya existe
        /// </summary>
        /// <param name="pAccount"></param>
        public void DeleteAccount(AccountDTO pAccount)
        {
            Account account;
            try
            {
                account = this.iUOW.AccountRepository.Get(pAccount.Id);
            }
            catch (Exception)
            {
                throw new Exception("Error eliminando la cuenta");
            }
           this.iUOW.AccountRepository.Remove(account);

            this.iUOW.Complete();
        }

        /// <summary>
        /// Busca una cuenta por su ID
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public AccountDTO GetAccount(int pId)
        {
            var account = this.iUOW.AccountRepository.Get(pId);
            if (account == null)
            {
                throw new Exception("El ID es inexistente");
            }
            return Mapper.Map<AccountDTO>(account);
        }

        /// <summary>
        /// Metodo para registrar nuevos movimient os de la cuenta
        /// </summary>
        /// <param name="pAccount"></param>
        /// <param name="pAmount"></param>
        /// <param name="pDescription"></param>

        public void NewMovement(AccountDTO pAccount, String pDescription, double pAmount)
        {
            Account account;
            account = this.iUOW.AccountRepository.Get(pAccount.Id);

            if (account == null)
            {
                throw new Exception("El ID es incorrecto");
            }
            account.Movements.Add(new AccountMovement(DateTime.Now, pDescription, pAmount));
            this.iUOW.Complete();
        }

        /// <summary>
        /// Se obtienen todas las cuentas registradas 
        /// </summary>
            public IEnumerable<AccountDTO> GetAllAccounts()
        {
            IEnumerable<Account> list;
            try
            {
                list = this.iUOW.AccountRepository.GetAll();
            }
            catch (Exception)
            {
                throw new Exception("Error al intentar obtener la lista");
            }

            return Mapper.Map<IEnumerable<AccountDTO>>(list);
            
        }

        /// <summary>
        /// Se obtienen las cuentas que superaron el límite de descubierto
        /// </summary>
        public IEnumerable<AccountDTO> GetAllOverdrawnAccounts()
        {
            IEnumerable<Account> list;
            try
            {
                list = this.iUOW.AccountRepository.GetOverdrawnAccounts();
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener las cuentas");
            }

            return Mapper.Map<IEnumerable<AccountDTO>>(list);
        }

        /// <summary>
        /// Balance de una cuenta
        /// </summary>
        /// <param name="pAccount"></param>
        public double GetBalance(AccountDTO pAccount)
        {
            var account = this.iUOW.AccountRepository.Get(pAccount.Id);
            if (account == null)
            {
                throw new Exception("La cuenta no existe");
            }
            try
            {
                return this.iUOW.AccountRepository.GetAccountBalance(account);
            }
            catch (Exception)
            {
                throw new Exception("No se ha podido realizar el balance");
            }
        }

        /// <summary>
        /// Obtiene los ultimos movimietos de la cuenta, por defecto: 7
        /// </summary>
        /// <param name="pAccount"></param>
        /// <param name="pC"></param>
        public IEnumerable<AccountMovementDTO> GetLastMovements(AccountDTO pAccount, int pC = 0)
        {
            IEnumerable<AccountMovement> movs;
            Account account = this.iUOW.AccountRepository.Get(pAccount.Id);
            if (account == null)
            {
                throw new Exception("La cuenta es inexistente");
            }
            try
            {
                if (pC > 0)
                {
                    movs = this.iUOW.AccountRepository.GetLastMovements(account, pC);
                }
                else
                {
                    movs = this.iUOW.AccountRepository.GetLastMovements(account);
                }
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener los ultimos movimientos");
            }

            return Mapper.Map<IEnumerable<AccountMovementDTO>>(movs);
        }
    }
}

