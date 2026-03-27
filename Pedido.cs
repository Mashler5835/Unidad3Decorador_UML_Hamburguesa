using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public abstract class Pedido
    {
        protected ITipoEntrega tipoEntrega;
        protected Hamburguesa hamburguesa;
        protected Papas papas;
        protected Bebida bebida;

        public Pedido(Hamburguesa hamburguesa, Papas papas, Bebida bebida, ITipoEntrega tipoEntrega)
        {
            this.hamburguesa = hamburguesa;
            this.papas = papas;
            this.bebida = bebida;
            this.tipoEntrega = tipoEntrega;
        }

        public abstract string MostrarResumen();
        public abstract decimal CalcularTotal();
    }

}
