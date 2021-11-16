using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    class Invaders
    {
        public string Motif { get; set; }

        public Invaders(string motif="#")
        {
            Motif = motif;
        }

        public override string ToString()
        {
            return this.Motif; 
        }
    }
}
