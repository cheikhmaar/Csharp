using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bases
{
    class MainBoucle
    {
        static void Main(string[] args)
        {
            // boucle while
            int i = 1, somme = 0;
            while(i < 101)
            {
                somme += i;
                i++;
            }
            Console.WriteLine("Somme de 1 à 100 = " + somme);
            // boucle do while
            i = 1;
            somme = 0;
            do
            {
                somme += i;
                i++;
            }while (i < 101);
            Console.WriteLine("Somme de 1 à 100 = " + somme);
            // boucle for
            somme = 0;
            for(i = 1; i < 101; i++)
            {
                somme += i;
            }
            Console.WriteLine("Somme de 1 à 100 = " + somme);
        }
    }
}
