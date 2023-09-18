using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
#nullable disable
    public partial class RegistroDiario
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
		 private System.DateTime entrada;
		 public System.DateTime Entrada
		 {
			 get
			 {
				 return entrada;
			 }
			 set
			 {
				 entrada = value;
			 }
		 }
		 private System.DateTime salida;
		 public System.DateTime Salida
		 {
			 get
			 {
				 return salida;
			 }
			 set
			 {
				 salida = value;
			 }
		 }
		 private System.Single horastrabajadas;
		 public System.Single HorasTrabajadas
		 {
			 get
			 {
				 return horastrabajadas;
			 }
			 set
			 {
				 horastrabajadas = value;
			 }
		 }
	 }
}
