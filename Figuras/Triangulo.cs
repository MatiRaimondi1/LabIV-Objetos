using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Figuras
{
    public class Triangulo : Figura
    {
        private double _base;
        private double altura;
        public Triangulo(double _base, double altura)
        {
            this._base = _base;
            this.altura = altura;
        }
        public override double calcularArea()
        {
            return _base * altura / 2;
        }
    }
}
