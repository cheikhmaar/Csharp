using System.Collections.Generic;
using System.Linq;

namespace WpfApp2.Service
{
    class ProfilRepository : IProfil
    {
        public List<profil> FindAll()
        {
            return BDContext.GetInstance().profils.ToList();
        }

        public profil FindById(int id)
        {
            return BDContext.GetInstance().profils.Find(id);
        }
    }
}
