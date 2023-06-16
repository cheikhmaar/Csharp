using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Service
{
    public interface IUser
    {
        //--------------------------------------------

        List<utilisateur> FindAll();

        utilisateur GetUtilisateur(string username, string password);
        void Save(utilisateur u);
        utilisateur Find(int id);
    }
}
