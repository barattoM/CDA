using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetitsChevaux
{
    class Joueurs
    {
        public string Nom { get; set; }
        public string Couleur { get; set; }
        public List<Pions> Pions { get; set; }
        public Cases CaseDepart { get; set; }
        public Cases CaseArrive { get; set;}

        public Joueurs(string nom, string couleur, List<Pions> pions, Cases caseDepart, Cases caseArrive)
        {
            Nom = nom;
            Couleur = couleur;
            Pions = pions;
            CaseDepart = caseDepart;
            CaseArrive = caseArrive;
        }
    }
}
