using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEmploye
{
    class Agences
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string ModeRestauration { get; set; }

        public Agences(string nom, string adresse, string codePostal, string ville, string modeRestauration)
        {
            Nom = nom;
            Adresse = adresse;
            CodePostal = codePostal;
            Ville = ville;
            ModeRestauration = modeRestauration;
        }

        public override string ToString()
        {
            return "Nom : "+this.Nom
                +"\nAdresse : "+this.Adresse
                + "\nCode Postal : " + this.CodePostal
                + "\nVille : " + this.Ville
                + "\nMode de restauration : " + this.ModeRestauration;
        }
    }
}
