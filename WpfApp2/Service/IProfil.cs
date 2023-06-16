using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Service
{
    public interface IProfil
    {
        List<profil> FindAll();
        profil FindById(int id);
    }
}
