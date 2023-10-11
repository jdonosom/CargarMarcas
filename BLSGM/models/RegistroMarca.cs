using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RegistroMarca
    {
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int TipoMarca { get; set; }
        public string Serie { get; set; }
        public string Email { get; set; }
    }
}
