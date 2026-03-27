using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class EnRestaurante : ITipoEntrega
    {
        public string ProcesarEntrega() => "Consumo en restaurante";
        public decimal CostoEntrega() => 0m;
    }
}
