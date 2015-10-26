using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormasGeometricas
{
    // A classe relaiza o calculo de area e perímetro de um triangulo esquilátero
    public class Triangulo : FormaGeometrica, ICalcularMedidasUmLado
    {
        private decimal _lado;
        public decimal Lado
        {
            get
            {
                return this._lado;
            }
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
            valor = (decimal)(valor * valor) / 2;

            return valor;
        }

        public decimal CalcularPerimetro(decimal valor)
        {
            valor = 3 * valor;

            return valor;
        }
    }
}
