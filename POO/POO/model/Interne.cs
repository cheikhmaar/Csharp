using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.model
{
    public class Interne : Etudiant
    {
        public string batiment { get; set; }
        public string chambre { get; set; }
        public int typeBourse { get; set; }
        public int montant { get; set; }
        public static string banque { get; set; }

        public Interne(string matrcule, string nom, string prenom, DateTime datenaissance, 
            string batiment, string chambre, int typeBourse, int montant) : base(matrcule, nom, prenom, datenaissance)
        {
            this.batiment = batiment;
            this.chambre = chambre;
            this.typeBourse = typeBourse;
            this.montant = montant;
        }

        public Interne() 
        {
        }

        public override string ToString()
        {
            return "["+base.ToString() + " / " + batiment + " / " + chambre + " / " + typeBourse + " / " + montant + "]";
        }

        public override void saisie()
        {
            base.saisie();
            Console.WriteLine("Saisie le batiment, la chambre, et le type de bourse (1 = demi, 2 = entier)");
            batiment = Console.ReadLine();
            chambre = Console.ReadLine();
            do
            {
                typeBourse = int.Parse(Console.ReadLine());
                if(typeBourse != 1 && typeBourse != 2)
                {
                    Console.WriteLine("type de bourse invalide ! (1 = demi, 2 = entier)");
                }
            } while (typeBourse != 1 && typeBourse != 2);
            montant = (typeBourse == 1 ? 20000 : 40000);
        }

    }
}
