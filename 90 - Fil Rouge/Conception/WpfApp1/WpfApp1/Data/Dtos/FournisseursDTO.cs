using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Dtos
{
    class FournisseursDTOIn
    {
        public string NomFournisseur { get; set; }
    }

    class FournisseursDTOOut
    {
        public int IdFournisseur { get; set; }
        public string NomFournisseur { get; set; }
    }
}
