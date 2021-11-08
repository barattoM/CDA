using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseCompte
{
    class Comptes
    {
        private double solde;
        private static int Code;
        public int CodeCompte { get; set; }
        public Clients Proprietaire { get; set; }

        public Comptes(double solde, Clients proprietaire)
        {
            this.solde = solde;
            Proprietaire = proprietaire;
            Code += 1;
            CodeCompte = Code;
        }

        public double getSolde()
        {
            return this.solde;
        }

        public void Crediter(double somme)
        {
            this.solde += somme;
        }

        public void Crediter(double somme, Comptes compte)
        {
            this.Crediter(somme);
            compte.Debiter(somme);
        }

        public void Debiter(double somme)
        {
            this.solde -= somme;
        }

        public void Debiter(double somme, Comptes compte)
        {
            this.Debiter(somme);
            compte.Crediter(somme);
        }

        public override string ToString()
        {
            return "************************" +
                "\nNuméro de Compte: " +this.CodeCompte+
                "\nSolde de compte: " +this.getSolde()+
                "\nPropriétaire du compte:\n" +
                this.Proprietaire.Afficher()+
                "\n*************************";
        }

        public static string NbComptes()
        {
            return "Nombre de comptes créés : "+Comptes.Code;
        }
    }
}
