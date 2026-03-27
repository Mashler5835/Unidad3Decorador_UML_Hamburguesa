using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class SinTomate : HamburguesaDecorator
    {
        public SinTomate(Hamburguesa hamburguesa) : base(hamburguesa) { }
        public override string GetDescripcion() => hamburguesa.GetDescripcion() + ", Sin tomate";
        public override decimal GetCosto() => hamburguesa.GetCosto();
    }
}
