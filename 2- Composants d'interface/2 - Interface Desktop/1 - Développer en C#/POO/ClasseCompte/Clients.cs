using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseCompte
{
    class Clients
    {
        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }

        public Clients(string cIN, string nom, string prenom, string tel)
        {
            CIN = cIN;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
        }

        public Clients(string cIN, string nom, string prenom)
        {
            CIN = cIN;
            Nom = nom;
            Prenom = prenom;
        }

        public string Afficher()
        {
            return "CIN : " + this.CIN + " nom : " + this.Nom + " prenom : " + this.Prenom + " tel : " + this.Tel;
        }
    }
}
