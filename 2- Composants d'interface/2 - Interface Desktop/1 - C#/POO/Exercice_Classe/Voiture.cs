using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Classe
{
    class Voiture
    {
        //Propriété
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int NbKm { get; set; }
        public string Motorisation { get; set; }

        //Constructeur
        public Voiture(string marque, string modele)
        {
            Marque = marque;
            Modele = modele;
        }

        public Voiture(string couleur, string marque, string modele, int nbKm, string motorisation)
        {
            Couleur = couleur;
            Marque = marque;
            Modele = modele;
            NbKm = nbKm;
            Motorisation = motorisation;
        }

        public Voiture(string marque, string modele, int nbKm)
        {
            Marque = marque;
            Modele = modele;
            NbKm = nbKm;
        }

        public Voiture(string couleur, string marque, string modele)
        {
            Marque = marque;
            Modele = modele;
            Couleur = couleur;
        }



        //Methodes

        public override string ToString()
        {
            return "Cette voiture est une "+this.Modele+" de la marque "+this.Marque+" , de couleur "+this.Couleur+" , de motorisation "+this.Motorisation+" , avec Nb de kilomètres "+this.NbKm;
        }

        public void Rouler(int km)
        {
            this.NbKm += km;
        }
    }
}
