using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenJs.service
{
    interface IParametre
    {
        Cours saveCours(Cours c);
        List<Cours> findAllCours();
        List<Salle> findAllSalle();
        List<Matiere> findAllMatiere();
    }
}
