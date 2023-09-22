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
    public partial class TipoContratoService : TipoContrato, ITipoContrato
    {
        private TipoContrato current;
        public TipoContrato Current { get; }
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

        public TipoContratoService()
        {
            //this.usuario = Credenciales.Usuario;
            //this.host = Credenciales.Host;
        }
        public void Clear()
        {
            this.IdTipoContrato = 0;
            this.Descripcion = "";
        }

        public TipoContrato Get(System.Int32 TipoContrato)
        {
            DB.Conectar();
            try
            {
                DB.CrearComando("TipoContratoSelProc @TipoContrato");
                DB.AsignarParametroEntero("@TipoContrato", TipoContrato);

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
                    current = new TipoContrato()
                    {
                        IdTipoContrato = reader.IsDBNull(reader.GetOrdinal("TipoContrato")) ? 0 : reader.GetInt32(reader.GetOrdinal("TipoContrato")),
                        Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "" : reader.GetString(reader.GetOrdinal("Descripcion")),
                    };
                    this.IdTipoContrato = current.IdTipoContrato;
                    this.Descripcion = current.Descripcion;
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


        public List<TipoContrato> GetAll()
        {
            var oLst = new List<TipoContrato>();
            DB.Conectar();
            try
            {
                DB.CrearComando("TipoContratoSelProc @TipoContrato");
                DB.AsignarParametroEntero("@TipoContrato", 0);

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
                    TipoContrato e = new TipoContrato()
                    {
                        IdTipoContrato = reader.IsDBNull(reader.GetOrdinal("TipoContrato")) ? 0 : reader.GetInt32(reader.GetOrdinal("TipoContrato")),
                        Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "" : reader.GetString(reader.GetOrdinal("Descripcion")),
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

        public Boolean Delete(System.Int32 TipoContrato)
        {
            Boolean lRet = false;

            if (this.Exists(TipoContrato))
            {
                try
                {
                    DB.Conectar();
                    DB.CrearComando("TipoContratoDelProc @TipoContrato");
                    DB.AsignarParametroEntero("@TipoContrato", TipoContrato);

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
                DB.CrearComando("TipoContratoUpdProc @TipoContrato, @Descripcion");

                DB.AsignarParametroEntero("@TipoContrato", IdTipoContrato);
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
        private Boolean Exists(System.Int32 TipoContrato)
        {
            Boolean lRet = false;
            try
            {
                //if (TipoContrato <= 0) throw new ReglasNegocioException("El id del contrato no es valido.");
                DB.Conectar();
                DB.CrearComando("TipoContratoSelProc @TipoContrato");
                DB.AsignarParametroEntero("@TipoContrato", TipoContrato);

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
