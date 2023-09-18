using System.Data;
using System.Data.Common;
using System.Reflection;

using Models;
using DataLayer;
using Interfaces;

namespace BL
{
#nullable disable
    public partial class ServiceCargo : Cargo, ICargo
	{
		readonly BaseDatos DB = new BaseDatos();

		Cargo current;
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
		private string mac;

		string ICargo.Usuario => usuario;

		string ICargo.Mac
		{
			get { return mac; }
			set { mac = value; }
		}

        string ICargo.Host { get => host; set => host = value; }

		public ServiceCargo()
		{
			////this.usuario = Credenciales.Usuario;
			////this.host = Credenciales.Host;
		}
		 public void Clear()
		 {
			 this.IdCargo = 0;
			 this.Descripcion = "";
		 }

		 public List<Cargo> GetAll()
		 {
			 var oLst = new List<Cargo>();
			 DB.Conectar();
			 try
			 {
				 DB.CrearComando("CargoSelProc @IdCargo");
				 DB.AsignarParametroEntero("@IdCargo", IdCargo);

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
						 Cargo e = new Cargo()
						 {
							 IdCargo = reader.IsDBNull(reader.GetOrdinal("IdCargo")) ? 0: reader.GetInt32(reader.GetOrdinal("IdCargo")),
							 Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "": reader.GetString(reader.GetOrdinal("Descripcion")),
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
					 this.IdCargo = oLst[0].IdCargo;
					 this.Descripcion = oLst[0].Descripcion;
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

		 public Boolean Delete(System.Int32 IdCargo)
		 {
			 Boolean lRet = false;

			 if (this.Exists(IdCargo))
			 {
				 try
				 {
					 DB.Conectar();
					 DB.CrearComando("CargoDelProc @IdCargo");
					 DB.AsignarParametroEntero("@IdCargo", IdCargo);

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
				 DB.CrearComando("CargoUpdProc @IdCargo, @Descripcion");

				 DB.AsignarParametroEntero("@IdCargo", IdCargo);
				 DB.AsignarParametroCadena("@Descripcion", Descripcion);

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
		 private Boolean Exists(System.Int32 IdCargo)
		 {
			 Boolean lRet = false;
			 try
			 {
				//if (IdCargo <= 0) throw new ReglasNegocioException("El id del contrato no es valido.");
				 DB.Conectar();
				 DB.CrearComando("CargoSelProc @IdCargo");
				 DB.AsignarParametroEntero("@IdCargo", IdCargo);

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

        Cargo ICargo.Get(int Id)
        {
			current = null;
            DB.Conectar();
            try
            {
                DB.CrearComando("CargoSelProc @IdCargo");
                DB.AsignarParametroEntero("@IdCargo", IdCargo);

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
                        Cargo e = new Cargo()
                        {
                            IdCargo = reader.IsDBNull(reader.GetOrdinal("IdCargo")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdCargo")),
                            Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "" : reader.GetString(reader.GetOrdinal("Descripcion")),
                        };
                        current = e;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                reader.Close();
                return current;
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
        #endregion

    }
}
