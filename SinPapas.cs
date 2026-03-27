using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class SinPapas : Papas
    {
        public override string GetDescripcion() => "Sin papas";
        public override decimal GetCosto() => 0.00m;
    }
}
