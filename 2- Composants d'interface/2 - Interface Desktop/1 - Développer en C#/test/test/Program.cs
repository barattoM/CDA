using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////// VARIABLES \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            //EXERCICE 1

            /*Console.WriteLine("Tapez votre nom");
            string nom;
            nom=Console.ReadLine();
            Console.WriteLine("Votre nom est "+nom);*/

            //EXERCICE 2

            /*Console.WriteLine("Tapez un nombre");
            string nom;
            nom = Console.ReadLine();
            Console.WriteLine("Votre nombre est " + nom);*/

            //ECERCICE 3
            //string nb1;
            //string nb2;
            //int somme;
            //Console.WriteLine("Tapez un nombre");
            //nb1 = Console.ReadLine();
            //Console.WriteLine("Tapez un 2e nombre");
            //nb2 = Console.ReadLine();
            //somme = int.Parse(nb1) + int.Parse(nb2);
            //Console.WriteLine("Votre nombre est " + somme);

            //ECERCICE 4

            /*Console.WriteLine("Tapez un float");
            double nom;
            nom = float.Parse(Console.ReadLine());
            Console.WriteLine("Votre nombre est " + nom);*/

            //EXERCICE 5

            /*string nb1;
            string nb2;
            string nb3;
            double moy;
            Console.WriteLine("Tapez un nombre");
            nb1 = Console.ReadLine();
            Console.WriteLine("Tapez un 2e nombre");
            nb2 = Console.ReadLine();
            Console.WriteLine("Tapez un 3e nombre");
            nb3 = Console.ReadLine();
            moy =(float.Parse(nb1) + float.Parse(nb2)+ float.Parse(nb3))/3;
            Console.WriteLine(moy);*/

            //EXERCICE 6

            /*double l;
            double L;
            double surface;
            Console.WriteLine("largeur");
            l = float.Parse(Console.ReadLine());
            Console.WriteLine("longueur");
            L = float.Parse(Console.ReadLine());
            surface = l * L;
            Console.WriteLine("La surface du rectangle est : " + surface);*/

            //EXERCICE 7

            /*char c='a';
            Console.WriteLine("caractère : " + c + " Unicode : " + (int)c);*/

            //EXERCICE 8

            /*string l;
            Console.WriteLine("chaine de caractère");
            l = Console.ReadLine();
            Console.WriteLine(l.ToUpper());*/

            ////////////////////////////////////////////// Opérateurs Conversions \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            //EXERCICE 1

            /*char l;
            char ll;
            Console.WriteLine("caractère");
            l = char.Parse(Console.ReadLine());
            ll = (char) ((int)l + 1);
            Console.WriteLine(ll);*/

            //EXERCICE 2

            /*char a = '0';
            char b = '1';
            char c= '2';
            char d = '3';
            char e = '4';
            char f = '5';
            char g = '6';
            char h = '7';
            char i = '8';
            char j = '9';
            Console.WriteLine("0 : "+(int)a);
            Console.WriteLine("1 : " + (int)b);
            Console.WriteLine("2 : " + (int)c);
            Console.WriteLine("3 : " + (int)d);
            Console.WriteLine("4 : " + (int)e);
            Console.WriteLine("5 : " + (int)f);
            Console.WriteLine("6 : " + (int)g);
            Console.WriteLine("7 : " + (int)h);
            Console.WriteLine("8 : " + (int)i);
            Console.WriteLine("9 : " + (int)j);*/

            //EXERCICE 3

            /*float M = float.Parse(Console.ReadLine());
            float k = float.Parse(Console.ReadLine());
            Console.WriteLine((int)(M / k));*/

            //EXERCICE 4

            ////////////////////////////////////////////// Traitements Conditionnels \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            //EXERCICE 1

            /*Console.WriteLine("Votre age ?");
            int age = int.Parse(Console.ReadLine());
            if (age>=18)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur (UNE MINE)");
            }*/

            //EXERCICE 2

            /*Console.WriteLine("Donnez une valeur");
            int nb = int.Parse(Console.ReadLine());
            if (nb<0)
            {
                nb = nb * -1;
            }
            Console.WriteLine(nb);*/

            //EXERCICE 3

            /*Console.WriteLine("Donnez une note");
            int note = int.Parse(Console.ReadLine());
            if (note<8)
            {
                Console.WriteLine("ajourné");
            }else if(note<10){
                Console.WriteLine("rattrapage");
            }
            else
            {
                Console.WriteLine("admis");
            }*/

            //EXERCICE 4

            /*Console.WriteLine("Donnez un montant");
            float montant = float.Parse(Console.ReadLine());
            float franchise =(float) (montant * 0.1);
            if (franchise<4000)
            {
                Console.WriteLine("franchise : "+franchise);
            }
            else
            {
                Console.WriteLine("Pas de franchise");
            }*/

            //EXERCICE 5

            /*Console.WriteLine("Donnez une valeur");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez une valeur");
            int v2 = int.Parse(Console.ReadLine());
            if (v1!=v2)
            {
                Console.WriteLine("2 valeurs distinctes");
            }
            else
            {
                Console.WriteLine("1 valeur distincte");
            }*/

            //EXERCICE 6

            /*Console.WriteLine("Donnez une valeur");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez une valeur");
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez une valeur");
            int v3 = int.Parse(Console.ReadLine());

            if (v1<v2 && v1<v3)
            {
                Console.WriteLine(v1+" est la plus petite valeur");
            }
            else if(v2<v3 && v2<v1)
            {
                Console.WriteLine(v2+" est la plus petite valeur");
            }
            else
            {
                Console.WriteLine(v3+" est la plus petite valeur");
            }*/

            //EXERCICE 7

            /*Console.WriteLine("Donnez une valeur");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez une valeur");
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez un opérateur (+,-,*,/)");
            char op = char.Parse(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine(v1 + v2);
                    break;
                case '-':

                    Console.WriteLine(v1 - v2);
                    break;
                case '*':

                    Console.WriteLine(v1 * v2);
                    break;
                case '/':
                    
                    Console.WriteLine(((float)v1 / (float)v2));
                    break;
                default:
                    Console.WriteLine("Erreur d'opérateur");
                    break;
            }*/

            //EXERCICE 8

            /*Console.WriteLine("Donnez la valeur de la ligne");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez la valeur de la colonne");
            int j = int.Parse(Console.ReadLine());
            if (i%2==1 && j%2==1)
            {
                Console.WriteLine("case noir");
            }
            else
            {
                Console.WriteLine("case blanche");
            }*/

            //EXERCICE 9

            /*Console.WriteLine("Donnez la valeur de la ligne");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez la valeur de la colonne");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez la valeur de la ligne");
            int i2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez la valeur de la colonne");
            int j2 = int.Parse(Console.ReadLine());

            if ((i+2==i2 && j+1==j2) || (i + 2 == i2 && j - 1 == j2) || (i - 2 == i2 && j + 1 == j2) || (i - 2 == i2 && j - 1 == j2))
            {
                Console.WriteLine("Le cavalier peut se déplacer");
            }
            else
            {
                Console.WriteLine("Le cavalier ne peut pas se déplacer");
            }*/

            //EXERCICE 10

            /*Console.WriteLine("Quelle pièce ?");
            Console.WriteLine("0=Cavalier");
            Console.WriteLine("1=Tour");
            Console.WriteLine("2=Fou");
            Console.WriteLine("3=Dame");
            Console.WriteLine("4=Roi");
            int piece = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez la valeur de la ligne");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez la valeur de la colonne");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez la valeur de la ligne");
            int i2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez la valeur de la colonne");
            int j2 = int.Parse(Console.ReadLine());
            switch (piece)
            {
                case 0:
                    if ((i + 2 == i2 && j + 1 == j2) || (i + 2 == i2 && j - 1 == j2) || (i - 2 == i2 && j + 1 == j2) || (i - 2 == i2 && j - 1 == j2))
                    {
                        Console.WriteLine("Le cavalier peut se déplacer");
                    }
                    else
                    {
                        Console.WriteLine("Le cavalier ne peut pas se déplacer");
                    }
                    break;
                case 1:
                    if ((i==i2 && j!=j2) || (i!=i2 && j==j2))
                    {
                        Console.WriteLine("La tour peut se déplacer");
                    }
                    else
                    {
                        Console.WriteLine("La tour ne peut pas se déplacer");
                    }
                    break;
                case 2:
                    if (Math.Abs(i-i2)==Math.Abs(j-j2))
                    {
                        Console.WriteLine("Le fou peut se déplacer");
                    }
                    else
                    {
                        Console.WriteLine("Le fou ne peut pas se déplacer");
                    }
                    break;
                case 3:
                    if ((Math.Abs(i - i2) == Math.Abs(j - j2)) || (i == i2 && j != j2) || (i != i2 && j == j2))
                    {
                        Console.WriteLine("La dame peut se déplacer");
                    }
                    else
                    {
                        Console.WriteLine("La dame ne peut pas se déplacer");
                    }
                    break;
                case 4:
                    if ((i-1==i2 && j-1==j2) || (i - 1 == i2 && j == j2) || (i - 1 == i2 && j + 1 == j2) || (i== i2 && j - 1 == j2) || (i == i2 && j + 1 == j2) || (i + 1 == i2 && j - 1 == j2) || (i + 1 == i2 && j== j2) || (i + 1 == i2 && j + 1 == j2))
                    {
                        Console.WriteLine("Le roi peut se déplacer");
                    }
                    else
                    {
                        Console.WriteLine("Le roi ne peut pas se déplacer");
                    }
                    break;
            }*/

            //EXERCICE 11

            Console.WriteLine("Donnez heures de début");
            int heureD = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez minutes de début");
            int minD = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez heures de fin");
            int heureF = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez minutes de fin");
            int minF = int.Parse(Console.ReadLine());

            if ((heureF<heureD) || (heureF==heureD && minF<minD))
            {
                Console.WriteLine("Erreur lors de la saisie des heures (date de fin inférieur à la date de début)");
            }
            else
            {
                if (heureD==heureF)
                {
                    Console.WriteLine("Temps écoulés : "+minF-minD);
                }
                else
                {
                    if (minF>minD)
                    {
                        Console.WriteLine("Temps écoulés : " + heureF-heureD + "h"+minF-minD);
                    }
                    else
                    {
                        int diff = 60 - minF + minD;
                        if (diff>=60)
                        {

                            Console.WriteLine("Temps écoulés : ");
                        }
                    }
                }
            }
        }
    }
}
