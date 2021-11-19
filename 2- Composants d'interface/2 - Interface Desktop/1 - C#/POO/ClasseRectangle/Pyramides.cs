using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseRectangle
{
    class Pyramides : TrianglesRectangle
    {
        public int Profondeur { get; set; }

        public Pyramides(int @base, int hauteur ,int profondeur) : base(@base,hauteur)
        {
            Profondeur = profondeur;
        }

        public override double Perimetre()
        {
            return 2 * base.Perimetre() + 3 * this.Profondeur;
        }

        public double Volume()
        {
            return base.Perimetre() * this.Profondeur;
        }

        public string Afficher()
        {
            return "Périmetre : " + this.Perimetre() + " - Volume : " + this.Volume();
        }
    }
}
