using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bases
{
    class Program
    {
        static void Main(string[] args)
        {
            const double tva = 0.18;
            int remise = 0;
            //saisir le montant hors taxe au clavier
            Console.Write("Saisir le montant hors taxe :");
            int montantHT = int.Parse(Console.ReadLine());
            int montantTVA = (int)(montantHT * tva);
            int montantTTC = montantHT + montantTVA;
            if(montantHT >= 20000 && montantHT <= 35000)
            {
                remise = (int)(montantHT * 0.02);
            }
            else if(montantHT >= 35001 && montantHT <= 60000)
            {
                remise = (int)(montantHT * 0.05);
            }
            else if (montantHT > 60000)
            {
                remise = (int)(montantHT * 0.08);
            }
            montantTTC -= remise;
            Console.WriteLine("HT = " + montantHT);
            Console.WriteLine("TVA = " + montantTVA);
            Console.WriteLine("REMISE = " + remise);
            Console.WriteLine("TTC = " + montantTTC);
        }
    }
}
