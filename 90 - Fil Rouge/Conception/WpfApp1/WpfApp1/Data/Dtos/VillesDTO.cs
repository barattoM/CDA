using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Dtos
{
    class VillesDTOIn
    {
        public string LibelleVille { get; set; }
        public string CodePostal { get; set; }
        public int IdPays { get; set; }
    }

    class VillesDTOOut
    {
        public int IdVille { get; set; }
        public string LibelleVille { get; set; }
        public string CodePostal { get; set; }
        public int IdPays { get; set; }
        public string NomPays { get; set; }
    }
}
