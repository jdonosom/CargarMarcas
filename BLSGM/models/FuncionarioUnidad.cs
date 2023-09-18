using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
#nullable disable
    public partial class FuncionarioUnidad
	{
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
		 private System.Int32 idunidad;
		 public System.Int32 IdUnidad
		 {
			 get
			 {
				 return idunidad;
			 }
			 set
			 {
				 idunidad = value;
			 }
		 }
	 }
}
