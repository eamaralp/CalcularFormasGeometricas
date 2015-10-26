using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormasGeometricas
{
    public abstract class FormaGeometrica
    {
        private decimal _area;
        public decimal Area
        {
            get { return _area; }
            set
            {
                if (value < 0)
                {
                    this._area = 0;
                }
                else
                {
                    this._area = value;
                }
            }
        }

        private decimal _perimetro;
        public decimal Perimetro
        {
            get { return _perimetro; }
            set
            {
                if (value < 0)
                {
                    this._perimetro = 0;
                }
                else
                {
                    this._perimetro = value;
                }
            }
        }

    }
}
