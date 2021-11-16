using System;

namespace ClasseRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangles r = new Rectangles(5,3);
            Rectangles c = new Rectangles(5,5);
            Console.WriteLine(r.AfficherRectangle());
            Console.WriteLine(c.AfficherRectangle());
            TrianglesRectangle t = new TrianglesRectangle(5,6);
            Console.WriteLine(t.AfficherTriangle());
            Cercles cercle = new Cercles(5);
            Console.WriteLine(cercle.AfficherCercle());
        }
    }
}
