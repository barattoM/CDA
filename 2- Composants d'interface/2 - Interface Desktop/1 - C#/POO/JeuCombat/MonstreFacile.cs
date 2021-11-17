using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCombat
{
    class MonstreFacile
    {
        public bool Vivant { get; set; }

        public MonstreFacile()
        {
            Vivant = true;
        }

        public virtual int Attaque(bool trace)
        {
            int deJoueur = Des.LanceLeDe();
            int deMonstre = Des.LanceLeDe();
            if (trace)
            {
                Console.WriteLine("Le monstre attaque : " + deMonstre + "   le joueur : " + deJoueur);
            }
            if (deMonstre > deJoueur)
            {
                return deMonstre;
            }
            return 0;
        }
    }
}
