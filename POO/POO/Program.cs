using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.model;
using POO.service;

namespace POO
{
    class Program
    {
        public static List<Etudiant> etudiants;
        static void Main(string[] args)
        {
            /*
            Etudiant e1 = new Etudiant();
            e1.matrcule = "098";
            e1.nom = "Niass";
            e1.prenom = "Oumy";
            e1.datenaissance = DateTime.Parse("12/09/2011");
            Etudiant e2 = new Etudiant("090", "Diop", "Amadou", DateTime.Now);
            Etudiant e3 = new Etudiant
            {
                matrcule = "097",
                nom = "fall",
                prenom = "Seydou",
                datenaissance = DateTime.Now
            };
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);*/
            //Etudiant[] tab = new Etudiant[3];
            Console.WriteLine("Saisir le nombre d'étudiants.");
            int nb = int.Parse(Console.ReadLine());
            etudiants = new List<Etudiant>();
            IScolarite scolarite = new ScolariteService();
            for (int i = 0; i < nb; i++)
            {
                Etudiant et;
                if (i % 2 == 0)
                {
                    Console.WriteLine("Saisie d'un interne");
                    et = new Interne();
                }
                else
                {
                    Console.WriteLine("Saisie d'un externe");
                    et = new Externe();
                }
                et.saisie();
                scolarite.addEtudiant(et);
            }

            scolarite.findAll();

            Console.WriteLine("Affichage des internes (nom et montant bourse)");
            scolarite.findAllInterne();

            Console.WriteLine("Affichage des externes (nom et montant bourse)");
            scolarite.findAllExterne();
        }
    }
}
