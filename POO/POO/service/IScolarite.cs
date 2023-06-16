using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.model;

namespace POO.service
{
    public interface IScolarite
    {
        void addEtudiant(Etudiant e);
        void findAll();
        bool findAllInterne();
        bool findAllExterne();
    }
}
