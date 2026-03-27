using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class RefrescoGrande : Bebida
    {
        public override string GetDescripcion() => "Refresco grande";
        public override decimal GetCosto() => 35.00m;
    }
}
