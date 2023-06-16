using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bases
{
    class MainTableaux
    {
        static void Main(string[] args)
        {
            string[] animaux = { "lion", "elephant", "tigre", "loup"};
            foreach(string animal in animaux)
            {
                Console.Write(animal + "\t");
            }
            Console.WriteLine();

            int[] tab = new int[5];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("saisir l'element " + i + " : ");
                tab[i] = int.Parse(Console.ReadLine());
            }

            int[,] matrice = new int[3, 2];
            Console.WriteLine("Nombre de lignes = " + matrice.GetLength(0));
            Console.WriteLine("Nombre de colonnes = " + matrice.GetLength(1));
            Console.WriteLine("Saisie de la matrice");
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write("saisir l'element (" + i + ", " + j + ") : ");
                    matrice[i,j] = int.Parse(Console.ReadLine());
                }
            }
            int NBLIGNE = matrice.GetLength(0);
            Console.WriteLine("Saisie de la matrice");
            for (int i = 0; i < NBLIGNE; i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write(matrice[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
