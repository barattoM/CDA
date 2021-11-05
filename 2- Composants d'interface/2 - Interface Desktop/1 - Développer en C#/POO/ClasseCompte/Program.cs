using System;

namespace ClasseCompte
{
    class Program
    {
        static void Main(string[] args)
        {
            Clients client = new Clients("fjaozeifha0","Dupont","Toto","546584");
            Comptes compte = new Comptes(10000,client) ;
            Console.WriteLine(compte.CodeCompte);
            Comptes compte2 = new Comptes(100010, client);
            Console.WriteLine(compte2.CodeCompte);
        }
    }
}
