using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class SinBebida : Bebida
    {
        public override string GetDescripcion() => "Sin bebida";
        public override decimal GetCosto() => 0.00m;
    }
}
