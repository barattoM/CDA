using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Dtos
{
    class LignesCommandeDTOIn
    {
        public int? IdProduit { get; set; }
        public int? IdCommande { get; set; }
        public int? QuantiteProduit { get; set; }
    }

    class LignesCommandeDTOOut
    {
        public int IdLigneCommande { get; set; }
        public int? IdProduit { get; set; }
        public string RefProduit { get; set; }
        public string LibelleProduit { get; set; }
        public decimal PrixHorsTaxes { get; set; }
        public int? IdCommande { get; set; }
        public string NumeroCommande { get; set; }
        public DateTime DateCommande { get; set; }
        public int? QuantiteProduit { get; set; }
    }
}
