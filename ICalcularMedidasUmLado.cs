using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormasGeometricas
{
    // Interface utilizada em formas geometricas que necessitam apenas um valor para
    // calcular sua área e perímetro
    interface ICalcularMedidasUmLado
    {
        decimal CalcularArea(decimal valor);
        decimal CalcularPerimetro(decimal valor);
    }
}
