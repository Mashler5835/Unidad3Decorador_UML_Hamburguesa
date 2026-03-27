using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class ExtraTocino : HamburguesaDecorator
    {
        public ExtraTocino(Hamburguesa hamburguesa) : base(hamburguesa) { }
        public override string GetDescripcion() => hamburguesa.GetDescripcion() + ", Tocino";
        public override decimal GetCosto() => hamburguesa.GetCosto() + 22.00m;
    }
}
