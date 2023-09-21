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
    public partial class UnidadService: Unidad
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
		 
		 public UnidadService()
		 {
			 //this.usuario = Credenciales.Usuario;
			 //this.host = Credenciales.Host;
		 }
		 public void Clear()
		 {
			 this.IdDireccion = 0;
			 this.IdUnidad = 0;
			 this.Descripcion = "";
			 this.Ubicacion = "";
			 this.Telefono = "";
			 this.Email = "";
		 }

		 public List<Unidad> Get(System.Int32 IdUnidad)
		 {
			 var oLst = new List<Unidad>();
			 DB.Conectar();
			 try
			 {
				 DB.CrearComando("UnidadSelProc @IdUnidad");
				 DB.AsignarParametroEntero("@IdUnidad", IdUnidad);

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
						 Unidad e = new Unidad()
						 {
							 IdDireccion = reader.IsDBNull(reader.GetOrdinal("IdDireccion")) ? 0: reader.GetInt32(reader.GetOrdinal("IdDireccion")),
							 IdUnidad = reader.IsDBNull(reader.GetOrdinal("IdUnidad")) ? 0: reader.GetInt32(reader.GetOrdinal("IdUnidad")),
							 Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "": reader.GetString(reader.GetOrdinal("Descripcion")),
							 Ubicacion = reader.IsDBNull(reader.GetOrdinal("Ubicacion")) ? "": reader.GetString(reader.GetOrdinal("Ubicacion")),
							 Telefono = reader.IsDBNull(reader.GetOrdinal("Telefono")) ? "": reader.GetString(reader.GetOrdinal("Telefono")),
							 Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "": reader.GetString(reader.GetOrdinal("Email")),
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
					 this.IdDireccion = oLst[0].IdDireccion;
					 this.IdUnidad = oLst[0].IdUnidad;
					 this.Descripcion = oLst[0].Descripcion;
					 this.Ubicacion = oLst[0].Ubicacion;
					 this.Telefono = oLst[0].Telefono;
					 this.Email = oLst[0].Email;
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

		 public Boolean Delete(System.Int32 IdUnidad)
		 {
			 Boolean lRet = false;

			 if (this.Exists(IdUnidad))
			 {
				 try
				 {
					 DB.Conectar();
					 DB.CrearComando("UnidadDelProc @IdUnidad");
					 DB.AsignarParametroEntero("@IdUnidad", IdUnidad);

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
				 DB.CrearComando("UnidadUpdProc @IdDireccion, @IdUnidad, @Descripcion, @Ubicacion, @Telefono, @Email");

				 DB.AsignarParametroEntero("@IdDireccion", IdDireccion);
				 DB.AsignarParametroEntero("@IdUnidad", IdUnidad);
				 DB.AsignarParametroCadena("@Descripcion", Descripcion);
				 DB.AsignarParametroCadena("@Ubicacion", Ubicacion);
				 DB.AsignarParametroCadena("@Telefono", Telefono);
				 DB.AsignarParametroCadena("@Email", Email);

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
		 private Boolean Exists(System.Int32 IdUnidad)
		 {
			 Boolean lRet = false;
			 try
			 {
				//if (IdUnidad <= 0) throw new ReglasNegocioException("El id del contrato no es valido.");
				 DB.Conectar();
				 DB.CrearComando("UnidadSelProc @IdUnidad");
				 DB.AsignarParametroEntero("@IdUnidad", IdUnidad);

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
