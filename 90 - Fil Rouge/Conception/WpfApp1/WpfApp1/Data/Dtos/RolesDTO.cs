using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data.Dtos
{
    class RolesDTOIn
    {
        public string LibelleRole { get; set; }
    }

    class RolesDTOOut
    {
        public int IdRole { get; set; }
        public string LibelleRole { get; set; }
    }
}
