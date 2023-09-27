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
    public partial class HorarioService : Horario, IHorario
    {
        readonly BaseDatos DB = new BaseDatos();

        private Horario current;
        public Horario Current
        {
            get => current;
            set
            {
                current = value;
            }
        }

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

        public HorarioService()
        {
            //this.usuario = Credenciales.Usuario;
            //this.host = Credenciales.Host;
        }
        public void Clear()
        {
            this.IdHorario = 0;
            this.Descripcion = "";
            this.Desde = default;
            this.Hasta = default;

            this.Lunes = "";
            this.L_EntradaMañana = default; // default;
            this.L_SalidaMañana = default;
            this.L_EntradaTarde = default;
            this.L_SalidaTarde = default;
            this.L_ToleranciaEntrada = 0;
            this.L_ToleranciaSalida = 0;

            this.Martes = "";
            this.M_EntradaMañana = default;
            this.M_SalidaMañana = default;
            this.M_EntradaTarde = default;
            this.M_SalidaTarde = default;
            this.M_ToleranciaEntrada = 0;
            this.M_ToleranciaSalida = 0;

            this.Miercoles = "";
            this.X_EntradaMañana = default;
            this.X_SalidaMañana = default;
            this.X_EntradaTarde = default;
            this.X_SalidaTarde = default;
            this.X_ToleranciaEntrada = 0;
            this.X_ToleranciaSalida = 0;

            this.Jueves = "";
            this.J_EntradaMañana = default;
            this.J_SalidaMañana = default;
            this.J_EntradaTarde = default;
            this.J_SalidaTarde = default;
            this.J_ToleranciaEntrada = 0;
            this.J_ToleranciaSalida = 0;

            this.Viernes = "";
            this.V_EntradaMañana = default;
            this.V_SalidaMañana = default;
            this.V_EntradaTarde = default;
            this.V_SalidaTarde = default;
            this.V_ToleranciaEntrada = 0;
            this.V_ToleranciaSalida = 0;

            this.Sabado = "";
            this.S_EntradaMañana = default;
            this.S_SalidaMañana = default;
            this.S_EntradaTarde = default;
            this.S_SalidaTarde = default;
            this.S_ToleranciaEntrada = 0;
            this.S_ToleranciaSalida = 0;

            this.Domingo = "";
            this.D_EntradaMañana = default;
            this.D_SalidaMañana = default;
            this.D_EntradaTarde = default;
            this.D_SalidaTarde = default;
            this.D_ToleranciaEntrada = 0;
            this.D_ToleranciaSalida = 0;
            this.TotalHorasSemanales = 0;

        }

        public List<Horario> GetAll()
        {
            var oLst = new List<Horario>();
            DB.Conectar();
            try
            {
                DB.CrearComando("HorarioSelProc @IdHorario");
                DB.AsignarParametroEntero("@IdHorario", 0);

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
                    current = RowData(reader);
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

        public Horario GetFuncionario(int IdEmpleado)
        {
            var oLst = new List<Horario>();
            DB.Conectar();
            try
            {
                DB.CrearComando("HorarioFuncionarioSelProc @IdEmpleado");
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
                    current = RowData(reader);

                    #region Asignacion de propiedades
                    this.IdHorario = current.IdHorario;
                    this.Descripcion = current.Descripcion;
                    this.Lunes = current.Lunes;
                    this.L_EntradaMañana = current.L_EntradaMañana;
                    this.L_SalidaMañana = current.L_SalidaMañana;
                    this.L_EntradaTarde = current.L_EntradaTarde;
                    this.L_SalidaTarde = current.L_SalidaTarde;
                    this.L_ToleranciaEntrada = current.L_ToleranciaEntrada;
                    this.L_ToleranciaSalida = current.L_ToleranciaSalida;
                    this.Martes = current.Martes;
                    this.M_EntradaMañana = current.M_EntradaMañana;
                    this.M_SalidaMañana = current.M_SalidaMañana;
                    this.M_EntradaTarde = current.M_EntradaTarde;
                    this.M_SalidaTarde = current.M_SalidaTarde;
                    this.M_ToleranciaEntrada = current.M_ToleranciaEntrada;
                    this.M_ToleranciaSalida = current.M_ToleranciaSalida;
                    this.Miercoles = current.Miercoles;
                    this.X_EntradaMañana = current.X_EntradaMañana;
                    this.X_SalidaMañana = current.X_SalidaMañana;
                    this.X_EntradaTarde = current.X_EntradaTarde;
                    this.X_SalidaTarde = current.X_SalidaTarde;
                    this.X_ToleranciaEntrada = current.X_ToleranciaEntrada;
                    this.X_ToleranciaSalida = current.X_ToleranciaSalida;
                    this.Jueves = current.Jueves;
                    this.J_EntradaMañana = current.J_EntradaMañana;
                    this.J_SalidaMañana = current.J_SalidaMañana;
                    this.J_EntradaTarde = current.J_EntradaTarde;
                    this.J_SalidaTarde = current.J_SalidaTarde;
                    this.J_ToleranciaEntrada = current.J_ToleranciaEntrada;
                    this.J_ToleranciaSalida = current.J_ToleranciaSalida;
                    this.Viernes = current.Viernes;
                    this.V_EntradaMañana = current.V_EntradaMañana;
                    this.V_SalidaMañana = current.V_SalidaMañana;
                    this.V_EntradaTarde = current.V_EntradaTarde;
                    this.V_SalidaTarde = current.V_SalidaTarde;
                    this.V_ToleranciaEntrada = current.V_ToleranciaEntrada;
                    this.V_ToleranciaSalida = current.V_ToleranciaSalida;
                    this.Sabado = current.Sabado;
                    this.S_EntradaMañana = current.S_EntradaMañana;
                    this.S_SalidaMañana = current.S_SalidaMañana;
                    this.S_EntradaTarde = current.S_EntradaTarde;
                    this.S_SalidaTarde = current.S_SalidaTarde;
                    this.S_ToleranciaEntrada = current.S_ToleranciaEntrada;
                    this.S_ToleranciaSalida = current.S_ToleranciaSalida;
                    this.Domingo = current.Domingo;
                    this.D_EntradaMañana = current.D_EntradaMañana;
                    this.D_SalidaMañana = current.D_SalidaMañana;
                    this.D_EntradaTarde = current.D_EntradaTarde;
                    this.D_SalidaTarde = current.D_SalidaTarde;
                    this.D_ToleranciaEntrada = current.D_ToleranciaEntrada;
                    this.D_ToleranciaSalida = current.D_ToleranciaSalida;
                    this.TotalHorasSemanales = current.TotalHorasSemanales;
                    this.Desde = current.Desde;
                    this.Hasta = current.Hasta;
                    #endregion

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



        public Horario Get(System.Int32 IdHorario)
        {
            var oLst = new List<Horario>();
            DB.Conectar();
            try
            {
                DB.CrearComando("HorarioSelProc @IdHorario");
                DB.AsignarParametroEntero("@IdHorario", IdHorario);

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
                    current = RowData(reader);

                    #region Asignacion de propiedades
                    this.IdHorario = current.IdHorario;
                    this.Descripcion = current.Descripcion;
                    this.Desde = current.Desde;
                    this.Hasta = current.Hasta;

                    this.Lunes = current.Lunes;
                    this.L_EntradaMañana = current.L_EntradaMañana;
                    this.L_SalidaMañana = current.L_SalidaMañana;
                    this.L_EntradaTarde = current.L_EntradaTarde;
                    this.L_SalidaTarde = current.L_SalidaTarde;
                    this.L_ToleranciaEntrada = current.L_ToleranciaEntrada;
                    this.L_ToleranciaSalida = current.L_ToleranciaSalida;

                    this.Martes = current.Martes;
                    this.M_EntradaMañana = current.M_EntradaMañana;
                    this.M_SalidaMañana = current.M_SalidaMañana;
                    this.M_EntradaTarde = current.M_EntradaTarde;
                    this.M_SalidaTarde = current.M_SalidaTarde;
                    this.M_ToleranciaEntrada = current.M_ToleranciaEntrada;
                    this.M_ToleranciaSalida = current.M_ToleranciaSalida;

                    this.Miercoles = current.Miercoles;
                    this.X_EntradaMañana = current.X_EntradaMañana;
                    this.X_SalidaMañana = current.X_SalidaMañana;
                    this.X_EntradaTarde = current.X_EntradaTarde;
                    this.X_SalidaTarde = current.X_SalidaTarde;
                    this.X_ToleranciaEntrada = current.X_ToleranciaEntrada;
                    this.X_ToleranciaSalida = current.X_ToleranciaSalida;

                    this.Jueves = current.Jueves;
                    this.J_EntradaMañana = current.J_EntradaMañana;
                    this.J_SalidaMañana = current.J_SalidaMañana;
                    this.J_EntradaTarde = current.J_EntradaTarde;
                    this.J_SalidaTarde = current.J_SalidaTarde;
                    this.J_ToleranciaEntrada = current.J_ToleranciaEntrada;
                    this.J_ToleranciaSalida = current.J_ToleranciaSalida;

                    this.Viernes = current.Viernes;
                    this.V_EntradaMañana = current.V_EntradaMañana;
                    this.V_SalidaMañana = current.V_SalidaMañana;
                    this.V_EntradaTarde = current.V_EntradaTarde;
                    this.V_SalidaTarde = current.V_SalidaTarde;
                    this.V_ToleranciaEntrada = current.V_ToleranciaEntrada;
                    this.V_ToleranciaSalida = current.V_ToleranciaSalida;

                    this.Sabado = current.Sabado;
                    this.S_EntradaMañana = current.S_EntradaMañana;
                    this.S_SalidaMañana = current.S_SalidaMañana;
                    this.S_EntradaTarde = current.S_EntradaTarde;
                    this.S_SalidaTarde = current.S_SalidaTarde;
                    this.S_ToleranciaEntrada = current.S_ToleranciaEntrada;
                    this.S_ToleranciaSalida = current.S_ToleranciaSalida;

                    this.Domingo = current.Domingo;
                    this.D_EntradaMañana = current.D_EntradaMañana;
                    this.D_SalidaMañana = current.D_SalidaMañana;
                    this.D_EntradaTarde = current.D_EntradaTarde;
                    this.D_SalidaTarde  = current.D_SalidaTarde;
                    this.D_ToleranciaEntrada = current.D_ToleranciaEntrada;
                    this.D_ToleranciaSalida  = current.D_ToleranciaSalida;
                    this.TotalHorasSemanales = current.TotalHorasSemanales;

                    #endregion

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

        public Boolean Delete(System.Int32 IdHorario)
        {
            Boolean lRet = false;

            if (this.Exists(IdHorario))
            {
                try
                {
                    DB.Conectar();
                    DB.CrearComando("HorarioDelProc @IdHorario");
                    DB.AsignarParametroEntero("@IdHorario", IdHorario);

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
                DB.CrearComando("HorarioUpdProc @IdHorario, @Descripcion, @TotalHorasSemanales, @Desde, @Hasta, @Lunes, @L_EntradaMañana, @L_SalidaMañana, @L_EntradaTarde, @L_SalidaTarde, @L_ToleranciaEntrada, @L_ToleranciaSalida, @Martes, @M_EntradaMañana, @M_SalidaMañana, @M_EntradaTarde, @M_SalidaTarde, @M_ToleranciaEntrada, @M_ToleranciaSalida, @Miercoles, @X_EntradaMañana, @X_SalidaMañana, @X_EntradaTarde, @X_SalidaTarde, @X_ToleranciaEntrada, @X_ToleranciaSalida, @Jueves, @J_EntradaMañana, @J_SalidaMañana, @J_EntradaTarde, @J_SalidaTarde, @J_ToleranciaEntrada, @J_ToleranciaSalida, @Viernes, @V_EntradaMañana, @V_SalidaMañana, @V_EntradaTarde, @V_SalidaTarde, @V_ToleranciaEntrada, @V_ToleranciaSalida, @Sabado, @S_EntradaMañana, @S_SalidaMañana, @S_EntradaTarde, @S_SalidaTarde, @S_ToleranciaEntrada, @S_ToleranciaSalida, @Domingo, @D_EntradaMañana, @D_SalidaMañana, @D_EntradaTarde, @D_SalidaTarde, @D_ToleranciaEntrada, @D_ToleranciaSalida");

                DB.AsignarParametroEntero("@IdHorario", current.IdHorario);
                DB.AsignarParametroCadena("@Descripcion", current.Descripcion);
                DB.AsignarParametroEntero("@TotalHorasSemanales", current.TotalHorasSemanales);
                DB.AsignarParametroCadena("@Desde", current.Desde.ToString("yyyyMMdd"));
                DB.AsignarParametroCadena("@Hasta", current.Hasta.ToString("yyyyMMdd"));

                DB.AsignarParametroCadena("@Lunes", current.Lunes);
                DB.AsignarParametroCadena("@L_EntradaMañana", current.L_EntradaMañana);
                DB.AsignarParametroCadena("@L_SalidaMañana", current.L_SalidaMañana);
                DB.AsignarParametroCadena("@L_EntradaTarde", current.L_EntradaTarde);
                DB.AsignarParametroCadena("@L_SalidaTarde", current.L_SalidaTarde);
                DB.AsignarParametroEntero("@L_ToleranciaEntrada", current.L_ToleranciaEntrada);
                DB.AsignarParametroEntero("@L_ToleranciaSalida", current.L_ToleranciaSalida);

                DB.AsignarParametroCadena("@Martes", current.Martes);
                DB.AsignarParametroCadena("@M_EntradaMañana", current.M_EntradaMañana);
                DB.AsignarParametroCadena("@M_SalidaMañana", current.M_SalidaMañana);
                DB.AsignarParametroCadena("@M_EntradaTarde", current.M_EntradaTarde);
                DB.AsignarParametroCadena("@M_SalidaTarde", current.M_SalidaTarde);
                DB.AsignarParametroEntero("@M_ToleranciaEntrada", current.M_ToleranciaEntrada);
                DB.AsignarParametroEntero("@M_ToleranciaSalida", current.M_ToleranciaSalida);

                DB.AsignarParametroCadena("@Miercoles", Miercoles);
                DB.AsignarParametroCadena("@X_EntradaMañana", current.X_EntradaMañana);
                DB.AsignarParametroCadena("@X_SalidaMañana", current.X_SalidaMañana);
                DB.AsignarParametroCadena("@X_EntradaTarde", current.X_EntradaTarde);
                DB.AsignarParametroCadena("@X_SalidaTarde", current.X_SalidaTarde);
                DB.AsignarParametroEntero("@X_ToleranciaEntrada", current.X_ToleranciaEntrada);
                DB.AsignarParametroEntero("@X_ToleranciaSalida", current.X_ToleranciaSalida);

                DB.AsignarParametroCadena("@Jueves", current.Jueves);
                DB.AsignarParametroCadena("@J_EntradaMañana", current.J_EntradaMañana);
                DB.AsignarParametroCadena("@J_SalidaMañana", current.J_SalidaMañana);
                DB.AsignarParametroCadena("@J_EntradaTarde", current.J_EntradaTarde);
                DB.AsignarParametroCadena("@J_SalidaTarde", current.J_SalidaTarde);
                DB.AsignarParametroEntero("@J_ToleranciaEntrada", current.J_ToleranciaEntrada);
                DB.AsignarParametroEntero("@J_ToleranciaSalida", current.J_ToleranciaSalida);

                DB.AsignarParametroCadena("@Viernes", current.Viernes);
                DB.AsignarParametroCadena("@V_EntradaMañana", current.V_EntradaMañana);
                DB.AsignarParametroCadena("@V_SalidaMañana", current.V_SalidaMañana);
                DB.AsignarParametroCadena("@V_EntradaTarde", current.V_EntradaTarde);
                DB.AsignarParametroCadena("@V_SalidaTarde", current.V_SalidaTarde);
                DB.AsignarParametroEntero("@V_ToleranciaEntrada", current.V_ToleranciaEntrada);
                DB.AsignarParametroEntero("@V_ToleranciaSalida", current.V_ToleranciaSalida);

                DB.AsignarParametroCadena("@Sabado", current.Sabado);
                DB.AsignarParametroCadena("@S_EntradaMañana", current.S_EntradaMañana);
                DB.AsignarParametroCadena("@S_SalidaMañana", current.S_SalidaMañana);
                DB.AsignarParametroCadena("@S_EntradaTarde", current.S_EntradaTarde);
                DB.AsignarParametroCadena("@S_SalidaTarde", current.S_SalidaTarde);
                DB.AsignarParametroEntero("@S_ToleranciaEntrada", current.S_ToleranciaEntrada);
                DB.AsignarParametroEntero("@S_ToleranciaSalida", current.S_ToleranciaSalida);

                DB.AsignarParametroCadena("@Domingo", current.Domingo);
                DB.AsignarParametroCadena("@D_EntradaMañana", current.D_EntradaMañana);
                DB.AsignarParametroCadena("@D_SalidaMañana", current.D_SalidaMañana);
                DB.AsignarParametroCadena("@D_EntradaTarde", current.D_EntradaTarde);
                DB.AsignarParametroCadena("@D_SalidaTarde", current.D_SalidaTarde);
                DB.AsignarParametroEntero("@D_ToleranciaEntrada", current.D_ToleranciaEntrada);
                DB.AsignarParametroEntero("@D_ToleranciaSalida", current.D_ToleranciaSalida);

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
        private Boolean Exists(System.Int32 IdHorario)
        {
            Boolean lRet = false;
            try
            {
                //if (IdHorario <= 0) throw new ReglasNegocioException("El id del contrato no es valido.");
                DB.Conectar();
                DB.CrearComando("HorarioSelProc @IdHorario");
                DB.AsignarParametroEntero("@IdHorario", IdHorario);

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

        private Horario RowData(DataTableReader reader)
        {
            var horario = new Horario()
            {
                IdHorario = reader.IsDBNull(reader.GetOrdinal("IdHorario")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdHorario")),
                Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "" : reader.GetString(reader.GetOrdinal("Descripcion")),

                Lunes = reader.IsDBNull(reader.GetOrdinal("Lunes")) ? "" : reader.GetString(reader.GetOrdinal("Lunes")),
                L_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("L_EntradaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("L_EntradaMañana"))).ToString("HH:mm"),
                L_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("L_SalidaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("L_SalidaMañana"))).ToString("HH:mm"),
                L_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("L_EntradaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("L_EntradaTarde"))).ToString("HH:mm"),
                L_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("L_SalidaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("L_SalidaTarde"))).ToString("HH:mm"),
                L_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("L_ToleranciaEntrada")) ? 0 : reader.GetInt32(reader.GetOrdinal("L_ToleranciaEntrada")),
                L_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("L_ToleranciaSalida")) ? 0 : reader.GetInt32(reader.GetOrdinal("L_ToleranciaSalida")),

                Martes = reader.IsDBNull(reader.GetOrdinal("Martes")) ? "" : reader.GetString(reader.GetOrdinal("Martes")),
                M_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("M_EntradaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("M_EntradaMañana"))).ToString("HH:mm"),
                M_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("M_SalidaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("M_SalidaMañana"))).ToString("HH:mm"),
                M_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("M_EntradaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("M_EntradaTarde"))).ToString("HH:mm"),
                M_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("M_SalidaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("M_SalidaTarde"))).ToString("HH:mm"),
                M_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("M_ToleranciaEntrada")) ? 0 : reader.GetInt32(reader.GetOrdinal("M_ToleranciaEntrada")),
                M_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("M_ToleranciaSalida")) ? 0 : reader.GetInt32(reader.GetOrdinal("M_ToleranciaSalida")),

                Miercoles = reader.IsDBNull(reader.GetOrdinal("Miercoles")) ? "" : reader.GetString(reader.GetOrdinal("Miercoles")),
                X_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("X_EntradaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("X_EntradaMañana"))).ToString("HH:mm"),
                X_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("X_SalidaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("X_SalidaMañana"))).ToString("HH:mm"),
                X_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("X_EntradaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("X_EntradaTarde"))).ToString("HH:mm"),
                X_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("X_SalidaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("X_SalidaTarde"))).ToString("HH:mm"),
                X_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("X_ToleranciaEntrada")) ? 0 : reader.GetInt32(reader.GetOrdinal("X_ToleranciaEntrada")),
                X_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("X_ToleranciaSalida")) ? 0 : reader.GetInt32(reader.GetOrdinal("X_ToleranciaSalida")),

                Jueves = reader.IsDBNull(reader.GetOrdinal("Jueves")) ? "" : reader.GetString(reader.GetOrdinal("Jueves")),
                J_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("J_EntradaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("J_EntradaMañana"))).ToString("HH:mm"),
                J_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("J_SalidaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("J_SalidaMañana"))).ToString("HH:mm"),
                J_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("J_EntradaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("J_EntradaTarde"))).ToString("HH:mm"),
                J_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("J_SalidaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("J_SalidaTarde"))).ToString("HH:mm"),
                J_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("J_ToleranciaEntrada")) ? 0 : reader.GetInt32(reader.GetOrdinal("J_ToleranciaEntrada")),
                J_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("J_ToleranciaSalida")) ? 0 : reader.GetInt32(reader.GetOrdinal("J_ToleranciaSalida")),

                Viernes = reader.IsDBNull(reader.GetOrdinal("Viernes")) ? "" : reader.GetString(reader.GetOrdinal("Viernes")),
                V_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("V_EntradaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("V_EntradaMañana"))).ToString("HH:mm"),
                V_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("V_SalidaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("V_SalidaMañana"))).ToString("HH:mm"),
                V_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("V_EntradaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("V_EntradaTarde"))).ToString("HH:mm"),
                V_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("V_SalidaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("V_SalidaTarde"))).ToString("HH:mm"),
                V_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("V_ToleranciaEntrada")) ? 0 : reader.GetInt32(reader.GetOrdinal("V_ToleranciaEntrada")),
                V_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("V_ToleranciaSalida")) ? 0 : reader.GetInt32(reader.GetOrdinal("V_ToleranciaSalida")),

                Sabado = reader.IsDBNull(reader.GetOrdinal("Sabado")) ? "" : reader.GetString(reader.GetOrdinal("Sabado")),
                S_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("S_EntradaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("S_EntradaMañana"))).ToString("HH:mm"),
                S_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("S_SalidaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("S_SalidaMañana"))).ToString("HH:mm"),
                S_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("S_EntradaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("S_EntradaTarde"))).ToString("HH:mm"),
                S_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("S_SalidaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("S_SalidaTarde"))).ToString("HH:mm"),
                S_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("S_ToleranciaEntrada")) ? 0 : reader.GetInt32(reader.GetOrdinal("S_ToleranciaEntrada")),
                S_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("S_ToleranciaSalida")) ? 0 : reader.GetInt32(reader.GetOrdinal("S_ToleranciaSalida")),

                Domingo = reader.IsDBNull(reader.GetOrdinal("Domingo")) ? "" : reader.GetString(reader.GetOrdinal("Domingo")),
                D_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("D_EntradaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("D_EntradaMañana"))).ToString("HH:mm"),
                D_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("D_SalidaMañana")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("D_SalidaMañana"))).ToString("HH:mm"),
                D_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("D_EntradaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("D_EntradaTarde"))).ToString("HH:mm"),
                D_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("D_SalidaTarde")) ? null : ((DateTime)reader.GetValue(reader.GetOrdinal("D_SalidaTarde"))).ToString("HH:mm"),
                D_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("D_ToleranciaEntrada")) ? 0 : reader.GetInt32(reader.GetOrdinal("D_ToleranciaEntrada")),
                D_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("D_ToleranciaSalida")) ? 0 : reader.GetInt32(reader.GetOrdinal("D_ToleranciaSalida")),

                TotalHorasSemanales = reader.IsDBNull(reader.GetOrdinal("TotalHorasSemanales")) ? 0 : reader.GetInt32(reader.GetOrdinal("TotalHorasSemanales")),
                Desde = reader.IsDBNull(reader.GetOrdinal("Desde")) ? default : (DateTime)reader.GetValue(reader.GetOrdinal("Desde")),
                Hasta = reader.IsDBNull(reader.GetOrdinal("Hasta")) ? default : (DateTime)reader.GetValue(reader.GetOrdinal("Hasta")),
            };
            return horario;
        }

        #endregion

    }
}
