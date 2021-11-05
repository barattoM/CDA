using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseCompte
{
    class Comptes
    {
        public double Solde { get; set; }
        public static int Code { get; set; }
        public int CodeCompte { get; set; }
        public Clients Proprietaire { get; set; }

        public Comptes(double solde, Clients proprietaire)
        {
            Solde = solde;
            Proprietaire = proprietaire;
            CodeCompte = Code;
            Code += 1;
        }
    }
}
