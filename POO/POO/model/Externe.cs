using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.model
{
    public class Externe : Etudiant
    {
        public string adresse { get; set; }
        public string tel { get; set; }
        public static int aide { get; set; }

        public Externe(string matrcule, string nom, string prenom, DateTime datenaissance, 
            string tel, string adresse) : base(matrcule, nom, prenom, datenaissance)
        {
            this.adresse = adresse;
            this.tel = tel;
        }

        public Externe() 
        {
        }

        public override string ToString()
        {
            return "["+base.ToString() + " / " + adresse + " / " + tel + " / " + "]";
        }

        public override void saisie()
        {
            base.saisie();
            Console.WriteLine("Saisie l'adresse et le telephone");
            adresse = Console.ReadLine();
            tel = Console.ReadLine();
        }

    }
}
