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
            //CreateMap<DTO.ClientDTO, Client>()
          //      .ForMember(d => d.Document, o => o.MapFrom(c => c.DocumentNumber));

        }
    }
}
