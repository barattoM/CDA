using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace TestVoiture.Data.Models
{
    public partial class Personne
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int IdVoiture { get; set; }
        public Voiture? LaVoiture { get; set; }
    }
}
