using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVoiture.Data.Dtos;
using TestVoiture.Data.Models;

namespace TestVoiture.Data.Profiles
{
    public class PersonnesProfile:Profile
    {
        public PersonnesProfile()
        {
            CreateMap<Personne, PersonnesDTO>();
            CreateMap<PersonnesDTO, Personne>();
            CreateMap<Personne, PersonnesDTOIn>();
            CreateMap<PersonnesDTOIn, Personne>();
            CreateMap<Personne, PersonnesDTOAvecVoiture>();
            CreateMap<PersonnesDTOAvecVoiture, Personne>();
        }
    }
}
