using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Dtos
{
    class PaysDTOIn
    {
        
        public string NomPays { get; set; }
    }

    class PaysDTO
    {
        public int IdPays { get; set; }
        public string NomPays { get; set; }
    }
}
