using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class ArosDeCebolla : HamburguesaDecorator
    {
        public ArosDeCebolla(Hamburguesa hamburguesa) : base(hamburguesa) { }
        public override string GetDescripcion() => hamburguesa.GetDescripcion() + ", Aros de cebolla";
        public override decimal GetCosto() => hamburguesa.GetCosto() + 20.00m;
    }
}
