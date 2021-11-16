using System;
using System.Collections.Generic;

namespace PetitsChevaux
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////Initialisation\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            int nombrePion;
            int nombreJoueur;
            string nomJoueur;
            string couleurJoueur;
            string[] tableauCouleur = new string[4] { "rouge", "vert", "bleu", "jaune" };
            List<Joueurs> listeJoueur=new List<Joueurs>();
            //Demande du nombre de chevaux (pions)
            do
            {
                Console.WriteLine("Combien de chevaux ? ");
            } while (int.TryParse(Console.ReadLine(),out nombrePion)==false || nombrePion<=0);

            //Demande du nombre de joueurs
            do
            {
                Console.WriteLine("Combien de joueurs ? ");
            } while (int.TryParse(Console.ReadLine(), out nombreJoueur) == false || nombreJoueur <= 1);

            //Initialisation du plateau

            //Demande informations sur les joueurs

            for (int i=1;i<=nombreJoueur;i++)
            {
                //Nom du joueur
                do
                {
                    Console.WriteLine("Quel est le nom du joueur "+i+" ? ");
                    nomJoueur = Console.ReadLine();
                } while (nomJoueur=="");
                //Couleur du joueur
                do
                {
                    Console.WriteLine("Quel est la couleur du joueur 1 ? (rouge, vert, bleu, jaune)");
                    couleurJoueur = Console.ReadLine().ToLower();
                } while (!Array.Exists(tableauCouleur, elm => elm == couleurJoueur));

                //listeJoueur.Add(new Joueurs(nomJoueur, couleurJoueur));

            }
            
            

            //Affichage du plateau

            //Suppression de variables d'initialisation
            nomJoueur = null;
            couleurJoueur = null;
            tableauCouleur = null;
            GC.Collect();

            /////////////////////////////////Fin Initialisation\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        }
    }
}
