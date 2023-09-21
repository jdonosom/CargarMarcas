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
    public partial class TipoMarcaService: TipoMarca
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
		 
		 public TipoMarcaService()
		 {
			 //this.usuario = Credenciales.Usuario;
			 //this.host = Credenciales.Host;
		 }
		 public void Clear()
		 {
			 this.IdTipoMarca = 0;
			 this.Descripcion = "";
			 this.Autorizacion = 0;
		 }

		 public List<TipoMarca> Get(System.Int32 TipoMarca)
		 {
			 var oLst = new List<TipoMarca>();
			 DB.Conectar();
			 try
			 {
				 DB.CrearComando("TipoMarcaSelProc @TipoMarca");
				 DB.AsignarParametroEntero("@TipoMarca", TipoMarca);

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
						 TipoMarca e = new TipoMarca()
						 {
							 IdTipoMarca = reader.IsDBNull(reader.GetOrdinal("TipoMarca")) ? 0: reader.GetInt32(reader.GetOrdinal("TipoMarca")),
							 Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "": reader.GetString(reader.GetOrdinal("Descripcion")),
							 Autorizacion = reader.IsDBNull(reader.GetOrdinal("Autorizacion")) ? 0: reader.GetInt32(reader.GetOrdinal("Autorizacion")),
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
					 this.IdTipoMarca = oLst[0].IdTipoMarca;
					 this.Descripcion = oLst[0].Descripcion;
					 this.Autorizacion = oLst[0].Autorizacion;
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

		 public Boolean Delete(System.Int32 TipoMarca)
		 {
			 Boolean lRet = false;

			 if (this.Exists(TipoMarca))
			 {
				 try
				 {
					 DB.Conectar();
					 DB.CrearComando("TipoMarcaDelProc @TipoMarca");
					 DB.AsignarParametroEntero("@TipoMarca", TipoMarca);

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
				 DB.CrearComando("TipoMarcaUpdProc @TipoMarca, @Descripcion, @Autorizacion");

				 DB.AsignarParametroEntero("@TipoMarca", IdTipoMarca);
				 DB.AsignarParametroCadena("@Descripcion", Descripcion);
				 DB.AsignarParametroEntero("@Autorizacion", Autorizacion);

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
		 private Boolean Exists(System.Int32 TipoMarca)
		 {
			 Boolean lRet = false;
			 try
			 {
				//if (TipoMarca <= 0) throw new ReglasNegocioException("El id del contrato no es valido.");
				 DB.Conectar();
				 DB.CrearComando("TipoMarcaSelProc @TipoMarca");
				 DB.AsignarParametroEntero("@TipoMarca", TipoMarca);

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
