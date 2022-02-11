using System;
using System.Collections.Generic;

#nullable disable

namespace TestMulticouche.Data.Models
{
    public partial class Texte
    {
        public int IdTexte { get; set; }
        public string CodeTexte { get; set; }
        public string Fr { get; set; }
        public string En { get; set; }
    }
}
