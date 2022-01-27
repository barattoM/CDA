using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMulticouche.Data.Dtos
{
    public class ClientsDTO
    {
        public int IdClient { get; set; }
        public string NomClient { get; set; }
        public string PrenomClient { get; set; }
        public DateTime? DateEntreeClient { get; set; }
    }
}
