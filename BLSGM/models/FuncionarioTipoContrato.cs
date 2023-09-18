using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
#nullable disable
    public partial class FuncionarioTipoContrato
	{
		 private System.Int32 tipocontrato;
		 public System.Int32 TipoContrato
		 {
			 get
			 {
				 return tipocontrato;
			 }
			 set
			 {
				 tipocontrato = value;
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
		 private System.Int32 idcargo;
		 public System.Int32 IdCargo
		 {
			 get
			 {
				 return idcargo;
			 }
			 set
			 {
				 idcargo = value;
			 }
		 }
	 }
}
