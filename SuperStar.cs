using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class SuperStar : Hamburguesa
    {
        public override string GetDescripcion() => "Super Star";
        public override decimal GetCosto() => 145.00m;
    }
}
