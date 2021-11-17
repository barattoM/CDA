using System;

namespace ClasseRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangles r = new Rectangles(5,3);
            //Rectangles c = new Rectangles(5,5);
            //Console.WriteLine(r.AfficherRectangle());
            //Console.WriteLine(c.AfficherRectangle());
            //TrianglesRectangle t = new TrianglesRectangle(5,6);
            //Console.WriteLine(t.AfficherTriangle());
            //Cercles cercle = new Cercles(5);
            //Console.WriteLine(cercle.AfficherCercle());

            Parallelepipede p = new Parallelepipede(2,2,10);
            Pyramides py = new Pyramides(10,5,3);
            Sphere s = new Sphere(10);
            Console.WriteLine(p.Afficher());
            Console.WriteLine(py.Afficher());
            Console.WriteLine(s.Afficher());

        }
    }
}
