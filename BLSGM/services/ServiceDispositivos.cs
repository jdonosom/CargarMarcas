using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;

using Models;
using BL;
using DataLayer;

namespace BL
{
#nullable disable
    public partial class ServiceDispositivos: Dispositivos
	{
		 readonly BaseDatos DB = new BaseDatos();
		 #region Propiedades;
		 string toxml;
		 int count;
		 public int Count
		 {
			 get { return count; }
		 }
		 #endregion
		 
		 #region Tipo Datos
		 #endregion
		 
		 #region Metodos Publicos
		 
		 private string usuario;
		 private string host;
		 
		 
		 public string Host
		 {
			 get { return host; }
			 set { host = value; }
		 }
		 
		 public ServiceDispositivos()
		 {
			 //this.usuario = Credenciales.Usuario;
			 //this.host = Credenciales.Host;
		 }
		 public void Clear()
		 {
			 this.IdDispositivo = 0;
			 this.Descripcion = "";
			 this.IP = "";
			 this.Serie = "";
			 this.Mac = "";
			 this.Ubicacion = "";
		 }

		 public List<Dispositivos> Get(System.Int32 IdDispositivo)
		 {
			 var oLst = new List<Dispositivos>();
			 DB.Conectar();
			 try
			 {
				 DB.CrearComando("DispositivosSelProc @IdDispositivo");
				 DB.AsignarParametroEntero("@IdDispositivo", IdDispositivo);

				 DbDataReader dr = DB.EjecutarConsulta();

				 DataTable dt = new DataTable();
				 dt.TableName = MethodBase.GetCurrentMethod().DeclaringType.Name;
				 dt.Load(dr);
				 this.count = dt.Rows.Count;

				 if (this.count > 0)
				 {
					 System.IO.StringWriter writer = new System.IO.StringWriter();
					 dt.WriteXml(writer, XmlWriteMode.WriteSchema);
					 this.toxml = writer.ToString();
				 }

				 DataTableReader reader = new DataTableReader(dt);

				 if (reader == null)
				 {
					 this.count = 0;
					 return null;
				 }
				 while (reader.Read())
				 {
					 try
					 {
						 Dispositivos e = new Dispositivos()
						 {
							 IdDispositivo = reader.IsDBNull(reader.GetOrdinal("IdDispositivo")) ? 0: reader.GetInt32(reader.GetOrdinal("IdDispositivo")),
							 Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "": reader.GetString(reader.GetOrdinal("Descripcion")),
							 IP = reader.IsDBNull(reader.GetOrdinal("IP")) ? "": reader.GetString(reader.GetOrdinal("IP")),
							 Serie = reader.IsDBNull(reader.GetOrdinal("Serie")) ? "": reader.GetString(reader.GetOrdinal("Serie")),
							 Mac = reader.IsDBNull(reader.GetOrdinal("Mac")) ? "": reader.GetString(reader.GetOrdinal("Mac")),
							 Ubicacion = reader.IsDBNull(reader.GetOrdinal("Ubicacion")) ? "": reader.GetString(reader.GetOrdinal("Ubicacion")),
						 };
						 oLst.Add( e );
					 }
					 catch (Exception)
					 {
						 throw;
					 }
				 }
				 if (oLst.Count == 1)
				 {
					 this.IdDispositivo = oLst[0].IdDispositivo;
					 this.Descripcion = oLst[0].Descripcion;
					 this.IP = oLst[0].IP;
					 this.Serie = oLst[0].Serie;
					 this.Mac = oLst[0].Mac;
					 this.Ubicacion = oLst[0].Ubicacion;
				 }
				 reader.Close();
				 return oLst;
			 }
			 catch (BaseDatosException ex)
			 {
				 throw new ReglasNegocioException(ex.Message.ToString());
			 }
			 finally
			 {
				 DB.Desconectar();
			 }
		 }

		 public Boolean Delete(System.Int32 IdDispositivo)
		 {
			 Boolean lRet = false;

			 if (this.Exists(IdDispositivo))
			 {
				 try
				 {
					 DB.Conectar();
					 DB.CrearComando("DispositivosDelProc @IdDispositivo");
					 DB.AsignarParametroEntero("@IdDispositivo", IdDispositivo);

					 DB.EjecutarComando();
					 lRet = true;
				 }
				 catch (BaseDatosException)
				 {
					 lRet = false;
					 throw new ReglasNegocioException("Error al acceder a la base de datos para eliminar el registro.");
				 }
				 catch (ReglasNegocioException)
				 {
					 lRet = false;
					 throw new ReglasNegocioException("Error al eliminar el registro.");
				 }
				 finally
				 {
					 DB.Desconectar();
				 }
			 }
			 return lRet;
		 }

		 public Boolean Update()
		 {
			 Boolean lRet = false;

			 try
			 {
				 DB.Conectar();
				 DB.CrearComando("DispositivosUpdProc @IdDispositivo, @Descripcion, @IP, @Serie, @Mac, @Ubicacion");

				 DB.AsignarParametroEntero("@IdDispositivo", IdDispositivo);
				 DB.AsignarParametroCadena("@Descripcion", Descripcion);
				 DB.AsignarParametroCadena("@IP", IP);
				 DB.AsignarParametroCadena("@Serie", Serie);
				 DB.AsignarParametroCadena("@Mac", Mac);
				 DB.AsignarParametroCadena("@Ubicacion", Ubicacion);

				 DB.EjecutarComando();
				 lRet = true;
			 }
			 catch (BaseDatosException)
			 {
				 lRet = false;
				 throw new ReglasNegocioException("Error al acceder a la base de datos para insertar el registro.");
			 }
			 catch (ReglasNegocioException)
			 {
				 lRet = false;
				 throw new ReglasNegocioException("Error al eliminar el cliente.");
			 }
			 catch (Exception e)
			 {
				 lRet = false;
				 throw new ReglasNegocioException(e.Message);
			 }
			 finally
			 {
				 DB.Desconectar();
			 }
			 return lRet;
		}

		 #endregion

		 #region Metodos Privados
		 private Boolean Exists(System.Int32 IdDispositivo)
		 {
			 Boolean lRet = false;
			 try
			 {
				//if (IdDispositivo <= 0) throw new ReglasNegocioException("El id del contrato no es valido.");
				 DB.Conectar();
				 DB.CrearComando("DispositivosSelProc @IdDispositivo");
				 DB.AsignarParametroEntero("@IdDispositivo", IdDispositivo);

				 DbDataReader dr = DB.EjecutarConsulta();

				 DataTable dt = new DataTable();

				 dt.Load(dr);
				 this.count = dt.Rows.Count;
				 DataTableReader reader = new DataTableReader(dt);
				 if (this.count <= 0)
					     return lRet;

				 lRet = true;
				 reader.Close();
				 DB.Desconectar();
			 }
			 catch (BaseDatosException)
			 {
				 throw new ReglasNegocioException("Error al acceder a la base de datos para validar la existencia del registro.");
			 }
			 catch (ReglasNegocioException ex)
			 {
				 throw new ReglasNegocioException("Error a obtener los datos." + ex.Message);
			 }
			 return lRet;
		 }
		 #endregion

	}
}
