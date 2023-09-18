using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
#nullable disable
    public partial class Registro
	{
		 private System.Int32 id;
		 public System.Int32 Id
		 {
			 get
			 {
				 return id;
			 }
			 set
			 {
				 id = value;
			 }
		 }
		 private System.DateTime fecha;
		 public System.DateTime Fecha
		 {
			 get
			 {
				 return fecha;
			 }
			 set
			 {
				 fecha = value;
			 }
		 }
		 private System.String hora;
		 public System.String Hora
		 {
			 get
			 {
				 return hora;
			 }
			 set
			 {
				 hora = value;
			 }
		 }
		 private System.Int32 tipomarca;
		 public System.Int32 TipoMarca
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
		 private System.String serie;
		 public System.String Serie
		 {
			 get
			 {
				 return serie;
			 }
			 set
			 {
				 serie = value;
			 }
		 }
	 }
}
