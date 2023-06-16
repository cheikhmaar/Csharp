using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDotNet1.service
{
    interface IParametre
    {
        Ordinateur saveOrdinateur(Ordinateur o);
        List<Ordinateur> findAllOrdinateur();
        List<Marque> findAllMarque();
        List<Os> findAllOs();
    }
}
