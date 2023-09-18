using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
#nullable disable
    public partial class Dispositivos
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
		 private System.String ip;
		 public System.String IP
		 {
			 get
			 {
				 return ip;
			 }
			 set
			 {
				 ip = value;
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
		 private System.String mac;
		 public System.String Mac
		 {
			 get
			 {
				 return mac;
			 }
			 set
			 {
				 mac = value;
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
	 }
}
