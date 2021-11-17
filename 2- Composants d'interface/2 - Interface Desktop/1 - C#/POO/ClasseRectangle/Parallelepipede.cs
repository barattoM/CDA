using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseRectangle
{
    class Parallelepipede : Rectangles
    {
        public int Hauteur { get; set; }

        public Parallelepipede(int longueur,int largeur, int hauteur)
        {
            Hauteur = hauteur;
            this.Largeur=largeur;
            this.Longueur=longueur;
        }

        public override double Perimetre()
        {
            return 2*base.Perimetre() +4 * this.Hauteur;
        }

        public double Volume()
        {
            return base.Aire()+this.Hauteur;
        }

        public string Afficher()
        {
            return "Périmetre : "+this.Perimetre()+" - Volume : "+this.Volume();
        }
    }
}
