using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class ParaLlevar : ITipoEntrega
    {
        public string ProcesarEntrega() => "Pedido para llevar";
        public decimal CostoEntrega() => 5m;
    }
}
