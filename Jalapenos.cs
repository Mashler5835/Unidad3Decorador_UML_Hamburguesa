using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class Jalapenos : HamburguesaDecorator
    {
        public Jalapenos(Hamburguesa hamburguesa) : base(hamburguesa) { }
        public override string GetDescripcion() => hamburguesa.GetDescripcion() + ", Jalapeños";
        public override decimal GetCosto() => hamburguesa.GetCosto() + 12.00m;
    }
}
