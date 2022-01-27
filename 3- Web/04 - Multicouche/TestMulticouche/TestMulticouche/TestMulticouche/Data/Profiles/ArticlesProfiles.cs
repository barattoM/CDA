using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMulticouche.Data.Dtos;
using TestMulticouche.Data.Models;

namespace TestMulticouche.Data.Profiles
{
    public class ArticlesProfiles : Profile
    {
        public ArticlesProfiles()
        {
            CreateMap<Article, ArticlesDTO>();
            CreateMap<ArticlesDTO, Article>();
        }
    }
}
