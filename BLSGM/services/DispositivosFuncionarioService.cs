using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;

using Models;
using BL;
using SGFDataLayer;
using BLSGM.interfaces;

namespace BL
{
#nullable disable
    public partial class DispositivosFuncionarioService: DispositivosFuncionario, IDispositivosFuncionario
	{
		readonly BaseDatos DB = new BaseDatos();

		private DispositivosFuncionario current;

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
		 
		public DispositivosFuncionarioService()
		{
			//this.usuario = Credenciales.Usuario;
			//this.host = Credenciales.Host;
		}
		public void Clear()
		{
			this.IdDispositivo = 0;
			this.IdEmpleado = 0;
		}

		public List<DispositivosFuncionario> GetAll(int IdDispositivo)
		{
			var oLst = new List<DispositivosFuncionario>();
			DB.Conectar();
			try
			{
				DB.CrearComando("DispositivosFuncionarioSelProc @IdDispositivo, @IdEmpleado");
				DB.AsignarParametroEntero("@IdDispositivo", IdDispositivo);
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
					DispositivosFuncionario e = new DispositivosFuncionario()
					{
						IdDispositivo = reader.IsDBNull(reader.GetOrdinal("IdDispositivo")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdDispositivo")),
						IdEmpleado = reader.IsDBNull(reader.GetOrdinal("IdEmpleado")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdEmpleado")),
					};
					oLst.Add(e);

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

		public DispositivosFuncionario Get(int IdDispositivo, int IdEmpleado)
		{
			DB.Conectar();
			try
			{
				DB.CrearComando("DispositivosFuncionarioSelProc @IdDispositivo, @IdEmpleado");
				DB.AsignarParametroEntero("@IdDispositivo", IdDispositivo);
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
				if (reader.Read())
				{

					current = new DispositivosFuncionario()
					{
						IdDispositivo = reader.IsDBNull(reader.GetOrdinal("IdDispositivo")) ? 0: reader.GetInt32(reader.GetOrdinal("IdDispositivo")),
						IdEmpleado = reader.IsDBNull(reader.GetOrdinal("IdEmpleado")) ? 0: reader.GetInt32(reader.GetOrdinal("IdEmpleado")),
					};

                    this.IdDispositivo = current.IdDispositivo;
                    this.IdEmpleado = current.IdEmpleado;

                    return current;
					
				}
				reader.Close();
				return null;
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

		public Boolean Delete(System.Int32 IdDispositivo, System.Int32 IdEmpleado)
		{
			Boolean lRet = false;

			if (this.Exists(IdDispositivo, IdEmpleado))
			{
				try
				{
					DB.Conectar();
					DB.CrearComando("DispositivosFuncionarioDelProc @IdDispositivo, @IdEmpleado");
					DB.AsignarParametroEntero("@IdDispositivo", IdDispositivo);
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
				DB.CrearComando("DispositivosFuncionarioUpdProc @IdDispositivo, @IdEmpleado");

				DB.AsignarParametroEntero("@IdDispositivo", IdDispositivo);
				DB.AsignarParametroEntero("@IdEmpleado", IdEmpleado);

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
		private Boolean Exists(System.Int32 IdDispositivo, System.Int32 IdEmpleado)
		{
			Boolean lRet = false;
			try
			{
			//if (IdDispositivo, IdEmpleado <= 0) throw new ReglasNegocioException("El id del contrato no es valido.");
				DB.Conectar();
				DB.CrearComando("DispositivosFuncionarioSelProc @IdDispositivo, @IdEmpleado");
				DB.AsignarParametroEntero("@IdDispositivo", IdDispositivo);
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
