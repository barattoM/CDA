using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseRectangle
{
    class TrianglesRectangle
    {
        public int Base { get; set; }
        public int Hauteur { get; set; }

        public TrianglesRectangle()
        {

        }

        public TrianglesRectangle(int @base, int hauteur)
        {
            Base = @base;
            Hauteur = hauteur;
        }

        public virtual double Perimetre()
        {
            return this.Base + this.Hauteur + Math.Sqrt(this.Base * this.Base + this.Hauteur * this.Hauteur);
        }

        public double Aire()
        {
            return (this.Base*this.Hauteur)/2;
        }

        public string AfficherTriangle()
        {
            return "Base : "+this.Base+" - Hauteur : "+this.Hauteur+" - Périmètre : "+this.Perimetre()+" - Aire : "+this.Aire();
        }
    }
}
