using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Service
{
    class UserRepository : IUser
    {
        public utilisateur Find(int id)
        {
            return BDContext.GetInstance().utilisateurs.Find(id);
        }

        public List<utilisateur> FindAll()
        {
            return BDContext.GetInstance().utilisateurs.ToList();
        }

        public utilisateur GetUtilisateur(string username, string password)
        {
            return BDContext.GetInstance().utilisateurs.Where(u => u.username == username 
            && u.password == password).FirstOrDefault();
        }
        public void Save(utilisateur u)
        {
            try
            {
                BDContext.GetInstance().utilisateurs.Add(u);
                BDContext.GetInstance().SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
