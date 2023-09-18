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
    public partial class ServiceHorario: Horario
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
		 
		 public ServiceHorario()
		 {
			 //this.usuario = Credenciales.Usuario;
			 //this.host = Credenciales.Host;
		 }
		 public void Clear()
		 {
			 this.IdHorario = 0;
			 this.Descripcion = "";
			 this.Lunes = "";
			 this.L_EntradaMañana = Convert.ToDateTime("01/01/2000");
			 this.L_SalidaMañana = Convert.ToDateTime("01/01/2000");
			 this.L_EntradaTarde = Convert.ToDateTime("01/01/2000");
			 this.L_SalidaTarde = Convert.ToDateTime("01/01/2000");
			 this.L_ToleranciaEntrada = 0;
			 this.L_ToleranciaSalida = 0;
			 this.Martes = "";
			 this.M_EntradaMañana = Convert.ToDateTime("01/01/2000");
			 this.M_SalidaMañana = Convert.ToDateTime("01/01/2000");
			 this.M_EntradaTarde = Convert.ToDateTime("01/01/2000");
			 this.M_SalidaTarde = Convert.ToDateTime("01/01/2000");
			 this.M_ToleranciaEntrada = 0;
			 this.M_ToleranciaSalida = 0;
			 this.Miercoles = "";
			 this.X_EntradaMañana = Convert.ToDateTime("01/01/2000");
			 this.X_SalidaMañana = Convert.ToDateTime("01/01/2000");
			 this.X_EntradaTarde = Convert.ToDateTime("01/01/2000");
			 this.X_SalidaTarde = Convert.ToDateTime("01/01/2000");
			 this.X_ToleranciaEntrada = 0;
			 this.X_ToleranciaSalida = 0;
			 this.Jueves = "";
			 this.J_EntradaMañana = Convert.ToDateTime("01/01/2000");
			 this.J_SalidaMañana = Convert.ToDateTime("01/01/2000");
			 this.J_EntradaTarde = Convert.ToDateTime("01/01/2000");
			 this.J_SalidaTarde = Convert.ToDateTime("01/01/2000");
			 this.J_ToleranciaEntrada = 0;
			 this.J_ToleranciaSalida = 0;
			 this.Viernes = "";
			 this.V_EntradaMañana = Convert.ToDateTime("01/01/2000");
			 this.V_SalidaMañana = Convert.ToDateTime("01/01/2000");
			 this.V_EntradaTarde = Convert.ToDateTime("01/01/2000");
			 this.V_SalidaTarde = Convert.ToDateTime("01/01/2000");
			 this.V_ToleranciaEntrada = 0;
			 this.V_ToleranciaSalida = 0;
			 this.Sabado = "";
			 this.S_EntradaMañana = Convert.ToDateTime("01/01/2000");
			 this.S_SalidaMañana = Convert.ToDateTime("01/01/2000");
			 this.S_EntradaTarde = Convert.ToDateTime("01/01/2000");
			 this.S_SalidaTarde = Convert.ToDateTime("01/01/2000");
			 this.S_ToleranciaEntrada = 0;
			 this.S_ToleranciaSalida = 0;
			 this.Domingo = "";
			 this.D_EntradaMañana = Convert.ToDateTime("01/01/2000");
			 this.D_SalidaMañana = Convert.ToDateTime("01/01/2000");
			 this.D_EntradaTarde = Convert.ToDateTime("01/01/2000");
			 this.D_SalidaTarde = Convert.ToDateTime("01/01/2000");
			 this.D_ToleranciaEntrada = 0;
			 this.D_ToleranciaSalida = 0;
			 this.TotalHorasSemanales = 0;
			 this.Desde = Convert.ToDateTime("01/01/2000");
			 this.Hasta = Convert.ToDateTime("01/01/2000");
		 }

		 public List<Horario> Get(System.Int32 IdHorario)
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
				 while (reader.Read())
				 {
					 try
					 {
						 Horario e = new Horario()
						 {
							 IdHorario = reader.IsDBNull(reader.GetOrdinal("IdHorario")) ? 0: reader.GetInt32(reader.GetOrdinal("IdHorario")),
							 Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "": reader.GetString(reader.GetOrdinal("Descripcion")),
							 Lunes = reader.IsDBNull(reader.GetOrdinal("Lunes")) ? "": reader.GetString(reader.GetOrdinal("Lunes")),
							 L_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("L_EntradaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("L_EntradaMañana")),
							 L_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("L_SalidaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("L_SalidaMañana")),
							 L_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("L_EntradaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("L_EntradaTarde")),
							 L_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("L_SalidaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("L_SalidaTarde")),
							 L_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("L_ToleranciaEntrada")) ? 0: reader.GetInt32(reader.GetOrdinal("L_ToleranciaEntrada")),
							 L_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("L_ToleranciaSalida")) ? 0: reader.GetInt32(reader.GetOrdinal("L_ToleranciaSalida")),
							 Martes = reader.IsDBNull(reader.GetOrdinal("Martes")) ? "": reader.GetString(reader.GetOrdinal("Martes")),
							 M_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("M_EntradaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("M_EntradaMañana")),
							 M_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("M_SalidaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("M_SalidaMañana")),
							 M_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("M_EntradaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("M_EntradaTarde")),
							 M_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("M_SalidaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("M_SalidaTarde")),
							 M_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("M_ToleranciaEntrada")) ? 0: reader.GetInt32(reader.GetOrdinal("M_ToleranciaEntrada")),
							 M_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("M_ToleranciaSalida")) ? 0: reader.GetInt32(reader.GetOrdinal("M_ToleranciaSalida")),
							 Miercoles = reader.IsDBNull(reader.GetOrdinal("Miercoles")) ? "": reader.GetString(reader.GetOrdinal("Miercoles")),
							 X_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("X_EntradaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("X_EntradaMañana")),
							 X_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("X_SalidaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("X_SalidaMañana")),
							 X_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("X_EntradaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("X_EntradaTarde")),
							 X_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("X_SalidaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("X_SalidaTarde")),
							 X_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("X_ToleranciaEntrada")) ? 0: reader.GetInt32(reader.GetOrdinal("X_ToleranciaEntrada")),
							 X_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("X_ToleranciaSalida")) ? 0: reader.GetInt32(reader.GetOrdinal("X_ToleranciaSalida")),
							 Jueves = reader.IsDBNull(reader.GetOrdinal("Jueves")) ? "": reader.GetString(reader.GetOrdinal("Jueves")),
							 J_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("J_EntradaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("J_EntradaMañana")),
							 J_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("J_SalidaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("J_SalidaMañana")),
							 J_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("J_EntradaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("J_EntradaTarde")),
							 J_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("J_SalidaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("J_SalidaTarde")),
							 J_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("J_ToleranciaEntrada")) ? 0: reader.GetInt32(reader.GetOrdinal("J_ToleranciaEntrada")),
							 J_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("J_ToleranciaSalida")) ? 0: reader.GetInt32(reader.GetOrdinal("J_ToleranciaSalida")),
							 Viernes = reader.IsDBNull(reader.GetOrdinal("Viernes")) ? "": reader.GetString(reader.GetOrdinal("Viernes")),
							 V_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("V_EntradaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("V_EntradaMañana")),
							 V_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("V_SalidaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("V_SalidaMañana")),
							 V_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("V_EntradaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("V_EntradaTarde")),
							 V_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("V_SalidaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("V_SalidaTarde")),
							 V_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("V_ToleranciaEntrada")) ? 0: reader.GetInt32(reader.GetOrdinal("V_ToleranciaEntrada")),
							 V_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("V_ToleranciaSalida")) ? 0: reader.GetInt32(reader.GetOrdinal("V_ToleranciaSalida")),
							 Sabado = reader.IsDBNull(reader.GetOrdinal("Sabado")) ? "": reader.GetString(reader.GetOrdinal("Sabado")),
							 S_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("S_EntradaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("S_EntradaMañana")),
							 S_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("S_SalidaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("S_SalidaMañana")),
							 S_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("S_EntradaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("S_EntradaTarde")),
							 S_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("S_SalidaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("S_SalidaTarde")),
							 S_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("S_ToleranciaEntrada")) ? 0: reader.GetInt32(reader.GetOrdinal("S_ToleranciaEntrada")),
							 S_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("S_ToleranciaSalida")) ? 0: reader.GetInt32(reader.GetOrdinal("S_ToleranciaSalida")),
							 Domingo = reader.IsDBNull(reader.GetOrdinal("Domingo")) ? "": reader.GetString(reader.GetOrdinal("Domingo")),
							 D_EntradaMañana = reader.IsDBNull(reader.GetOrdinal("D_EntradaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("D_EntradaMañana")),
							 D_SalidaMañana = reader.IsDBNull(reader.GetOrdinal("D_SalidaMañana")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("D_SalidaMañana")),
							 D_EntradaTarde = reader.IsDBNull(reader.GetOrdinal("D_EntradaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("D_EntradaTarde")),
							 D_SalidaTarde = reader.IsDBNull(reader.GetOrdinal("D_SalidaTarde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("D_SalidaTarde")),
							 D_ToleranciaEntrada = reader.IsDBNull(reader.GetOrdinal("D_ToleranciaEntrada")) ? 0: reader.GetInt32(reader.GetOrdinal("D_ToleranciaEntrada")),
							 D_ToleranciaSalida = reader.IsDBNull(reader.GetOrdinal("D_ToleranciaSalida")) ? 0: reader.GetInt32(reader.GetOrdinal("D_ToleranciaSalida")),
							 TotalHorasSemanales = reader.IsDBNull(reader.GetOrdinal("TotalHorasSemanales")) ? 0: reader.GetInt32(reader.GetOrdinal("TotalHorasSemanales")),
							 Desde = reader.IsDBNull(reader.GetOrdinal("Desde")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("Desde")),
							 Hasta = reader.IsDBNull(reader.GetOrdinal("Hasta")) ? Convert.ToDateTime("01/01/2000"): reader.GetDateTime(reader.GetOrdinal("Hasta")),
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
					 this.IdHorario = oLst[0].IdHorario;
					 this.Descripcion = oLst[0].Descripcion;
					 this.Lunes = oLst[0].Lunes;
					 this.L_EntradaMañana = oLst[0].L_EntradaMañana;
					 this.L_SalidaMañana = oLst[0].L_SalidaMañana;
					 this.L_EntradaTarde = oLst[0].L_EntradaTarde;
					 this.L_SalidaTarde = oLst[0].L_SalidaTarde;
					 this.L_ToleranciaEntrada = oLst[0].L_ToleranciaEntrada;
					 this.L_ToleranciaSalida = oLst[0].L_ToleranciaSalida;
					 this.Martes = oLst[0].Martes;
					 this.M_EntradaMañana = oLst[0].M_EntradaMañana;
					 this.M_SalidaMañana = oLst[0].M_SalidaMañana;
					 this.M_EntradaTarde = oLst[0].M_EntradaTarde;
					 this.M_SalidaTarde = oLst[0].M_SalidaTarde;
					 this.M_ToleranciaEntrada = oLst[0].M_ToleranciaEntrada;
					 this.M_ToleranciaSalida = oLst[0].M_ToleranciaSalida;
					 this.Miercoles = oLst[0].Miercoles;
					 this.X_EntradaMañana = oLst[0].X_EntradaMañana;
					 this.X_SalidaMañana = oLst[0].X_SalidaMañana;
					 this.X_EntradaTarde = oLst[0].X_EntradaTarde;
					 this.X_SalidaTarde = oLst[0].X_SalidaTarde;
					 this.X_ToleranciaEntrada = oLst[0].X_ToleranciaEntrada;
					 this.X_ToleranciaSalida = oLst[0].X_ToleranciaSalida;
					 this.Jueves = oLst[0].Jueves;
					 this.J_EntradaMañana = oLst[0].J_EntradaMañana;
					 this.J_SalidaMañana = oLst[0].J_SalidaMañana;
					 this.J_EntradaTarde = oLst[0].J_EntradaTarde;
					 this.J_SalidaTarde = oLst[0].J_SalidaTarde;
					 this.J_ToleranciaEntrada = oLst[0].J_ToleranciaEntrada;
					 this.J_ToleranciaSalida = oLst[0].J_ToleranciaSalida;
					 this.Viernes = oLst[0].Viernes;
					 this.V_EntradaMañana = oLst[0].V_EntradaMañana;
					 this.V_SalidaMañana = oLst[0].V_SalidaMañana;
					 this.V_EntradaTarde = oLst[0].V_EntradaTarde;
					 this.V_SalidaTarde = oLst[0].V_SalidaTarde;
					 this.V_ToleranciaEntrada = oLst[0].V_ToleranciaEntrada;
					 this.V_ToleranciaSalida = oLst[0].V_ToleranciaSalida;
					 this.Sabado = oLst[0].Sabado;
					 this.S_EntradaMañana = oLst[0].S_EntradaMañana;
					 this.S_SalidaMañana = oLst[0].S_SalidaMañana;
					 this.S_EntradaTarde = oLst[0].S_EntradaTarde;
					 this.S_SalidaTarde = oLst[0].S_SalidaTarde;
					 this.S_ToleranciaEntrada = oLst[0].S_ToleranciaEntrada;
					 this.S_ToleranciaSalida = oLst[0].S_ToleranciaSalida;
					 this.Domingo = oLst[0].Domingo;
					 this.D_EntradaMañana = oLst[0].D_EntradaMañana;
					 this.D_SalidaMañana = oLst[0].D_SalidaMañana;
					 this.D_EntradaTarde = oLst[0].D_EntradaTarde;
					 this.D_SalidaTarde = oLst[0].D_SalidaTarde;
					 this.D_ToleranciaEntrada = oLst[0].D_ToleranciaEntrada;
					 this.D_ToleranciaSalida = oLst[0].D_ToleranciaSalida;
					 this.TotalHorasSemanales = oLst[0].TotalHorasSemanales;
					 this.Desde = oLst[0].Desde;
					 this.Hasta = oLst[0].Hasta;
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
				 DB.CrearComando("HorarioUpdProc @IdHorario, @Descripcion, @Lunes, @L_EntradaMañana, @L_SalidaMañana, @L_EntradaTarde, @L_SalidaTarde, @L_ToleranciaEntrada, @L_ToleranciaSalida, @Martes, @M_EntradaMañana, @M_SalidaMañana, @M_EntradaTarde, @M_SalidaTarde, @M_ToleranciaEntrada, @M_ToleranciaSalida, @Miercoles, @X_EntradaMañana, @X_SalidaMañana, @X_EntradaTarde, @X_SalidaTarde, @X_ToleranciaEntrada, @X_ToleranciaSalida, @Jueves, @J_EntradaMañana, @J_SalidaMañana, @J_EntradaTarde, @J_SalidaTarde, @J_ToleranciaEntrada, @J_ToleranciaSalida, @Viernes, @V_EntradaMañana, @V_SalidaMañana, @V_EntradaTarde, @V_SalidaTarde, @V_ToleranciaEntrada, @V_ToleranciaSalida, @Sabado, @S_EntradaMañana, @S_SalidaMañana, @S_EntradaTarde, @S_SalidaTarde, @S_ToleranciaEntrada, @S_ToleranciaSalida, @Domingo, @D_EntradaMañana, @D_SalidaMañana, @D_EntradaTarde, @D_SalidaTarde, @D_ToleranciaEntrada, @D_ToleranciaSalida, @TotalHorasSemanales, @Desde, @Hasta");

				 DB.AsignarParametroEntero("@IdHorario", IdHorario);
				 DB.AsignarParametroCadena("@Descripcion", Descripcion);
				 DB.AsignarParametroCadena("@Lunes", Lunes);
				 DB.AsignarParametroFecha("@L_EntradaMañana", L_EntradaMañana);
				 DB.AsignarParametroFecha("@L_SalidaMañana", L_SalidaMañana);
				 DB.AsignarParametroFecha("@L_EntradaTarde", L_EntradaTarde);
				 DB.AsignarParametroFecha("@L_SalidaTarde", L_SalidaTarde);
				 DB.AsignarParametroEntero("@L_ToleranciaEntrada", L_ToleranciaEntrada);
				 DB.AsignarParametroEntero("@L_ToleranciaSalida", L_ToleranciaSalida);
				 DB.AsignarParametroCadena("@Martes", Martes);
				 DB.AsignarParametroFecha("@M_EntradaMañana", M_EntradaMañana);
				 DB.AsignarParametroFecha("@M_SalidaMañana", M_SalidaMañana);
				 DB.AsignarParametroFecha("@M_EntradaTarde", M_EntradaTarde);
				 DB.AsignarParametroFecha("@M_SalidaTarde", M_SalidaTarde);
				 DB.AsignarParametroEntero("@M_ToleranciaEntrada", M_ToleranciaEntrada);
				 DB.AsignarParametroEntero("@M_ToleranciaSalida", M_ToleranciaSalida);
				 DB.AsignarParametroCadena("@Miercoles", Miercoles);
				 DB.AsignarParametroFecha("@X_EntradaMañana", X_EntradaMañana);
				 DB.AsignarParametroFecha("@X_SalidaMañana", X_SalidaMañana);
				 DB.AsignarParametroFecha("@X_EntradaTarde", X_EntradaTarde);
				 DB.AsignarParametroFecha("@X_SalidaTarde", X_SalidaTarde);
				 DB.AsignarParametroEntero("@X_ToleranciaEntrada", X_ToleranciaEntrada);
				 DB.AsignarParametroEntero("@X_ToleranciaSalida", X_ToleranciaSalida);
				 DB.AsignarParametroCadena("@Jueves", Jueves);
				 DB.AsignarParametroFecha("@J_EntradaMañana", J_EntradaMañana);
				 DB.AsignarParametroFecha("@J_SalidaMañana", J_SalidaMañana);
				 DB.AsignarParametroFecha("@J_EntradaTarde", J_EntradaTarde);
				 DB.AsignarParametroFecha("@J_SalidaTarde", J_SalidaTarde);
				 DB.AsignarParametroEntero("@J_ToleranciaEntrada", J_ToleranciaEntrada);
				 DB.AsignarParametroEntero("@J_ToleranciaSalida", J_ToleranciaSalida);
				 DB.AsignarParametroCadena("@Viernes", Viernes);
				 DB.AsignarParametroFecha("@V_EntradaMañana", V_EntradaMañana);
				 DB.AsignarParametroFecha("@V_SalidaMañana", V_SalidaMañana);
				 DB.AsignarParametroFecha("@V_EntradaTarde", V_EntradaTarde);
				 DB.AsignarParametroFecha("@V_SalidaTarde", V_SalidaTarde);
				 DB.AsignarParametroEntero("@V_ToleranciaEntrada", V_ToleranciaEntrada);
				 DB.AsignarParametroEntero("@V_ToleranciaSalida", V_ToleranciaSalida);
				 DB.AsignarParametroCadena("@Sabado", Sabado);
				 DB.AsignarParametroFecha("@S_EntradaMañana", S_EntradaMañana);
				 DB.AsignarParametroFecha("@S_SalidaMañana", S_SalidaMañana);
				 DB.AsignarParametroFecha("@S_EntradaTarde", S_EntradaTarde);
				 DB.AsignarParametroFecha("@S_SalidaTarde", S_SalidaTarde);
				 DB.AsignarParametroEntero("@S_ToleranciaEntrada", S_ToleranciaEntrada);
				 DB.AsignarParametroEntero("@S_ToleranciaSalida", S_ToleranciaSalida);
				 DB.AsignarParametroCadena("@Domingo", Domingo);
				 DB.AsignarParametroFecha("@D_EntradaMañana", D_EntradaMañana);
				 DB.AsignarParametroFecha("@D_SalidaMañana", D_SalidaMañana);
				 DB.AsignarParametroFecha("@D_EntradaTarde", D_EntradaTarde);
				 DB.AsignarParametroFecha("@D_SalidaTarde", D_SalidaTarde);
				 DB.AsignarParametroEntero("@D_ToleranciaEntrada", D_ToleranciaEntrada);
				 DB.AsignarParametroEntero("@D_ToleranciaSalida", D_ToleranciaSalida);
				 DB.AsignarParametroEntero("@TotalHorasSemanales", TotalHorasSemanales);
				 DB.AsignarParametroFecha("@Desde", Desde);
				 DB.AsignarParametroFecha("@Hasta", Hasta);

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
		 #endregion

	}
}
