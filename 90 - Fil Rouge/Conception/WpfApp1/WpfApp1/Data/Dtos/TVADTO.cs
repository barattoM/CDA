using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Dtos
{
    class TVADTOIn
    {
        public int? TauxTva { get; set; }
    }

    class TVADTOOut
    {
        public int IdTva { get; set; }
        public int? TauxTva { get; set; }
    }
}
