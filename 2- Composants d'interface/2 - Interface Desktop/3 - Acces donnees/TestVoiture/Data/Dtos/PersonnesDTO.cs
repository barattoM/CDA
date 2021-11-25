using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVoiture.Data.Models;

namespace TestVoiture.Data.Dtos
{
    public class PersonnesDTO
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public VoituresDTO LaVoiture { get; set; }
        
    }
}
