using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class WesternBacon : Hamburguesa
    {
        public override string GetDescripcion() => "Western Bacon";
        public override decimal GetCosto() => 135.00m;
    }
}
