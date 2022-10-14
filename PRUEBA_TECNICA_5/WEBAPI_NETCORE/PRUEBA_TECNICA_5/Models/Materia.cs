using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PRUEBA_TECNICA_5.Models
{
    public partial class Materia
    {
        public Materia()
        {
            Nota = new HashSet<Nota>();
        }

        public string MaCodigo { get; set; } = null!;
        public string? MaDescripcion { get; set; }

        [JsonIgnore]
        public virtual ICollection<Nota> Nota { get; set; }
    }
}
