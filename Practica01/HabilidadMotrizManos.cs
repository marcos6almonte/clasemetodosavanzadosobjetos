﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion__interfaz_
{
    public class HabilidadMotrizManos : IHabilidadMotriz
    {
        public string mover()
        {
            return "Habilidad motriz con las manos";
        }
    }
}
