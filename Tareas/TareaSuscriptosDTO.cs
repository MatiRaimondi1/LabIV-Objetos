using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Tareas
{
    public class TareaSuscriptosDTO
    {
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaLimite { get; set; }
        public DateTime FechaRealizacion { get; set; }
        public EPrioridad Prioridad { get; set; }
        public string Dueño { get; set; }
        public string Estado { get; set; }
    }
}
