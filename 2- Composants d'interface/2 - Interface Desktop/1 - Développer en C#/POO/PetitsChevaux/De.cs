using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetitsChevaux
{
    class De
    {
        static Random rand = new Random();
        public static int LancerDe()
        {
            return rand.Next(1,7);
        }
    }
}
