using System;
using System.Collections.Generic;

#nullable disable

namespace WpfApp1.Data.Models
{
    public partial class Livraison
    {
        public int IdLivraison { get; set; }
        public int? IdCommande { get; set; }
        public int? IdAdresse { get; set; }
        public DateTime? DateLivraison { get; set; }
        public int? QuantiteLivraison { get; set; }

        public virtual Adresse Adresse { get; set; }
        public virtual Commande Commande { get; set; }
    }
}
