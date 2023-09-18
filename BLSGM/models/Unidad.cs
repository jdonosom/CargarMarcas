using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
#nullable disable
	public partial class Unidad
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
		 private System.String email;
		 public System.String Email
		 {
			 get
			 {
				 return email;
			 }
			 set
			 {
				 email = value;
			 }
		 }
	 }
}
