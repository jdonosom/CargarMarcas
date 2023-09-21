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
    public partial class RegistroService: Registro
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
		 
		 public RegistroService()
		 {
			 //this.usuario = Credenciales.Usuario;
			 //this.host = Credenciales.Host;
		 }
		 public void Clear()
		 {
			 this.Id = 0;
			 this.Fecha = Convert.ToDateTime("01/01/2000");
			 this.Hora = "";
			 this.TipoMarca = 0;
			 this.Serie = "";
		 }

		 public List<Registro> Get(System.Int32 TipoMarca)
		 {
			 var oLst = new List<Registro>();
			 DB.Conectar();
			 try
			 {
				 DB.CrearComando("RegistroSelProc @TipoMarca");
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
						 Registro e = new Registro()
						 {
							 Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0: reader.GetInt32(reader.GetOrdinal("Id")),
							 Fecha = reader.IsDBNull(reader.GetOrdinal("Fecha")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("Fecha")),
							 Hora = reader.IsDBNull(reader.GetOrdinal("Hora")) ? "": reader.GetString(reader.GetOrdinal("Hora")),
							 TipoMarca = reader.IsDBNull(reader.GetOrdinal("TipoMarca")) ? 0: reader.GetInt32(reader.GetOrdinal("TipoMarca")),
							 Serie = reader.IsDBNull(reader.GetOrdinal("Serie")) ? "": reader.GetString(reader.GetOrdinal("Serie")),
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
					 this.Id = oLst[0].Id;
					 this.Fecha = oLst[0].Fecha;
					 this.Hora = oLst[0].Hora;
					 this.TipoMarca = oLst[0].TipoMarca;
					 this.Serie = oLst[0].Serie;
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
					 DB.CrearComando("RegistroDelProc @TipoMarca");
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
				 DB.CrearComando("RegistroUpdProc @Id, @Fecha, @Hora, @TipoMarca, @Serie");

				 DB.AsignarParametroEntero("@Id", Id);
				 DB.AsignarParametroFecha("@Fecha", Fecha);
				 DB.AsignarParametroCadena("@Hora", Hora);
				 DB.AsignarParametroEntero("@TipoMarca", TipoMarca);
				 DB.AsignarParametroCadena("@Serie", Serie);

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
				 DB.CrearComando("RegistroSelProc @TipoMarca");
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
