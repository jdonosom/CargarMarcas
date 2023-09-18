using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
#nullable disable
    public partial class DispositivosFuncionario
	{
		 private System.Int32 iddispositivo;
		 public System.Int32 IdDispositivo
		 {
			 get
			 {
				 return iddispositivo;
			 }
			 set
			 {
				 iddispositivo = value;
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
