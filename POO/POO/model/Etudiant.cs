using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.model
{
    public abstract class Etudiant
    {
        public string matrcule { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime datenaissance { get; set; }
        public int age

        public Etudiant(string matrcule, string nom, string prenom, DateTime datenaissance)
        {
            this.matrcule = matrcule;
            this.nom = nom;
            this.prenom = prenom;
            this.datenaissance = datenaissance;
        }

        public Etudiant()
        {

        }
        public override string ToString()
        {
            return "["+matrcule+" / "+prenom+" / "+nom+" / "+datenaissance+"]";
        }

        public virtual void saisie()
        {
            Console.WriteLine("Saisie le matricule, le prenom, le nom et la date de naissance");
            matrcule = Console.ReadLine();
            prenom = Console.ReadLine();
            nom = Console.ReadLine();
            datenaissance = DateTime.Parse(Console.ReadLine());
        }
        
    }
}
