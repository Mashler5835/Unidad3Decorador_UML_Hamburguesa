using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class FamousStar : Hamburguesa
    {
        public override string GetDescripcion() => "Famous Star";
        public override decimal GetCosto() => 110.00m;
    }
}
