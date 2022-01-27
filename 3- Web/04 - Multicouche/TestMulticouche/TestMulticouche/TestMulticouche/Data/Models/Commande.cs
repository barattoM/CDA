using System;
using System.Collections.Generic;

#nullable disable

namespace TestMulticouche.Data.Models
{
    public partial class Commande
    {
        public int IdCommande { get; set; }
        public int? IdClient { get; set; }
        public int? IdArticle { get; set; }
        public DateTime? DateCommande { get; set; }
        public int? QuantiteCommande { get; set; }
        public int? CdeTotal { get; set; }

        public virtual Article IdArticleNavigation { get; set; }
        public virtual Client IdClientNavigation { get; set; }
    }
}
