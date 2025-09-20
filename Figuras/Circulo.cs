using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Figuras
{
    public class Circulo : Figura
    {         
        private double radio;
        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override double calcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
