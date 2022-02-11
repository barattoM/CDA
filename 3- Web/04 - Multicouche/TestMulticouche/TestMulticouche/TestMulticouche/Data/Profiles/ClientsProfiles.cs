using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMulticouche.Data.Dtos;
using TestMulticouche.Data.Models;

namespace TestMulticouche.Data.Profiles
{
    public class ClientsProfiles : Profile
    {
        public ClientsProfiles()
        {
            CreateMap<Client, ClientsDTO>();
            CreateMap<ClientsDTO, Client>();
        }
    }
}
