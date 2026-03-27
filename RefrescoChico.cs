using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class RefrescoChico : Bebida
    {
        public override string GetDescripcion() => "Refresco chico";
        public override decimal GetCosto() => 20.00m;
    }
}
