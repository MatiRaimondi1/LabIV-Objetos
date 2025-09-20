using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Tareas
{
    public class TareaModel
    {
        public Guid Id { get; private set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; private set; }
        public DateTime FechaLimite { get; set; }
        public DateTime FechaRealizacion { get; private set; }
        public EPrioridad Prioridad { get; set; }
        public int VecesActualizada { get; private set; }
        public Guid Dueño { get; set; }
        public List<Guid> UsuariosSuscriptos { get; set; }
        public bool Completada { get; set; }

        public bool DescripcionYFechaValidas(string descripcion, DateTime fechaLimite)
        {
            return descripcion.Length <= 200 && fechaLimite >= DateTime.Now.Date;
        }

        public TareaModel(Guid dueño, string descripcion, DateTime fechaLimite, EPrioridad prioridad)
        {
            if (!DescripcionYFechaValidas(descripcion, fechaLimite))
            {
                throw new ArgumentException("La descripción no puede exceder los 200 caracteres y la fecha límite no puede ser anterior a la fecha actual.");
            }

            Id = Guid.NewGuid();
            Descripcion = descripcion;
            FechaCreacion = DateTime.Now;
            FechaLimite = fechaLimite;
            Prioridad = prioridad;
            VecesActualizada = 0;
            Dueño = dueño;
            UsuariosSuscriptos = new List<Guid>();
            Completada = false;
        }

        public void ActualizarTarea(string nuevaDescripcion, DateTime nuevaFechaLimite, EPrioridad nuevaPrioridad, bool estado)
        {
            if (Completada)
            {
                throw new InvalidOperationException("No se puede actualizar una tarea que ya ha sido completada.");
            }
            
            if (!DescripcionYFechaValidas(nuevaDescripcion, nuevaFechaLimite))
            {
                throw new ArgumentException("La descripción no puede exceder los 200 caracteres y la fecha límite no puede ser anterior a la fecha actual.");
            }

            Descripcion = nuevaDescripcion;
            FechaLimite = nuevaFechaLimite;
            Prioridad = nuevaPrioridad;
            Completada = estado;
            
            if (estado)
            {
                FechaRealizacion = DateTime.Now;
            }

            VecesActualizada++;

            NotificarSuscriptos("La tarea ha sido actualizada.");
        }

        public void AgregarSuscriptor(Guid usuarioId)
        {
            if (!UsuariosSuscriptos.Contains(usuarioId))
            {
                UsuariosSuscriptos.Add(usuarioId);
            }
        }

        public void RemoverSuscriptor(Guid usuarioId)
        {
            if (UsuariosSuscriptos.Contains(usuarioId))
            {
                UsuariosSuscriptos.Remove(usuarioId);
            }
        }

        public void NotificarSuscriptos(string mensaje)
        {
            foreach (var usuarioId in UsuariosSuscriptos)
            {
                Console.WriteLine($"Notificando al usuario {usuarioId}: {mensaje}");
            }
        }
    }

    public enum EPrioridad
    {
        Baja,
        Media,
        Alta
    }
}
