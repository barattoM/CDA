using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStocks.Data.Dtos
{
    class ArticlesDTO
    {
        public string LibelleArticle { get; set; }
        public int QuantiteStockee { get; set; }
    }

    class ArticlesDTOIn
    {
        public string LibelleArticle { get; set; }
        public int QuantiteStockee { get; set; }
    }

}
