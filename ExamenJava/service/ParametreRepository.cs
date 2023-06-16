using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenJava.service
{
    class ParametreRepository : IParametre
    {
        private BDContext bd;

        public ParametreRepository()
        {
            bd = new BDContext();
        }

        public List<Adresse> findAllAdresse()
        {
            return bd.Adresse.ToList();
        }

        public List<Pays> findAllPays()
        {
            return bd.Pays.ToList();
        }

        public List<Personne> findAllPersonne()
        {
            return bd.Personne.ToList();
        }

        public Personne savePersonne(Personne p)
        {
            try
            {
                bd.Personne.Add(p);
                bd.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            return p;
        }
    }
}
