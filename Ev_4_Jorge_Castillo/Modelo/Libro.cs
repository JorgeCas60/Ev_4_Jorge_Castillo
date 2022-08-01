using System.ComponentModel.DataAnnotations.Schema;

namespace Ev_4_Jorge_Castillo.Modelo
{
    [Table("Libro")] // Indicar la tabla al que pertenecerá la clase POCO
    public class Libro
    {
        public int Id { get; set; }
        public int IdEditorial { get; set; }
        public string Nombre { get; set; }
        public int NroSerie { get; set; }

        // Relaciones
        public virtual Editorial Editorial { get; set; }
    }

}
