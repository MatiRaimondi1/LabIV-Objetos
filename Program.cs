using Objetos.Animales;
using Objetos.Empleados;
using Objetos.Figuras;
using Objetos.Notificaciones;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo Figuras
            Figura circulo = new Circulo(2.5);
            Figura rectangulo = new Rectangulo(5, 6);
            Figura triangulo = new Triangulo(3, 4);
            Console.WriteLine($"Área del círculo: {circulo.calcularArea()}");
            Console.WriteLine($"Área del rectángulo: {rectangulo.calcularArea()}");
            Console.WriteLine($"Área del triángulo: {triangulo.calcularArea()}");
            Console.WriteLine("------------------------------------------------------");

            // Ejemplo Empleados
            Empleado empleado = new("Juan", 3000, "EMP-001");
            Console.WriteLine($"Empleado: {empleado.Nombre}, Salario: {empleado.Salario}, ID: {empleado.Id}");
            empleado.Salario = 3500;
            Console.WriteLine($"Empleado: {empleado.Nombre}, Salario: {empleado.Salario}, ID: {empleado.Id}");
            try { 
                empleado.Salario = -500;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("------------------------------------------------------");

            // Ejemplo Animales
            Animal perro = new Perro();
            Animal pajaro = new Pajaro();
            Console.WriteLine($"Perro: {perro.hacerSonido()}, Movimiento: {perro.moverse()}");
            Console.WriteLine($"Pájaro: {pajaro.hacerSonido()}, Movimiento: {pajaro.moverse()}");
            Console.WriteLine("------------------------------------------------------");

            // Ejemplo Notificaciones
            INotificacion notificacionEmail = new NotificacionEmail();
            notificacionEmail.enviar("Test Email");
            INotificacion notificacionSMS = new NotificacionSMS();
            notificacionSMS.enviar("Test SMS");
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
