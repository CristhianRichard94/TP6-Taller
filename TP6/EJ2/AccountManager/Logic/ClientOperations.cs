using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountManager.DAL.EntityFramework;
using AccountManager.Domain;
using AccountManager.DTO;
using AutoMapper;

namespace AccountManager.Logic
{
    class ClientOperations
    {

        private UnitOfWork iUOW;

        public ClientOperations(UnitOfWork pUnit)
        {
            this.iUOW = pUnit;
        }
    
        public void CreateClient (ClientDTO pClient)
        {

            if (String.IsNullOrWhiteSpace(pClient.FirstName))
            {
                throw new Exception("No se ha ingresado nombre de cliente");
            }
            if (String.IsNullOrWhiteSpace(pClient.LastName))
            {
                throw new Exception("No se ha ingresado apellido de cliente");
            }
            if (String.IsNullOrWhiteSpace(pClient.DocumentNumber))
            {
                throw new Exception("No se ha ingresado Numero de documento");
            }
            if (pClient.DocumentType < 0)
            {
                throw new Exception("No se ha ingresado tipo de documento");
            }
            try
            {
                var client = Mapper.Map<Client>(pClient);
                this.iUOW.ClientRepository.Add(client);
                this.iUOW.Complete();
            }
            catch (Exception)
            {
                throw new Exception("Se produjo un error al guardar el cliente :(");
            }
        }
    }
}
