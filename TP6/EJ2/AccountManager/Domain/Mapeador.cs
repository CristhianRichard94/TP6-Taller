﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AccountManager.DTO;

namespace AccountManager.Domain
{/// <summary>
///Clase mapeadora, se encarga de detallar el mapeo entre las distintas clases.
/// </summary>
    class Mapeador : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "CustomDTO";
            }
        }

        public Mapeador()
        {
            CreateMap<ClientDTO, Client>()
                .ForMember(d => d.Document, o => o.MapFrom(c => new Document { Number=c.DocumentNumber,
                                                                               Type=c.DocumentType }))
                .ForMember(d => d.FirstName, o => o.MapFrom(c => c.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(c => c.LastName))
                .ForMember(d => d.Id, o => o.MapFrom(c => c.Id))
                .ForMember(d => d.Accounts, o=> o.Ignore());
            CreateMap<Client, ClientDTO>()
                .ForMember(d => d.DocumentNumber, o => o.MapFrom(c => c.Document.Number))
                .ForMember(d => d.DocumentType, o => o.MapFrom(c => c.Document.Type))
                .ForMember(d => d.FirstName, o => o.MapFrom(c => c.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(c => c.LastName))
                .ForMember(d => d.Id, o => o.MapFrom(c => c.Id));

            CreateMap<AccountDTO, Account>()
                .ForMember(d => d.Id, o => o.MapFrom(c => c.Id))
                .ForMember(d => d.Name, o => o.MapFrom(c => c.Name))
                .ForMember(d => d.OverdraftLimit, o => o.MapFrom(c => c.OverdraftLimit))
                .ForMember(d => d.Client, o => o.Ignore())
                .ForMember(d => d.Movements, o => o.Ignore());

            CreateMap<Account, AccountDTO>()
                .ForMember(d => d.Id, o => o.MapFrom(c => c.Id))
                .ForMember(d => d.Name, o => o.MapFrom(c => c.Name))
                .ForMember(d => d.OverdraftLimit, o => o.MapFrom(c => c.OverdraftLimit))
                .ForMember(d => d.ClientId, o => o.MapFrom(c => c.Client.Id));

            CreateMap<AccountMovement, AccountMovementDTO>()
                .ForMember(d => d.Id, o => o.MapFrom(c => c.Id))
                .ForMember(d => d.Date, o => o.MapFrom(c => c.Date))
                .ForMember(d => d.Description, o => o.MapFrom(c => c.Description))
                .ForMember(d => d.Amount, o => o.MapFrom(c => c.Amount));

            CreateMap<AccountMovementDTO, AccountMovement>()
                .ForMember(d => d.Id, o => o.MapFrom(c => c.Id))
                .ForMember(d => d.Date, o => o.MapFrom(c => c.Date))
                .ForMember(d => d.Description, o => o.MapFrom(c => c.Description))
                .ForMember(d => d.Amount, o => o.MapFrom(c => c.Amount));
        }
    }
}
