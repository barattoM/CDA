using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_produits
{
    public class Produits
    {
        public Produits()
        {
        }

        public int IdProduit { get; set; }
        public string Libelle { get; set; }
        public string Categorie { get; set; }
        public int Rayon { get; set; }

        public Produits(int idProduit, string libelle, string categorie, int rayon)
        {
            IdProduit = idProduit;
            Libelle = libelle;
            Categorie = categorie;
            Rayon = rayon;
        }
    }
}
