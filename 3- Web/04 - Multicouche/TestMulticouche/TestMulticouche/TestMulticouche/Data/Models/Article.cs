using System;
using System.Collections.Generic;

#nullable disable

namespace TestMulticouche.Data.Models
{
    public partial class Article
    {
        public Article()
        {
            Commandes = new HashSet<Commande>();
        }

        public int IdArticle { get; set; }
        public string DescriptionArticle { get; set; }
        public int? PrixArticle { get; set; }

        public virtual ICollection<Commande> Commandes { get; set; }
    }
}

