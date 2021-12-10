using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Dtos
{
    class RubriquesDTOIn
    {
        public string LibelleRubrique { get; set; }
        public int? IdRubriqueMere { get; set; }
    }

    class RubriquesRubriqueMereDTOOut
    {
        public int IdRubrique { get; set; }
        public string LibelleRubrique { get; set; }
        public string LibelleRubriqueMere { get; set; }
    }

    class RubriquesDTOOut
    {
        public int IdRubrique { get; set; }
        public string LibelleRubrique { get; set; }
    }
}
