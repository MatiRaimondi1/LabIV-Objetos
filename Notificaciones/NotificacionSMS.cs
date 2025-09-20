using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Notificaciones
{
    public class NotificacionSMS : INotificacion
    {
        public void enviar(string mensaje)
        {
            Console.WriteLine($"Notificacion enviada correctamente por SMS: {mensaje}");
        }
    }
}
