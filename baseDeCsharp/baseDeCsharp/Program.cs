using System;

namespace baseDeCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[2,2];
            const float pourcentage = (float)(0.18);
            float tva;
            float ttc;
            float rm;
           for(int i = 0; i < mat.GetLength(0); i++)
            {
                int j;
                for (j = 0; j < mat.GetLength(1); j++)
                {
                    Console.WriteLine("saisir le produit : " + mat[i, j]);
                    string produit = Console.ReadLine();
                    Console.WriteLine("saisir le prix : " + mat[i, j]);
                    int prix = int.Parse(Console.ReadLine());
                    if (prix != 0)
                    {
                        tva = prix * pourcentage;
                        ttc = (float)(tva* 1.92);
                        //Console.WriteLine("Le produit: "+produit+" a pour tva : " +tva+
                        // " a pour ttc : "+ttc);
                    }
                    else
                    {
                        Console.WriteLine("Le prix n'est peut pas etre < 0");
                    }
                    if (prix != 0)
                    {
                        if (prix >= 100000 && prix <= 200000)
                        {
                            
                        }
                    }

                }
            }
        }
    }
}
