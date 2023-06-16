using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenJs.service
{
    class ParametreRepository : IParametre
    {
        private BDContext bd;

        public ParametreRepository()
        {
            bd = new BDContext();
        }

        public List<Cours> findAllCours()
        {
            return bd.Cours.ToList();
        }

        public List<Matiere> findAllMatiere()
        {
            return bd.Matiere.ToList();
        }

        public List<Salle> findAllSalle()
        {
            return bd.Salle.ToList();
        }

        public Cours saveCours(Cours c)
        {
            try
            {
                bd.Cours.Add(c);
                bd.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
            return c;
        }        
    }
}
