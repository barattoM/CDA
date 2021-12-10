using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Dtos
{

    class ClientsDTOIn
    {
        
        public string RefClient { get; set; }
        public int CoefClient { get; set; }
        public int IdCategorieClient { get; set; }
    }

    class ClientsDTOOut
    {
        public int IdUser { get; set; }
        public string RefClient { get; set; }
        public int CoefClient { get; set; }
        public int IdCategorieClient { get; set; }
    }
}
