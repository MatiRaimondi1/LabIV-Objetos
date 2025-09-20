using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Animales
{
    public class Pajaro : Animal
    {
        public override string hacerSonido()
        {
            return "Chirp chirp";
        }

        public override string moverse()
        {
            return "El pajarito comienza a volar";
        }
    }
}
