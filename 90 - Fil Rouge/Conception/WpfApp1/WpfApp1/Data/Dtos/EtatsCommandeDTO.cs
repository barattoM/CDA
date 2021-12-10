using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Dtos
{
    class EtatsCommandeDTOIn
    {
        public string LibelleEtatCommande { get; set; }
    }

    class EtatsCommandeDTOOut
    {
        public int IdEtatCommande { get; set; }
        public string LibelleEtatCommande { get; set; }
    }
}
