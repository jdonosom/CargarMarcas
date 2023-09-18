using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
#nullable disable
	public partial class TipoContrato
	{
		 private System.Int32 tipocontrato;
		 public System.Int32 IdTipoContrato
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
		 private System.String descripcion;
		 public System.String Descripcion
		 {
			 get
			 {
				 return descripcion;
			 }
			 set
			 {
				 descripcion = value;
			 }
		 }
	 }
}
