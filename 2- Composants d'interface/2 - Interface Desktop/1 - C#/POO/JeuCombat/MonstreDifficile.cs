using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCombat
{
    class MonstreDifficile : MonstreFacile
    {
        public MonstreDifficile():base()
        {
        }

        public override int Attaque(bool trace)
        {
            int degats = base.Attaque(trace);
            int deMonstre = Des.LanceLeDe();
            if (trace)
            {
                Console.WriteLine("Le monstre attaque avec la magie : " + deMonstre);
            }
            if (deMonstre!=6)
            {
                return degats+deMonstre*5;
            }
            return degats;
        }
    }
}
