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
    public partial class ServiceFuncionario: Funcionario
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
		 
		 public ServiceFuncionario()
		 {
			 //this.usuario = Credenciales.Usuario;
			 //this.host = Credenciales.Host;
		 }
		 public void Clear()
		 {
			 this.IdEmpleado = 0;
			 this.Rut = "";
			 this.Nombres = "";
			 this.ApellidoPaterno = "";
			 this.ApellidoMaterno = "";
			 this.Foto = new byte[0] { };
			 this.Email = "";
		 }

		 public List<Funcionario> Get(System.Int32 IdEmpleado)
		 {
			 var oLst = new List<Funcionario>();
			 DB.Conectar();
			 try
			 {
				 DB.CrearComando("FuncionarioSelProc @IdEmpleado");
				 DB.AsignarParametroEntero("@IdEmpleado", IdEmpleado);

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
						 Funcionario e = new Funcionario()
						 {
							 IdEmpleado = reader.IsDBNull(reader.GetOrdinal("IdEmpleado")) ? 0: reader.GetInt32(reader.GetOrdinal("IdEmpleado")),
							 Rut = reader.IsDBNull(reader.GetOrdinal("Rut")) ? "": reader.GetString(reader.GetOrdinal("Rut")),
							 Nombres = reader.IsDBNull(reader.GetOrdinal("Nombres")) ? "": reader.GetString(reader.GetOrdinal("Nombres")),
							 ApellidoPaterno = reader.IsDBNull(reader.GetOrdinal("ApellidoPaterno")) ? "": reader.GetString(reader.GetOrdinal("ApellidoPaterno")),
							 ApellidoMaterno = reader.IsDBNull(reader.GetOrdinal("ApellidoMaterno")) ? "": reader.GetString(reader.GetOrdinal("ApellidoMaterno")),
							 Foto = reader.IsDBNull(reader.GetOrdinal("Foto")) ? new byte[0] { }: reader.GetValue(reader.GetOrdinal("Foto")) as byte[],
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
					 this.IdEmpleado = oLst[0].IdEmpleado;
					 this.Rut = oLst[0].Rut;
					 this.Nombres = oLst[0].Nombres;
					 this.ApellidoPaterno = oLst[0].ApellidoPaterno;
					 this.ApellidoMaterno = oLst[0].ApellidoMaterno;
					 this.Foto = oLst[0].Foto;
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

		 public Boolean Delete(System.Int32 IdEmpleado)
		 {
			 Boolean lRet = false;

			 if (this.Exists(IdEmpleado))
			 {
				 try
				 {
					 DB.Conectar();
					 DB.CrearComando("FuncionarioDelProc @IdEmpleado");
					 DB.AsignarParametroEntero("@IdEmpleado", IdEmpleado);

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
				 DB.CrearComando("FuncionarioUpdProc @IdEmpleado, @Rut, @Nombres, @ApellidoPaterno, @ApellidoMaterno, @Foto, @Email");

				 DB.AsignarParametroEntero("@IdEmpleado", IdEmpleado);
				 DB.AsignarParametroCadena("@Rut", Rut);
				 DB.AsignarParametroCadena("@Nombres", Nombres);
				 DB.AsignarParametroCadena("@ApellidoPaterno", ApellidoPaterno);
				 DB.AsignarParametroCadena("@ApellidoMaterno", ApellidoMaterno);
				 DB.AsignarParametroImage("@Foto", Foto);
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
		 private Boolean Exists(System.Int32 IdEmpleado)
		 {
			 Boolean lRet = false;
			 try
			 {
				//if (IdEmpleado <= 0) throw new ReglasNegocioException("El id del contrato no es valido.");
				 DB.Conectar();
				 DB.CrearComando("FuncionarioSelProc @IdEmpleado");
				 DB.AsignarParametroEntero("@IdEmpleado", IdEmpleado);

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
