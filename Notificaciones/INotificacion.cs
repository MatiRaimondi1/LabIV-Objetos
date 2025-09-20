using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Notificaciones
{
    public interface INotificacion
    {
        public void enviar(string mensaje);
    }
}
