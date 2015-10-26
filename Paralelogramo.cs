using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormasGeometricas
{
    // Classe utilizada como base para qudrilateros que possuem lados opostos e parelelos
    public class Paralelogramo : FormaGeometrica
    {
        private decimal _lado1;
        public decimal Lado1
        {
            get
            {
                return this._lado1;
            }
            set
            {
                if (value < 0)
                {
                    this._lado1 = 0;
                }
                else
                {
                    this._lado1 = value;
                }
            }
        }

        private decimal _lado2;
        public decimal Lado2
        {
            get
            {
                return this._lado2;
            }
            set
            {
                if (value < 0)
                {
                    this._lado2 = 0;
                }
                else
                {
                    this._lado2 = value;
                }
            }
        }

        public decimal CalcularArea(decimal valor1, decimal valor2)
        {
            decimal valorArea = 0;
            valorArea = (decimal)(valor1 * valor2);

            return valorArea;
        }


        public decimal CalcularPerimetro(decimal valor1, decimal valor2)
        {
            decimal valorPerimetro = 0;
            valorPerimetro = (2 * valor1) + (2 * valor2);

            return valorPerimetro;
        }

    }
}
