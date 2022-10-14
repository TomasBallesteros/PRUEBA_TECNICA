using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PRUEBA_TECNICA_5.Models
{
    public partial class Estudiante
    {
        public Estudiante()
        {
            Nota = new HashSet<Nota>();
        }

        public string EsIdentificacion { get; set; } = null!;
        public string? EsPrimerNombre { get; set; }
        public string? EsSegundoNombre { get; set; }
        public string? EsPrimerApellido { get; set; }
        public string? EsSegundoApellido { get; set; }
        public string? EsTelefono { get; set; }
        public string? EsEmail { get; set; }

        [JsonIgnore]
        public virtual ICollection<Nota> Nota { get; set; }
    }
}
