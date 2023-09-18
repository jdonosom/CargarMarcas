using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
#nullable disable
	public partial class Direccion
	{
		 private System.Int32 iddireccion;
		 public System.Int32 IdDireccion
		 {
			 get
			 {
				 return iddireccion;
			 }
			 set
			 {
				 iddireccion = value;
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
		 private System.String ubicacion;
		 public System.String Ubicacion
		 {
			 get
			 {
				 return ubicacion;
			 }
			 set
			 {
				 ubicacion = value;
			 }
		 }
		 private System.String telefono;
		 public System.String Telefono
		 {
			 get
			 {
				 return telefono;
			 }
			 set
			 {
				 telefono = value;
			 }
		 }
	 }
}
