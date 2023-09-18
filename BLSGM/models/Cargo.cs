using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
#nullable disable
	public partial class Cargo
	{
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
