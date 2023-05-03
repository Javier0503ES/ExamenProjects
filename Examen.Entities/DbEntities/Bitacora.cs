namespace Examen.Entities.DbEntities
{
    public class Bitacora
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdAccion { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
