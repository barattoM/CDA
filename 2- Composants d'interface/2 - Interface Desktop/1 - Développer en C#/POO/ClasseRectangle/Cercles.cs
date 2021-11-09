using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseRectangle
{
    class Cercles
    {
        public int Diametre { get; set; }

        public Cercles()
        {
        }

        public Cercles(int diametre)
        {
            Diametre = diametre;
        }

        public double Perimetre()
        {
            return Math.PI * this.Diametre;
        }

        public double Aire()
        {
            return Math.PI * (this.Diametre / 2) * (this.Diametre / 2);
        }

        public string AfficherCercle()
        {
            return "Diamètre : "+this.Diametre+" - Périmètre : "+this.Perimetre()+" - Aire : "+this.Aire();
        }

    }
}
