using System.ComponentModel.DataAnnotations.Schema;

namespace Ev_4_Jorge_Castillo.Modelo
{
    [Table("Editorial")] // Indicar la tabla al que pertenecerá la clase POCO
    public class Editorial
    {
        public int Id { get; set; }
        public int Run { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool? Estado { get; set; }
        
        // Relaciones
        public virtual ICollection<Libro> Libros { get; set; }
    }
}
