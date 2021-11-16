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
            return 4 * this.Hauteur + 4 * this.Longueur * 4 * this.Largeur;
        }

        public double Volume()
        {
            return 
        }
    }
}
