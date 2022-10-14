using System.ComponentModel.DataAnnotations;

namespace PRUEBA_TECNICA_4.Models
{
    public class Notas
    {
        public int NoId { get; set; }

        [Required(ErrorMessage = "El campo Fecha es obligatorio")]
        public DateTime? NoFecha { get; set; }

        [Required(ErrorMessage = "El campo Nota es obligatorio")]
        public decimal? NoNota { get; set; }

        [Required(ErrorMessage = "El campo Estudiante es obligatorio")]
        public string? NoEstudiante { get; set; }

        [Required(ErrorMessage = "El campo Materia es obligatorio")]
        public string? NoMateria { get; set; }

        [Required(ErrorMessage = "El campo Periodo es obligatorio")]
        public string? NoPeriodo { get; set; }
    }
}
