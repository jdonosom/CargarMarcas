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
    public partial class FuncionarioUnidadService: FuncionarioUnidad, IFuncionarioUnidad
	{
		readonly BaseDatos DB = new BaseDatos();

		private FuncionarioUnidad current;

		#region Propiedades;
		string toxml;
		int count;
		public int Count
		{
			get { return count; }
		}

		public FuncionarioUnidad Current { get { return current; } }

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
		 
		public FuncionarioUnidadService()
		{
			//this.usuario = Credenciales.Usuario;
			//this.host = Credenciales.Host;
		}
		public void Clear()
		{
			this.IdEmpleado = 0;
			this.IdUnidad = 0;
		}

		public List<FuncionarioUnidad> GetAll(System.Int32 IdEmpleado, System.Int32 IdUnidad)
		{
			List<FuncionarioUnidad> oLst = new List<FuncionarioUnidad>();
            DB.Conectar();
			try
			{
				DB.CrearComando("FuncionarioUnidadSelProc @IdEmpleado, @IdUnidad");
				DB.AsignarParametroEntero("@IdEmpleado", IdEmpleado);
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
					current = new FuncionarioUnidad()
					{
						IdEmpleado = reader.IsDBNull(reader.GetOrdinal("IdEmpleado")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdEmpleado")),
						IdUnidad = reader.IsDBNull(reader.GetOrdinal("IdUnidad")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdUnidad")),
					};
                    oLst.Add(current);
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

		public FuncionarioUnidad Get(System.Int32 IdEmpleado, System.Int32 IdUnidad)
		{
			var oLst = new List<FuncionarioUnidad>();
			DB.Conectar();
			try
			{
				DB.CrearComando("FuncionarioUnidadSelProc @IdEmpleado, @IdUnidad");
				DB.AsignarParametroEntero("@IdEmpleado", IdEmpleado);
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
				if (reader.Read())
				{
					current = new FuncionarioUnidad()
					{
						IdEmpleado = reader.IsDBNull(reader.GetOrdinal("IdEmpleado")) ? 0: reader.GetInt32(reader.GetOrdinal("IdEmpleado")),
						IdUnidad   = reader.IsDBNull(reader.GetOrdinal("IdUnidad")) ? 0: reader.GetInt32(reader.GetOrdinal("IdUnidad")),
					};
					return current;
				}
				this.IdEmpleado = current.IdEmpleado;
				this.IdUnidad   = current.IdUnidad;
				
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

		public Boolean Delete(System.Int32 IdEmpleado, System.Int32 IdUnidad)
		{
			Boolean lRet = false;

			if (this.Exists(IdEmpleado, IdUnidad))
			{
				try
				{
					DB.Conectar();
					DB.CrearComando("FuncionarioUnidadDelProc @IdEmpleado, @IdUnidad");
					DB.AsignarParametroEntero("@IdEmpleado", IdEmpleado);
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
				DB.CrearComando("FuncionarioUnidadUpdProc @IdEmpleado, @IdUnidad");

				DB.AsignarParametroEntero("@IdEmpleado", IdEmpleado);
				DB.AsignarParametroEntero("@IdUnidad", IdUnidad);

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
		private Boolean Exists(System.Int32 IdEmpleado, System.Int32 IdUnidad)
		{
			Boolean lRet = false;
			try
			{
			//if (IdEmpleado, IdUnidad <= 0) throw new ReglasNegocioException("El id del contrato no es valido.");
				DB.Conectar();
				DB.CrearComando("FuncionarioUnidadSelProc @IdEmpleado, @IdUnidad");
				DB.AsignarParametroEntero("@IdEmpleado", IdEmpleado);
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
