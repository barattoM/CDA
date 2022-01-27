using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMulticouche.Data.Dtos
{
    public class CommandesDTO
    {
        public int IdCommande { get; set; }
        public int? IdClient { get; set; }
        public int? IdArticle { get; set; }
        public DateTime? DateCommande { get; set; }
        public int? QuantiteCommande { get; set; }
        public int? CdeTotal { get; set; }
    }
}
