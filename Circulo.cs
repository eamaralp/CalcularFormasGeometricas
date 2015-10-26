using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormasGeometricas
{
    // A classe possui o raio de um circulo e seus métodos devem calcular a área e o perímetro do mesmo
    public class Circulo : FormaGeometrica, ICalcularMedidasUmLado
    {
        private decimal _raio;
        public decimal Raio
        {
            get
            {
                return this._raio;
            }

            set
            {
                if (value < 0)
                {
                    this._raio = 0;
                }
                else
                {
                    this._raio = value;
                }
            }
        }

        public decimal CalcularArea(decimal valor)
        {
            decimal valorArea = 0;
            valorArea = (decimal)Math.PI * (valor * valor);
            return valorArea;
        }

        public decimal CalcularPerimetro(decimal valor)
        {
            decimal valorPerimetro = 0;
            valorPerimetro = (decimal)((2 * Math.PI) * (double)valor);
            return valorPerimetro;
        }
    }
}
