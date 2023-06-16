using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.model;

namespace POO.service
{
    class ScolariteService : IScolarite
    {
        public void addEtudiant(Etudiant e)
        {
            Program.etudiants.Add(e);
        }

        public void findAll()
        {
            foreach (Etudiant e in Program.etudiants)
            {
                Console.WriteLine(e);
            }
        }

        public bool findAllExterne()
        {
            bool trouve = false;
            foreach (Etudiant e in Program.etudiants)
            {
                if(e is Externe)
                {
                    Console.WriteLine(e);
                    trouve = true;
                }
            }
            return trouve;
        }

        public bool findAllInterne()
        {
            bool trouve = false;
            foreach (Etudiant e in Program.etudiants)
            {
                if (e is Interne)
                {
                    Console.WriteLine(e);
                    trouve = true;
                }
            }
            return trouve;
        }
    }
}
