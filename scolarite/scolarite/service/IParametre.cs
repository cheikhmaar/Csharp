﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scolarite.service
{
    public interface IParametre
    {
        classe saveClasse(classe c);
        List<classe> findAllClasse();
    }
}
