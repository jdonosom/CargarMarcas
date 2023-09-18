using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
#nullable disable
    public partial class HorarioFuncionario
	{
		 private System.Int32 idhorario;
		 public System.Int32 IdHorario
		 {
			 get
			 {
				 return idhorario;
			 }
			 set
			 {
				 idhorario = value;
			 }
		 }
		 private System.Int32 idempleado;
		 public System.Int32 IdEmpleado
		 {
			 get
			 {
				 return idempleado;
			 }
			 set
			 {
				 idempleado = value;
			 }
		 }
	 }
}
