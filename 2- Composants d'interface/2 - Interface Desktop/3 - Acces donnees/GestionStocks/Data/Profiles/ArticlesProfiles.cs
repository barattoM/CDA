﻿using AutoMapper;
using GestionStocks.Data.Dtos;
using GestionStocks.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStocks.Data.Profiles
{
    class ArticlesProfiles:Profile
    {
        public ArticlesProfiles()
        {
            CreateMap<Article, ArticlesDTO>();
            CreateMap<ArticlesDTO, Article>();
            CreateMap<Article, ArticlesDTOIn>();
            CreateMap<ArticlesDTOIn, Article>();
            CreateMap<Article, ArticlesDTOAvecLibelleCategorie>();
            CreateMap<ArticlesDTOAvecLibelleCategorie, Article>();
            CreateMap<Article, ArticlesDTOAvecLibelleCategorie>().ForMember(d => d.LibelleCategorie, o => o.MapFrom(s => s.Categorie.LibelleCategorie));
        }
        
    }
}
