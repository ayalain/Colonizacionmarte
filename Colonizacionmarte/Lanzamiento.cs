using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colonizacionmarte;

namespace Colonizacionmarte
{
    class Lanzamiento
    {
        public string destino { get; set; }
        public float pesoCarga { get; set; }



        public Lanzamiento()
        {
            destino = "";
            pesoCarga = 0;
        }
    }
}
