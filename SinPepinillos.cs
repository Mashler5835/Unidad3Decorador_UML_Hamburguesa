using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class SinPepinillos : HamburguesaDecorator
    {
        public SinPepinillos(Hamburguesa hamburguesa) : base(hamburguesa) { }
        public override string GetDescripcion() => hamburguesa.GetDescripcion() + ", Sin pepinillos";
        public override decimal GetCosto() => hamburguesa.GetCosto();
    }
}
