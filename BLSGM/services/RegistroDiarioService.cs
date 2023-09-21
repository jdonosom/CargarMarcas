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
    public partial class RegistroDiarioService: RegistroDiario, IRegistroDiario
	{
		private RegistroDiario current;
        public RegistroDiario Current { get; }

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
		 
		public RegistroDiarioService()
		{
			//this.usuario = Credenciales.Usuario;
			//this.host = Credenciales.Host;
		}
		public void Clear()
		{
			this.IdEmpleado = 0;
			this.Fecha = Convert.ToDateTime("01/01/2000");
			this.Entrada = Convert.ToDateTime("01/01/2000");
			this.Salida = Convert.ToDateTime("01/01/2000");
			this.HorasTrabajadas = 0;
		}

        public List<RegistroDiario> GetAll()
        {
            var oLst = new List<RegistroDiario>();
            DB.Conectar();
            try
            {
                DB.CrearComando("RegistroDiarioSelProc @IdEmpleado");
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
                    current = new RegistroDiario()
                    {
                        IdEmpleado = reader.IsDBNull(reader.GetOrdinal("IdEmpleado")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdEmpleado")),
                        Fecha = reader.IsDBNull(reader.GetOrdinal("Fecha")) ? Convert.ToDateTime("01/01/2000") : reader.GetDateTime(reader.GetOrdinal("Fecha")),
                        Entrada = reader.IsDBNull(reader.GetOrdinal("Entrada")) ? Convert.ToDateTime("01/01/2000") : reader.GetDateTime(reader.GetOrdinal("Entrada")),
                        Salida = reader.IsDBNull(reader.GetOrdinal("Salida")) ? Convert.ToDateTime("01/01/2000") : reader.GetDateTime(reader.GetOrdinal("Salida")),
                        HorasTrabajadas = reader.IsDBNull(reader.GetOrdinal("HorasTrabajadas")) ? 0 : reader.GetFloat(reader.GetOrdinal("HorasTrabajadas")),
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


        public RegistroDiario Get(int IdEmpleado, DateTime Fecha)
		{
			var oLst = new List<RegistroDiario>();
			DB.Conectar();
			try
			{
				DB.CrearComando("RegistroDiarioSelProc @IdEmpleado, @Fecha");
				DB.AsignarParametroEntero("@IdEmpleado", IdEmpleado);
				DB.AsignarParametroCadena("@Fecha", Fecha.ToString("yyyyMMdd") );

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
					current = new RegistroDiario()
					{
						IdEmpleado = reader.IsDBNull(reader.GetOrdinal("IdEmpleado")) ? 0: reader.GetInt32(reader.GetOrdinal("IdEmpleado")),
						Fecha = reader.IsDBNull(reader.GetOrdinal("Fecha")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("Fecha")),
						Entrada = reader.IsDBNull(reader.GetOrdinal("Entrada")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("Entrada")),
						Salida = reader.IsDBNull(reader.GetOrdinal("Salida")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("Salida")),
						HorasTrabajadas = reader.IsDBNull(reader.GetOrdinal("HorasTrabajadas")) ? 0: reader.GetFloat(reader.GetOrdinal("HorasTrabajadas")),
					};

                    this.IdEmpleado = current.IdEmpleado;
                    this.Fecha = current.Fecha;
                    this.Entrada = current.Entrada;
                    this.Salida = current.Salida;
                    this.HorasTrabajadas = current.HorasTrabajadas;
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

		public Boolean Delete(System.Int32 IdEmpleado)
		{
			Boolean lRet = false;

			if (this.Exists(IdEmpleado))
			{
				try
				{
					DB.Conectar();
					DB.CrearComando("RegistroDiarioDelProc @IdEmpleado");
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
				DB.CrearComando("RegistroDiarioUpdProc @IdEmpleado, @Fecha, @Entrada, @Salida, @HorasTrabajadas");

				DB.AsignarParametroEntero("@IdEmpleado", IdEmpleado);
				DB.AsignarParametroFecha("@Fecha", Fecha);
				DB.AsignarParametroFecha("@Entrada", Entrada);
				DB.AsignarParametroFecha("@Salida", Salida);
				DB.AsignarParametroFloat("@HorasTrabajadas", HorasTrabajadas);

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
				DB.CrearComando("RegistroDiarioSelProc @IdEmpleado");
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
