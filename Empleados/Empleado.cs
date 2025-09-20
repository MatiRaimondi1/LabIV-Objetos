using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Empleados
{
    public class Empleado
    {
        private string nombre;
        private double salario;
        private string id;

        public string Nombre { get => nombre; set => nombre = value; }

        public double Salario
        {
            get => salario;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El salario no puede ser menor a 0.");
                }
                salario = value;
            }
        }

        public string Id
        {
            get => id;
            set
            {
                if (!value.StartsWith("EMP-"))
                {
                    throw new ArgumentException("El ID debe comenzar con 'EMP-'.");
                }
                id = value;
            }
        }

        public Empleado(string nombre, double salario, string id)
        {
            this.Nombre = nombre;
            this.Salario = salario;
            this.Id = id;
        }
    }
}
