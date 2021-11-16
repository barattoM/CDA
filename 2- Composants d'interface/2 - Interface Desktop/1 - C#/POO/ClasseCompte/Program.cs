using System;

namespace ClasseCompte
{
    class Program
    {
        static void Main(string[] args)
        {
            Clients client = new Clients("fjaozeifha0","Dupont","Toto","546584");
            Comptes compte = new Comptes(10000,client) ;
            Comptes compte2 = new Comptes(100010, client);
            compte2.Crediter(100,compte);
            Console.WriteLine(compte2.getSolde());
            Console.WriteLine(compte.getSolde());
            compte2.Debiter(100,compte);
            Console.WriteLine(compte2.getSolde());
            Console.WriteLine(compte.getSolde());
            Console.WriteLine(compte.ToString());
            Console.WriteLine(Comptes.NbComptes());
        }
    }
}
