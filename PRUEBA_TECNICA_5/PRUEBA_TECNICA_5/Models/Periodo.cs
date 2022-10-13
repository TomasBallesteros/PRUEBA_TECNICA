using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PRUEBA_TECNICA_5.Models
{
    public partial class Periodo
    {
        public Periodo()
        {
            Nota = new HashSet<Nota>();
        }

        public string PeCodigo { get; set; } = null!;
        public DateTime? PeFechaInicial { get; set; }
        public DateTime? PeFechaFinal { get; set; }

        [JsonIgnore]
        public virtual ICollection<Nota> Nota { get; set; }
    }
}
