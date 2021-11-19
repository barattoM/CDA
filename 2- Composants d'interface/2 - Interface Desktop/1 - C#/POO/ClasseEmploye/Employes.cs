using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEmploye
{
    class Employes
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateEmbauche { get; set; }
        public string Poste { get; set; }
        public double Salaire { get; set; }
        public string Service { get; set; }
        public Agences Agence { get; set; }
        public List<Enfants> Enfants { get; set; } = new List<Enfants>();
        public static int NbEmploye { get; }

        public Employes(string nom, string prenom, DateTime dateEmbauche, string poste, double salaire, string service)
        {
            Nom = nom;
            Prenom = prenom;
            DateEmbauche = dateEmbauche;
            Poste = poste;
            Salaire = salaire;
            Service = service;
        }

        public Employes(string nom, string prenom, DateTime dateEmbauche, string poste, double salaire, string service, Agences agence)
        {
            Nom = nom;
            Prenom = prenom;
            DateEmbauche = dateEmbauche;
            Poste = poste;
            Salaire = salaire;
            Service = service;
            Agence = agence;
        }

        public Employes(string nom, string prenom, DateTime dateEmbauche, string poste, double salaire, string service, Agences agence, List<Enfants> enfants)
        {
            Nom = nom;
            Prenom = prenom;
            DateEmbauche = dateEmbauche;
            Poste = poste;
            Salaire = salaire;
            Service = service;
            Agence = agence;
            Enfants = enfants;
        }

        public static int  getNbEmploye()
        {
            return Employes.NbEmploye;
        }

        public int Anciennete()
        {
            DateTime auj = DateTime.Now;
            TimeSpan t = auj-this.DateEmbauche;
            return (int)(t.TotalDays / 365);
        }

        public double PrimeAnnuelle()
        {
            double prime = 0.05 * this.Salaire + 0.02 * this.Anciennete();
            if (DateTime.Now.Date.ToString("dd/MM") =="30/11")
            {
                Console.WriteLine("L'ordre de transfert d'un montant de "+prime+" a été envoyé à la banque");               
            }
            return prime;
        }

        public double MasseSalariale()
        {
            return this.PrimeAnnuelle()+this.Salaire;
        }

        public bool ChequeVacance()
        {
            return this.Anciennete()>=1;
        }

        public override string ToString()
        {
            string phrase = "*****************" +
                "\nNom : " + this.Nom +
                "\nPrenom : " + this.Prenom +
                "\nDate d'embauche : " + this.DateEmbauche.ToString("dd/MM/yyyy") +
                "\nPoste : " + this.Poste +
                "\nSalaire : " + this.Salaire +
                "\nService : " + this.Service +
                "\n+++++ Agence ++++" +
                "\n" + this.Agence +
                "\n+++++++++++++++++"+
                "\n---- Enfants ----";
            if (this.Enfants.Count!=0)
            {
                for (int i = 0; i < this.Enfants.Count; i++)
                {
                    phrase += "\n"+Enfants[i]+
                        "\n$$$$$$$$$$$";
                }
            }
            else
            {
                phrase += "\nPas d'enfants";
            }
            
            phrase += "\n--------------" +
                "\n*****************\n\n" ;
            return phrase;
        }

        public static int CompareToNomPrenom(Employes e1,Employes e2)
        {
            if (e1.Nom==e2.Nom)
            {
                if (String.Compare(e1.Prenom, e2.Prenom)==1)
                {
                    return 1;
                }
                else if(String.Compare(e1.Prenom, e2.Prenom) == -1)
                {
                    return -1;
                }
                return 0;
            }
            else if(String.Compare(e1.Nom, e2.Nom) == 1)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static int CompareToServiceNomPrenom(Employes e1, Employes e2)
        {
            if (e1.Service==e2.Service)
            {
                return Employes.CompareToNomPrenom(e1,e2);
            }
            else if(String.Compare(e1.Service, e2.Service) == 1)
            {
                return 1;
            }
            else
            {
                return -1;
            }
            
        }
    }
}
