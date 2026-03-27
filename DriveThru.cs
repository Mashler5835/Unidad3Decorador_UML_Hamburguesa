using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public class DriveThru : ITipoEntrega
    {
        public string ProcesarEntrega() => "Pedido por Drive Thru";
        public decimal CostoEntrega() => 8m;
    }
}
