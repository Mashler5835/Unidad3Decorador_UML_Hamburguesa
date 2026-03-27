using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class Guacamole : HamburguesaDecorator
    {
        public Guacamole(Hamburguesa hamburguesa) : base(hamburguesa) { }
        public override string GetDescripcion() => hamburguesa.GetDescripcion() + ", Guacamole";
        public override decimal GetCosto() => hamburguesa.GetCosto() + 25.00m;
    }
}
