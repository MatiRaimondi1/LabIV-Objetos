using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Animales
{
    public class Perro : Animal
    {
        public override string hacerSonido()
        {
            return "Woof Woof";
        }

        public override string moverse()
        {
            return "El perro comienza a correr";
        }
    }
}
