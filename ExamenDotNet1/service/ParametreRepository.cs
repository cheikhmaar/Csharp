using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDotNet1.service
{
    class ParametreRepository : IParametre
    {
        private BDContext db;
        public ParametreRepository()
        {
            db = new BDContext();
        }
        public List<Marque> findAllMarque()
        {
            return db.Marque.ToList();
        }

        public List<Ordinateur> findAllOrdinateur()
        {
            return db.Ordinateur.ToList();
        }

        public List<Os> findAllOs()
        {
           return db.Os.ToList();
        }

        public Ordinateur saveOrdinateur(Ordinateur o)
        {
            try
            {
                db.Ordinateur.Add(o);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            return o;
        }
    }
}
