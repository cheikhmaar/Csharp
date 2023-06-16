using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bases
{
    class MainSwitch
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("saisir deux reels a et b");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("saisir 1 pour la somme");
            Console.WriteLine("saisir 2 pour la soustraction");
            Console.WriteLine("saisir 3 pour la multiplication");
            Console.WriteLine("saisir 4 pour la division");
            Console.WriteLine("saisir 5 pour le modulo");
            Console.WriteLine("saisir 6 pour Quitter");
            int choix = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1: Console.WriteLine(a + " + " + b + " = " + (a + b));
                        break;
                case 2:
                        Console.WriteLine(a + " - " + b + " = " + (a - b));
                        break;
                case 3:
                        Console.WriteLine(a + " * " + b + " = " + (a * b));
                        break;
                case 4:
                        Console.WriteLine(a + " / " + b + " = " + (a / b));
                        break;
                case 5:
                        Console.WriteLine(a + " % " + b + " = " + (a % b));
                        break;
                default :
                        Console.WriteLine("Au revoir");
                        break;
            }
        }
    }
}
