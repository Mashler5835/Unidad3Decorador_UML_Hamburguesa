using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsjr_Patrones
{
    public interface ITipoEntrega
    {
        string ProcesarEntrega();
        decimal CostoEntrega();
    }
}
