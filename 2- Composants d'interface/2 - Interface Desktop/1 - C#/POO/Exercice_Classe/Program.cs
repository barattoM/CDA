using System;

namespace Exercice_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture("Citroën","C4",10000);
            Voiture v2 = new Voiture("Rouge","Renault", "Kadjar");

            v1.Rouler(2000);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }
    }
}
