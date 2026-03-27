using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class RefrescoMediano : Bebida
    {
        public override string GetDescripcion() => "Refresco mediano";
        public override decimal GetCosto() => 28.00m;
    }
}
