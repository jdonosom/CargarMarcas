using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
#nullable disable
    public partial class TipoMarca
	{
		 private System.Int32 tipomarca;
		 public System.Int32 IdTipoMarca
		 {
			 get
			 {
				 return tipomarca;
			 }
			 set
			 {
				 tipomarca = value;
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
		 private System.Int32 autorizacion;
		 public System.Int32 Autorizacion
		 {
			 get
			 {
				 return autorizacion;
			 }
			 set
			 {
				 autorizacion = value;
			 }
		 }
	 }
}
