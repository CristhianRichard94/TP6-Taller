using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountManager.DAL;
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
    
        public void CreateCliente (ClientDTO pClient)
        {
            if (pClient.Id > -1)
            {
                throw new Exception("ID de cliente inválido");
            }

            if (pClient.DocumentType < 0)
            {
                throw new Exception("No se ha introducido un tipo de Documento");
            }

            if (String.IsNullOrWhiteSpace(pClient.DocumentNumber))
            {
                throw new Exception("No se ha introducido Documento de cliente");
            }

            if (String.IsNullOrWhiteSpace(pClient.FirstName))
            {
                throw new Exception("No se ha introducido Nombre de cliente");
            }

            if (String.IsNullOrWhiteSpace(pClient.LastName))
            {
                throw new Exception("No se ha introducido Nombre de cliente");
            }
            try
            {
                var cliente = Mapper.Map<Client>(pClient);
                this.iUOW.ClientRepository.Add(cliente);
                this.iUOW.Complete();
            }
            catch (Exception)
            {
                throw new Exception("Se ha producido un error al guardar el cliente");
            }
        }
    }
}
