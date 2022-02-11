using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMulticouche.Data.Dtos
{
    public class ArticlesDTO
    {
        public int IdArticle { get; set; }
        public string DescriptionArticle { get; set; }
        public int? PrixArticle { get; set; }
    }
}
