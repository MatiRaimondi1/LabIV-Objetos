using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Notificaciones
{
    public class NotificacionEmail : INotificacion
    {
        public void enviar(string mensaje)
        {
            Console.WriteLine($"Notificacion enviada correctamente por Email: {mensaje}");
        }
    }
}
