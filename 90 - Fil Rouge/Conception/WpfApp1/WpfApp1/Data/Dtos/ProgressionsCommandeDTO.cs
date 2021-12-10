using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Dtos
{
    class ProgressionsCommandeDTOIn
    {
        
        public int? IdCommande { get; set; }
        public int? IdEtatCommande { get; set; }
        public DateTime DateEtatCommande { get; set; }
    }

    class ProgressionsCommandeDTOOut
    {
        public int IdProgressionsCommande { get; set; }
        public int? IdCommande { get; set; }
        public string NumeroCommande { get; set; }
        public int? IdEtatCommande { get; set; }
        public string LibelleEtatCommande { get; set; }
        public DateTime DateEtatCommande { get; set; }
    }
}
