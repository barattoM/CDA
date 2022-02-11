using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMulticouche.Data.Dtos;
using TestMulticouche.Data.Models;

namespace TestMulticouche.Data.Profiles
{
    public class CommandesProfiles : Profile
    {
        public CommandesProfiles()
        {
            CreateMap<Commande, CommandesDTO>();
            CreateMap<CommandesDTO, Commande>();
        }
    }
}
