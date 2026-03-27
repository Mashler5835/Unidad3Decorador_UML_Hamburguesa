using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class ExtraQueso : HamburguesaDecorator
    {
        public ExtraQueso(Hamburguesa hamburguesa) : base(hamburguesa) { }
        public override string GetDescripcion() => hamburguesa.GetDescripcion() + ", Extra queso";
        public override decimal GetCosto() => hamburguesa.GetCosto() + 18.00m;
    }
}
