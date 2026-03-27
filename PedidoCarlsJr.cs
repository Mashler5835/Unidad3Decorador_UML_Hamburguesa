using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class PedidoCarlsJr : Pedido
    {
        public PedidoCarlsJr(Hamburguesa hamburguesa, Papas papas, Bebida bebida, ITipoEntrega tipoEntrega)
            : base(hamburguesa, papas, bebida, tipoEntrega)
        {
        }

        public override string MostrarResumen()
        {
            return
                "===== PEDIDO CARL'S JR =====" + Environment.NewLine +
                $"Hamburguesa: {hamburguesa.GetDescripcion()}" + Environment.NewLine +
                $"Papas: {papas.GetDescripcion()}" + Environment.NewLine +
                $"Bebida: {bebida.GetDescripcion()}" + Environment.NewLine +
                $"Tipo de entrega: {tipoEntrega.ProcesarEntrega()}" + Environment.NewLine + Environment.NewLine +
                $"Hamburguesa: ${hamburguesa.GetCosto():0.00}" + Environment.NewLine +
                $"Papas: ${papas.GetCosto():0.00}" + Environment.NewLine +
                $"Bebida: ${bebida.GetCosto():0.00}" + Environment.NewLine +
                $"Cargo entrega/servicio: ${tipoEntrega.CostoEntrega():0.00}";
        }

        public override decimal CalcularTotal()
        {
            return hamburguesa.GetCosto()
                 + papas.GetCosto()
                 + bebida.GetCosto()
                 + tipoEntrega.CostoEntrega();
        }
    }
}
