using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace TestVoiture.Data.Models
{
    public partial class Voiture
    {
        [Key]
        public int Id { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
    }
}
