using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenJava.service
{
    interface IParametre
    {
        Personne savePersonne(Personne p);
        List<Personne> findAllPersonne();
        List<Pays> findAllPays();
        List<Adresse> findAllAdresse();
    }
}
