using System;
using System.Threading;


namespace SpaceInvaders
{
    class Program
    {
        static void Main(string[] args)
        {
            Space s = new Space(7,15);
            //foreach (var elm in s.Grille)
            //{
            //    foreach (var elm2 in elm)
            //    {
            //        Console.Write(elm2); 
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine(s);
            
            bool jeu = true;
            do
            {
                if (Console.ReadKey().Key==ConsoleKey.LeftArrow)
                {
                    s.AllerAGauche();

                }else if (Console.ReadKey().Key == ConsoleKey.RightArrow)
                {
                    s.AllerADroite();

                }else if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    s.Tirer();
                }
            } while (jeu);
        }
    }
}
