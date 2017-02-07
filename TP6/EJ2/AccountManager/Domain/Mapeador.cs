﻿using System;
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
                .ForMember(d => d.Document.Number, o => o.MapFrom(c => c.DocumentNumber))
                .ForMember(d => d.Document.Type, o => o.MapFrom(c => c.DocumentType))
                .ForMember(d => d.FirstName, o => o.MapFrom(c => c.FirstName))
                .ForMember(d => d.LastName, o => o.MapFrom(c => c.LastName))
                .ForMember(d => d.Id, o => o.MapFrom(c => c.Id));
        }
    }
}
