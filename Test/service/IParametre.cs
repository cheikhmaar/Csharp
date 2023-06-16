using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.service
{
    interface IParametre
    {
        Classe saveClasse(Classe c);//permet de sauvegarder les elts de la classe
        List<Classe> findAllClasse();
        List<Filiere> findAllFiliere();

    }
}
