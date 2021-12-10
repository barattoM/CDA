using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Dtos
{
    class ReglementsDTOIn
    {
        public string TypePaiement { get; set; }
    }

    class ReglementsDTOOut
    {
        public int IdReglement { get; set; }
        public string TypePaiement { get; set; }
    }
}
