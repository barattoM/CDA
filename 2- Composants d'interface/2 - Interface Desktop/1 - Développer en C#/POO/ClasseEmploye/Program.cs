using System;
using System.Collections.Generic;

namespace ClasseEmploye
{
    class Program
    {
        static void Main(string[] args)
        {
            Enfants enf1 = new Enfants("afaef", "zeafcsqfvq", new DateTime(2018, 6, 1, 7, 47, 0));
            Enfants enf2 = new Enfants("afaef", "zeafcsqfvq", new DateTime(2009, 6, 1, 7, 47, 0));
            Enfants enf3 = new Enfants("afaef", "zeafcsqfvq", new DateTime(2000, 6, 1, 7, 47, 0));
            Enfants enf4 = new Enfants("afaef", "zeafcsqfvq", new DateTime(2004, 6, 1, 7, 47, 0));
            Agences a1 = new Agences("agence1","gdyuazgduyaz23","84561","uayzega","Restauration");
            Agences a2 = new Agences("agence2", "zafzaf874", "57451", "azdazfaf", "Sans Restauration");
            Employes e = new Employes("fdazfaz","ohr",new DateTime(2008, 6, 1, 7, 47, 0),"ttea",1210,"fazf46",a1,new List<Enfants> { enf1, enf4 });
            Employes e2 = new Employes("ioiuo", "sfz", new DateTime(2018, 6, 1, 7, 47, 0), "dzad", 1210, "272",a1, new List<Enfants> {enf2});
            Employes e3 = new Employes("p^d$azd", "hfiauef", new DateTime(2007, 6, 1, 7, 47, 0), "grgd", 1210, "eazd",a2, new List<Enfants> { enf2, enf3 }) ;
            Employes e4 = new Employes("zrazrra", "dafda65", new DateTime(2015, 6, 1, 7, 47, 0), "nytjr", 1210, "gnnn",a2, new List<Enfants> { enf3});
            Employes e5 = new Employes("azeaze", "578rter", new DateTime(2000, 6, 1, 7, 47, 0), "juulmo", 1210, "gnnn",a2);
            
            List<Employes> l = new List<Employes>();
            l.Add(e);
            l.Add(e2);
            l.Add(e3);
            l.Add(e4);
            l.Add(e5);

            l.Sort(Employes.CompareToNomPrenom);
            foreach (Employes elm in l)
            {
                Console.WriteLine(elm);
            }

            l.Sort(Employes.CompareToServiceNomPrenom);
            foreach (Employes elm in l)
            {
                Console.WriteLine(elm);
            }
            double masseSalariale = 0;

            foreach (Employes elm in l)
            {
                masseSalariale +=elm.MasseSalariale();
            }
            Console.WriteLine("Masse salariale : "+masseSalariale);
        }
    }
}
