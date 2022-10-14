using System;
using System.Collections.Generic;

namespace PRUEBA_TECNICA_5.Models
{
    public partial class Nota
    {
        public int NoId { get; set; }
        public DateTime? NoFecha { get; set; }
        public decimal? NoNota { get; set; }
        public string? NoEstudiante { get; set; }
        public string? NoMateria { get; set; }
        public string? NoPeriodo { get; set; }

        public virtual Estudiante? oEstudiante { get; set; }
        public virtual Materia? oMateria { get; set; }
        public virtual Periodo? oPeriodo { get; set; }
    }
}
