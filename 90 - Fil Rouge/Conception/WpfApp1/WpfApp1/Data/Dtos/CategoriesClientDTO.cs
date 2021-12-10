using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Dtos
{
    class CategoriesClientDTOIn
    {
        public string LibelleCategClient { get; set; }
        public string InfoReglement { get; set; }
        public int CoefCategClient { get; set; }
    }

    class CategoriesClientDTOOut
    {
        public int IdCategorieClient { get; set; }
        public string LibelleCategClient { get; set; }
        public string InfoReglement { get; set; }
        public int CoefCategClient { get; set; }
    }
}
