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
    public partial class FuncionarioTipoContratoService: FuncionarioTipoContrato, IFuncionarioTipoContrato
	{
		 readonly BaseDatos DB = new BaseDatos();

		#region Propiedades;
		string toxml;
		int count;
		private FuncionarioTipoContrato current;

		public FuncionarioTipoContrato Current
		{
			get { return current; }
			set { current = value; }
		}


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
		 
		 public FuncionarioTipoContratoService()
		 {
			 //this.usuario = Credenciales.Usuario;
			 //this.host = Credenciales.Host;
		 }
		 public void Clear()
		 {
			 this.TipoContrato = 0;
			 this.IdEmpleado = 0;
			 this.IdCargo = 0;
		 }

        public FuncionarioTipoContrato Get(System.Int32 TipoContrato, System.Int32 IdEmpleado, int IdCargo)
        {
            DB.Conectar();
            try
            {
                DB.CrearComando("FuncionarioTipoContratoSelProc @TipoContrato, @IdEmpleado");
                DB.AsignarParametroEntero("@TipoContrato", TipoContrato);
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
					FuncionarioTipoContrato e = new FuncionarioTipoContrato()
					{
						TipoContrato = reader.IsDBNull(reader.GetOrdinal("TipoContrato")) ? 0 : reader.GetInt32(reader.GetOrdinal("TipoContrato")),
						IdEmpleado = reader.IsDBNull(reader.GetOrdinal("IdEmpleado")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdEmpleado")),
						IdCargo = reader.IsDBNull(reader.GetOrdinal("IdCargo")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdCargo")),
					};
					return e;
   
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

        public List<FuncionarioTipoContrato> GetAll(System.Int32 TipoContrato)
		 {
			 var oLst = new List<FuncionarioTipoContrato>();
			 DB.Conectar();
			 try
			 {
				 DB.CrearComando("FuncionarioTipoContratoSelProc @TipoContrato, @IdEmpleado");
				 DB.AsignarParametroEntero("@TipoContrato", TipoContrato);
				 DB.AsignarParametroEntero("@IdEmpleado", 0);

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
					FuncionarioTipoContrato e = new FuncionarioTipoContrato()
					{
						TipoContrato = reader.IsDBNull(reader.GetOrdinal("TipoContrato")) ? 0: reader.GetInt32(reader.GetOrdinal("TipoContrato")),
						IdEmpleado = reader.IsDBNull(reader.GetOrdinal("IdEmpleado")) ? 0: reader.GetInt32(reader.GetOrdinal("IdEmpleado")),
						IdCargo = reader.IsDBNull(reader.GetOrdinal("IdCargo")) ? 0: reader.GetInt32(reader.GetOrdinal("IdCargo")),
					};
					oLst.Add( e );

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

		 public Boolean Delete(int TipoContrato, int IdEmpleado, int IdCargo)
		 {
			 Boolean lRet = false;

			 if (this.Exists(TipoContrato, IdEmpleado, IdCargo))
			 {
				 try
				 {
					 DB.Conectar();
					 DB.CrearComando("FuncionarioTipoContratoDelProc @TipoContrato, @IdEmpleado");
					 DB.AsignarParametroEntero("@TipoContrato", TipoContrato);
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
				 DB.CrearComando("FuncionarioTipoContratoUpdProc @TipoContrato, @IdEmpleado, @IdCargo");

				 DB.AsignarParametroEntero("@TipoContrato", current.TipoContrato);
				 DB.AsignarParametroEntero("@IdEmpleado", current.IdEmpleado);
				 DB.AsignarParametroEntero("@IdCargo", current.IdCargo);

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
		 private Boolean Exists(System.Int32 TipoContrato, System.Int32 IdEmpleado, int IdCargo)
		 {
			 Boolean lRet = false;
			 try
			 {
				//if (TipoContrato, IdEmpleado <= 0) throw new ReglasNegocioException("El id del contrato no es valido.");
				 DB.Conectar();
				 DB.CrearComando("FuncionarioTipoContratoSelProc @TipoContrato, @IdEmpleado");
				 DB.AsignarParametroEntero("@TipoContrato", TipoContrato);
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
