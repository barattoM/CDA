using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseRectangle
{

    class Sphere : Cercles
    {
        public Sphere(int diametre):base(diametre)
        {
        }

        public double Volume()
        {
            return (4 / 3) * Math.PI * (this.Diametre / 2) * (this.Diametre / 2) * (this.Diametre / 2);
        }

        public string Afficher()
        {
            return "Périmetre : " + this.Perimetre() + " - Volume : " + this.Volume();
        }
    }
}
