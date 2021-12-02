using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestVoiture.Data.Dtos
{
    public class VoituresDTO
    {
        public string Marque { get; set; }
        public string Modele { get; set; }
    }

    public class VoituresDTOAvecPersonnes
    {
        public string Marque { get; set; }
        public string Modele { get; set; }
        public ICollection<PersonnesDTO> LesPersonnes { get; set; }
    }

    public class VoituresDTOIn
    {
        public string Marque { get; set; }
        public string Modele { get; set; }
    }
}
