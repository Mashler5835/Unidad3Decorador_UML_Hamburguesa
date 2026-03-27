using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class PapasFrancesa : Papas
    {
        public override string GetDescripcion() => "Papas a la francesa";
        public override decimal GetCosto() => 35.00m;
    }
}
