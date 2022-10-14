using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRUEBA_TECNICA_5.Models
{
    public class Notas
    {
        public int NoId { get; set; }
        public DateTime NoFecha { get; set; }
        public decimal NoNota { get; set; }
        public string NoEstudiante { get; set; }
        public string NoMateria { get; set; }
        public string NoPeriodo { get; set; }
    }
}