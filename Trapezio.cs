using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormasGeometricas
{
    public class Trapezio : FormaGeometrica
    {
        private decimal _baseMaior;
        public decimal BaseMaior
        {
            get
            {
                return this._baseMaior;
            }
            set
            {
                if (value < 0)
                {
                    this._baseMaior = 0;
                }
                else
                {
                    this._baseMaior = value;
                }
            }
        }

        private decimal _baseMenor;
        public decimal BaseMenor
        {
            get
            {
                return this._baseMenor;
            }
            set
            {
                if (value < 0)
                {
                    this._baseMenor = 0;
                }
                else
                {
                    this._baseMenor = value;
                }
            }
        }

        private decimal _altura;
        public decimal Altura
        {
            get
            {
                return this._altura;
            }
            set
            {
                if (value < 0)
                {
                    this._altura = 0;
                }
                else
                {
                    this._altura = value;
                }
            }
        }

        public decimal CalcularArea(decimal bMaior, decimal bMenor, decimal altura)
        {
            decimal valorArea = 0;
            valorArea = ((bMaior + bMenor) * altura) / 2;

            return valorArea;
        }


        public decimal CalcularPerimetro(decimal bMaior, decimal bMenor, decimal altura)
        {
            decimal valorPerimetro = 0;
            double hipotenusa;

            hipotenusa = Math.Pow(((double)bMaior - (double)bMenor), 2) * Math.Pow((double)altura, 2);
            valorPerimetro = (decimal)(bMaior + bMenor + altura + (decimal)hipotenusa);

            return valorPerimetro;
        }
    }
}
