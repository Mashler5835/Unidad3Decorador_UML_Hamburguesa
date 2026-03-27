using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public abstract class HamburguesaDecorator : Hamburguesa
    {
        protected Hamburguesa hamburguesa;

        public HamburguesaDecorator(Hamburguesa hamburguesa)
        {
            this.hamburguesa = hamburguesa;
        }
    }
}
