using System;
using System.Collections.Generic;

#nullable disable

namespace TestMulticouche.Data.Models
{
    public partial class Client
    {
        public Client()
        {
            Commandes = new HashSet<Commande>();
        }

        public int IdClient { get; set; }
        public string NomClient { get; set; }
        public string PrenomClient { get; set; }
        public DateTime? DateEntreeClient { get; set; }

        public virtual ICollection<Commande> Commandes { get; set; }
    }
}
