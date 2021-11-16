using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseRectangle
{
    class Rectangles
    {
        public int Longueur { get; set; }
        public int Largeur { get; set; }

        public Rectangles()
        {
        }

        public Rectangles(int longueur, int largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public virtual double Perimetre()
        {
            return (this.Largeur+this.Longueur)*2;
        }

        public double Aire()
        {
            return this.Longueur * this.Largeur;
        }

        public bool EstCarre()
        {
            if (this.Largeur==this.Longueur)
            {
                return true;
            }
            return false;
        }

        public string AfficherRectangle()
        {
            return "Longeur : "+this.Longueur+" - Largeur : "+this.Largeur+" - Périmètre : "+this.Perimetre()+" - Aire : "+this.Aire()+" - "+(this.EstCarre()?"Il s'agit d'un carré": "Il ne s’agit pas d’un carré");
        }
    }
}
