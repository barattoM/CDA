using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMulticouche.Data.Dtos
{
    public class UtilisateursDTO
    {
        public int IdUtilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string AdresseMail { get; set; }
        public string MotDePasse { get; set; }
        public int Role { get; set; }
    }
}
