using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCombat
{
    class Joueurs
    {
        public int PDV { get; private set; }

        public Joueurs()
        {
            PDV = 50;
        }

        public bool EstVivant()
        {
            return this.PDV > 0;
        }

        public bool Attaque(MonstreFacile monstre, bool trace)
        {
            int deJoueur=Des.LanceLeDe();
            int deMonstre=Des.LanceLeDe();
            if (trace)
            {
                Console.WriteLine("Le joueur attaque : " + deJoueur + "   le monstre : " + deMonstre);
            }
            if (deJoueur>=deMonstre)
            {
                monstre.Vivant = false;
                return true;
            }
            return false;
        }

        public bool Attaque(MonstreDifficile monstre,bool trace)
        {
            int deJoueur = Des.LanceLeDe();
            int deMonstre = Des.LanceLeDe();
            if (trace)
            {
                Console.WriteLine("Le joueur attaque : "+deJoueur+"   le monstre : "+deMonstre);
            }
            if (deJoueur >= deMonstre)
            {
                monstre.Vivant = false;
                return true;
            }
            return false;
        }

        public int SubitDegats(int degats)
        {
            int deJoueur = Des.LanceLeDe();
            if (deJoueur<=2)
            {
                return 0;
            }
            this.PDV -=degats;
            return degats;
        }
    }
}
