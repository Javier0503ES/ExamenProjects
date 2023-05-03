
namespace Examen.Entities.DbEntities
{
    public class Examen

    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int? NumPreguntas { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
