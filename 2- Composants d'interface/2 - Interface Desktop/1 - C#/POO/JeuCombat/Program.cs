using System;

namespace JeuCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisation
            Joueurs joueur = new Joueurs();
            MonstreFacile monstre = new MonstreFacile();
            int degats;
            int nbMonstreTue=0;
            bool trace = true;
            if (Des.LanceLeDe() > 4)
            {
                monstre = new MonstreDifficile();
            }
            else
            {
                monstre = new MonstreFacile();
            }

            //Partie
            do
            {
                //Création du monstre
                if (!monstre.Vivant)
                {
                    Console.WriteLine("***************************** Monstre Suivant");
                    //Choix du type de monstre
                    if (Des.LanceLeDe() > 4)
                    {
                        monstre = new MonstreDifficile();
                    }
                    else
                    {
                        monstre = new MonstreFacile();
                    }
                }

                //Attaque du joueur
                if (joueur.Attaque(monstre,trace))
                {
                    Console.WriteLine("L'attaque a réussis, le monstre est mort");
                    nbMonstreTue++;
                }
                else //Le joueur a raté son attaque c'est au tour du monstre
                {
                    Console.WriteLine("Vous raté votre attaque");
                    degats = monstre.Attaque(trace);
                    if (degats==0) //Le monstre à raté son attaque
                    {
                        Console.WriteLine("L'attaque du monstre à raté !");
                    }
                    else //Le monstre réussis son attaque
                    {
                        //Affichage du dégats ou du blocage
                        if (joueur.SubitDegats(degats) == 0) // Le joueur a bloqué l'attaque du monstre
                        {
                            Console.WriteLine("Vous avez bloquer l'attaque du monstre");
                        }
                        else // Le Joueur a subit des dégats
                        {
                            Console.WriteLine("Vous subissez "+degats+" points de dégats");
                        }
                    }
                }

            }while (joueur.EstVivant());
            Console.WriteLine("Vous êtes mort, vous avez tué "+nbMonstreTue+" monstre");
        }
    }
}
