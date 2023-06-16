using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionScolaire.service
{
    interface IParametre
    {
        Classe saveClasse(Classe c);
        List<Classe> findAllClasse();
        List<Filiere> findAllFiliere();
    }
}
