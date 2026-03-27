using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class PapasCrisscut : Papas
    {
        public override string GetDescripcion() => "Papas Crisscut";
        public override decimal GetCosto() => 42.00m;
    }
}
