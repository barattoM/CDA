using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVoiture.Data.Dtos;
using TestVoiture.Data.Models;

namespace TestVoiture.Data.Profiles
{
    public class VoituresProfile : Profile
    {
        public VoituresProfile()
        {
            CreateMap<Voiture,VoituresDTO>();
            CreateMap<VoituresDTO,Voiture>();
            CreateMap<Voiture, VoituresDTOIn>();
            CreateMap<VoituresDTOIn, Voiture>();
            CreateMap<Voiture, VoituresDTOAvecPersonnes>();
            CreateMap<VoituresDTOAvecPersonnes, Voiture>();
        }
    }
}
