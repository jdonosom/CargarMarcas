using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargarMarcas
{
    public class HorarioDia
    {
        public string DiaSemana { get; set; }
        public string Fecha { get; set; }
        public DateTime? HoraEntradaMañana { get; set; }
        public DateTime? HoraSalidaMañana { get; set; }
        public int ToleranciaEntradaMañana { get; set; }
        public int ToleranciaSalidaMañana { get; set; }
        public DateTime? HoraEntradaTarde { get; set; }
        public DateTime? HoraSalidaTarde { get; set; }
        public int ToleranciaEntradaTarde { get; set; }
        public int ToleranciaSalidaTarde { get; set; }
        public int TotalHorasSemanales { get; set; }
    }
}
