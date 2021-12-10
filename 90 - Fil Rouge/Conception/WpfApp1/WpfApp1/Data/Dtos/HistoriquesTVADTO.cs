using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Dtos
{
    class HistoriquesTVADTOIn
    {
        public int? IdProduit { get; set; }
        public int? IdTva { get; set; }
        public DateTime DateTva { get; set; }
    }

    class HistoriquesTVADTOOut
    {
        public int IdHistoriqueTva { get; set; }
        public int? IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public string RefProduit { get; set; }
        public int IdRubrique { get; set; }
        public string LibelleRubrique { get; set; }
        public int? IdTva { get; set; }
        public int TauxTVA { get; set; }
        public DateTime DateTva { get; set; }
    }
}
