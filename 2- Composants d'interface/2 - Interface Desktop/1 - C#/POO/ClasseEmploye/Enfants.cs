using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEmploye
{
    class Enfants
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public Enfants(string nom, string prenom, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public int Age()
        {
            DateTime auj = DateTime.Now;
            TimeSpan t = auj - this.DateNaissance;
            return (int)(t.TotalDays / 365);
        }

        public int ChequeNoel()
        {
            int age = this.Age();
            if (age<=10)
            {
                return 20;
            }else if (age <= 15)
            {
                return 30;
            }
            else if(age<18)
            {
                return 50;
            }
            return 0;
        }

        public override string ToString()
        {
            string phrase="Nom : "+this.Nom+
                "\nPrenom : "+this.Prenom+
                "\nDate de naissance "+this.DateNaissance.ToString("dd/MM/yyyy");
            int montant = this.ChequeNoel();
            if (montant>0)
            {
                phrase+="\nChèque de Noël de : "+montant;
            }
            return phrase;
        }
    }
}
