using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AccountManager.DTO;

namespace AccountManager.Domain
{
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
            CreateMap<DTO.ClientDTO, Client>()
                .ForMember(d => d.Document, o => o.MapFrom(c => new Document { Number=c.DocumentNumber,
                                                                               Type=c.DocumentType }))
                .ForMember(d => d.FirstName, o => o.MapFrom(c => c.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(c => c.LastName))
                .ForMember(d => d.Id, o => o.MapFrom(c => c.Id))
                .ForMember(d => d.Accounts, o=> o.Ignore());
            CreateMap<Client, DTO.ClientDTO>()
                .ForMember(d => d.DocumentNumber, o => o.MapFrom(c => c.Document.Number))
                .ForMember(d => d.DocumentType, o => o.MapFrom(c => c.Document.Type))
                .ForMember(d => d.FirstName, o => o.MapFrom(c => c.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(c => c.LastName))
                .ForMember(d => d.Id, o => o.MapFrom(c => c.Id));
        }
    }
}
