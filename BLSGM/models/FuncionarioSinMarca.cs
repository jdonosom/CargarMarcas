using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FuncionarioSinMarca
    {
        public int IdEmpleado { get; set; }
        public string Rut { get; set; }
        public string NombreCompleto { get; set; }
        public string CorreoFuncionario { get; set; }
        public byte[] Foto { get; set; }
        public int IdUnidad { get; set; }
        public string Unidad { get; set; }
        public string CorreoUnidad { get; set; }
        public string Permiso { get; set; }
        public DateTime? FechaInicio { get; set; }   
        public DateTime? FechaTermino { get; set; }
        public string HoraMarca { get; set; }
        public DateTime? FechaMarca { get; set; }
        public int IdHorario { get; set; }
        public string Horario { get; set; }

    }
}
