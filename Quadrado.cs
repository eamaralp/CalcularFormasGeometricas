using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormasGeometricas
{
    // A classe possui o lado de um quadrado e seus métodos devem calcular a área e o perímetro do mesmo
    public class Quadrado : FormaGeometrica, ICalcularMedidasUmLado
    {
        private decimal _lado;
        public decimal Lado
        {
            get { return _lado; }
            set
            {
                if (value < 0)
                {
                    this._lado = 0;
                }
                else
                {
                    this._lado = value;
                }
            }
        }

        public decimal CalcularArea(decimal valor)
        {
            valor = (decimal)(valor * valor);

            return valor;
        }

        public decimal CalcularPerimetro(decimal valor)
        {
            valor = 4 * valor;

            return valor;
        }
    }
}
