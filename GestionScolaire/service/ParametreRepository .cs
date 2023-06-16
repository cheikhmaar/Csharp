using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionScolaire.service
{
    class ParametreRepository : IParametre
    {
        private BDContext db;

        public ParametreRepository()
        {
            db = new BDContext();
        }

        public List<Classe> findAllClasse()
        {
            return db.Classe.ToList();
        }

        public List<Filiere> findAllFiliere()
        {
            return db.Filiere.ToList();
        }

        public Classe saveClasse(Classe c)
        {
            try
            {
                db.Classe.Add(c);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            return c;
        }
    }
}
