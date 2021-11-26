using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestVoiture.Data.Dtos
{
    public class PersonnesDTOIn
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int IdVoiture { get; set; }
    }
}
