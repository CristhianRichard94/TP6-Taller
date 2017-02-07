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
    public class ClientOperations
    {

        private UnitOfWork iUOW;

        public ClientOperations(UnitOfWork pUnit)
        {
            this.iUOW = pUnit;
        }
    
        public void CreateClient (ClientDTO pClient)
        {
            try
            {
                Client client = Mapper.Map<Client>(pClient);
                this.iUOW.ClientRepository.Add(client);
                this.iUOW.Complete();
            }
            catch (Exception)
            {
                throw new Exception("Se ha producido un error al Crear el Cliente");
            }
        }

        public void UpdateClient(ClientDTO pClient)
        {

            if (String.IsNullOrWhiteSpace(pClient.FirstName))
            {
                throw new Exception("No se ha ingresado nuevo Nombre");
            }
            if (String.IsNullOrWhiteSpace(pClient.LastName))
            {
                throw new Exception("No se ha ingresado nuevo Apellido");
            }
            if (String.IsNullOrWhiteSpace(pClient.DocumentNumber))
            {
                throw new Exception("No se ha ingresado nuevo numero de Documento");
            }
            if (pClient.DocumentType < 0)
            {
                throw new Exception("No se ha ingresado nuevo tipo de Documento");
            }

            var client = this.iUOW.ClientRepository.Get(pClient.Id);
            if (client == null)
            {
                throw new Exception("No se ha encontrado el cliente a modificar en la Base de datos");
            }

            client.FirstName = pClient.FirstName;
            client.LastName = pClient.LastName;
            client.Document = new Document { Number = pClient.DocumentNumber,
                                             Type = pClient.DocumentType };
            this.iUOW.Complete();
        }

        public void DeleteClient(ClientDTO pClient)
        {
            Client client;
            try
            {
                client = this.iUOW.ClientRepository.Get(pClient.Id);
            }
            catch (Exception)
            {
                throw new Exception("Se ha producido un error al intentar eliminar el cliente");
            }

            this.iUOW.ClientRepository.Remove(client);
            this.iUOW.Complete();
        }

        public ClientDTO GetClient(int pId)
        {
            Client client = this.iUOW.ClientRepository.Get(pId);
            if (client == null)
            {
                throw new Exception("No existe el cliente que busca");
            }
            return Mapper.Map<ClientDTO>(client);
        }

        public IEnumerable<ClientDTO> GetAllClients()
        {
            IEnumerable<Client> list;

            try
            {
                list = this.iUOW.ClientRepository.GetAll();
            }

            catch (Exception)
            {
                throw new Exception("Se ha producido un error al obtener la lista");
            }

            return Mapper.Map<IEnumerable<ClientDTO>>(list);
        }

    }
}
