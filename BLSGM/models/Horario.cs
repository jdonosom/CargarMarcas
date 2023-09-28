using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Models
{
#nullable disable
    public partial class Horario
    {
        private System.Int32 idhorario;
        public System.Int32 IdHorario
        {
            get
            {
                return idhorario;
            }
            set
            {
                idhorario = value;
            }
        }
        private System.String descripcion;
        public System.String Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
        private System.String lunes;
        public System.String Lunes
        {
            get
            {
                return lunes;
            }
            set
            {
                lunes = value;
            }
        }
        private string l_entradamañana;
        public string L_EntradaMañana
        {
            get
            {
                return l_entradamañana;
            }
            set
            {
                l_entradamañana = IsNull(value, "");
            }
        }
        private string l_salidamañana;
        public string L_SalidaMañana
        {
            get
            {
                return l_salidamañana;
            }
            set
            {
                l_salidamañana = IsNull(value, "");
            }
        }
        private string l_entradatarde;
        public string L_EntradaTarde
        {
            get
            {
                return l_entradatarde;
            }
            set
            {
                l_entradatarde = IsNull(value, "");
            }
        }
        private string l_salidatarde;
        public string L_SalidaTarde
        {
            get
            {
                return l_salidatarde;
            }
            set
            {
                l_salidatarde = IsNull(value, "");
            }
        }
        private string l_toleranciaentrada;
        public string L_ToleranciaEntrada
        {
            get
            {
                return l_toleranciaentrada;
            }
            set
            {
                l_toleranciaentrada = IsNull(value, "-1");
            }
        }
        private string l_toleranciasalida;
        public string L_ToleranciaSalida
        {
            get
            {
                return l_toleranciasalida;
            }
            set
            {
                l_toleranciasalida = IsNull(value, "-1");
            }
        }
        private System.String martes;
        public System.String Martes
        {
            get
            {
                return martes;
            }
            set
            {
                martes = value;
            }
        }
        private string m_entradamañana;
        public string M_EntradaMañana
        {
            get
            {
                return m_entradamañana;
            }
            set
            {
                m_entradamañana = IsNull(value, "");
            }
        }
        private string m_salidamañana;
        public string M_SalidaMañana
        {
            get
            {
                return m_salidamañana;
            }
            set
            {
                m_salidamañana = IsNull(value, "");
            }
        }
        private string m_entradatarde;
        public string M_EntradaTarde
        {
            get
            {
                return m_entradatarde;
            }
            set
            {
                m_entradatarde = IsNull(value, "");
            }
        }
        private string m_salidatarde;
        public string M_SalidaTarde
        {
            get
            {
                return m_salidatarde;
            }
            set
            {
                m_salidatarde = IsNull(value, "");
            }
        }
        private string m_toleranciaentrada;
        public string M_ToleranciaEntrada
        {
            get
            {
                return m_toleranciaentrada;
            }
            set
            {
                m_toleranciaentrada = IsNull(value, "-1");
            }
        }
        private string m_toleranciasalida;
        public string M_ToleranciaSalida
        {
            get
            {
                return m_toleranciasalida;
            }
            set
            {
                m_toleranciasalida = IsNull(value, "-1");
            }
        }
        private System.String miercoles;
        public System.String Miercoles
        {
            get
            {
                return miercoles;
            }
            set
            {
                miercoles = value;
            }
        }
        private string x_entradamañana;
        public string X_EntradaMañana
        {
            get
            {
                return x_entradamañana;
            }
            set
            {
                x_entradamañana = IsNull(value, "");
            }
        }
        private string x_salidamañana;
        public string X_SalidaMañana
        {
            get
            {
                return x_salidamañana;
            }
            set
            {
                x_salidamañana = IsNull(value, "");
            }
        }
        private string x_entradatarde;
        public string X_EntradaTarde
        {
            get
            {
                return x_entradatarde;
            }
            set
            {
                x_entradatarde = IsNull(value, "");
            }
        }
        private string x_salidatarde;
        public string X_SalidaTarde
        {
            get
            {
                return x_salidatarde;
            }
            set
            {
                x_salidatarde = IsNull(value, "");
            }
        }
        private string x_toleranciaentrada;
        public string X_ToleranciaEntrada
        {
            get
            {
                return x_toleranciaentrada;
            }
            set
            {
                x_toleranciaentrada = IsNull(value, "-1");
            }
        }
        private string x_toleranciasalida;
        public string X_ToleranciaSalida
        {
            get
            {
                return x_toleranciasalida;
            }
            set
            {
                x_toleranciasalida = IsNull(value, "-1");
            }
        }
        private System.String jueves;
        public System.String Jueves
        {
            get
            {
                return jueves;
            }
            set
            {
                jueves = value;
            }
        }
        private string j_entradamañana;
        public string J_EntradaMañana
        {
            get
            {
                return j_entradamañana;
            }
            set
            {
                j_entradamañana = IsNull(value, "");
            }
        }
        private string j_salidamañana;
        public string J_SalidaMañana
        {
            get
            {
                return j_salidamañana;
            }
            set
            {
                j_salidamañana = IsNull(value, "");
            }
        }
        private string j_entradatarde;
        public string J_EntradaTarde
        {
            get
            {
                return j_entradatarde;
            }
            set
            {
                j_entradatarde = IsNull(value, "");
            }
        }
        private string j_salidatarde;
        public string J_SalidaTarde
        {
            get
            {
                return j_salidatarde;
            }
            set
            {
                j_salidatarde = IsNull(value, "");
            }
        }
        private string j_toleranciaentrada;
        public string J_ToleranciaEntrada
        {
            get
            {
                return j_toleranciaentrada;
            }
            set
            {
                j_toleranciaentrada = IsNull(value, "-1");
            }
        }
        private string j_toleranciasalida;
        public string J_ToleranciaSalida
        {
            get
            {
                return j_toleranciasalida;
            }
            set
            {
                j_toleranciasalida = IsNull(value, "-1");
            }
        }
        private System.String viernes;
        public System.String Viernes
        {
            get
            {
                return viernes;
            }
            set
            {
                viernes = value;
            }
        }
        private string v_entradamañana;
        public string V_EntradaMañana
        {
            get
            {
                return v_entradamañana;
            }
            set
            {
                v_entradamañana = IsNull(value, "");
            }
        }
        private string v_salidamañana;
        public string V_SalidaMañana
        {
            get
            {
                return v_salidamañana;
            }
            set
            {
                v_salidamañana = IsNull(value, "");
            }
        }
        private string v_entradatarde;
        public string V_EntradaTarde
        {
            get
            {
                return v_entradatarde;
            }
            set
            {
                v_entradatarde = IsNull(value, "");
            }
        }
        private string v_salidatarde;
        public string V_SalidaTarde
        {
            get
            {
                return v_salidatarde;
            }
            set
            {
                v_salidatarde = IsNull(value, "");
            }
        }
        private string v_toleranciaentrada;
        public string V_ToleranciaEntrada
        {
            get
            {
                return v_toleranciaentrada;
            }
            set
            {
                v_toleranciaentrada = IsNull(value, "-1");
            }
        }
        private string v_toleranciasalida;
        public string V_ToleranciaSalida
        {
            get
            {
                return v_toleranciasalida;
            }
            set
            {
                v_toleranciasalida = IsNull(value, "-1");
            }
        }
        private System.String sabado;
        public System.String Sabado
        {
            get
            {
                return sabado;
            }
            set
            {
                sabado = value;
            }
        }
        private string s_entradamañana;
        public string S_EntradaMañana
        {
            get
            {
                return s_entradamañana;
            }
            set
            {
                s_entradamañana = IsNull(value, "");
            }
        }
        private string s_salidamañana;
        public string S_SalidaMañana
        {
            get
            {
                return s_salidamañana;
            }
            set
            {
                s_salidamañana = IsNull(value, "");
            }
        }
        private string s_entradatarde;
        public string S_EntradaTarde
        {
            get
            {
                return s_entradatarde;
            }
            set
            {
                s_entradatarde = IsNull(value, "");
            }
        }
        private string s_salidatarde;
        public string S_SalidaTarde
        {
            get
            {
                return s_salidatarde;
            }
            set
            {
                s_salidatarde = IsNull(value, "");
            }
        }
        private string s_toleranciaentrada;
        public string S_ToleranciaEntrada
        {
            get
            {
                return s_toleranciaentrada;
            }
            set
            {
                s_toleranciaentrada = IsNull(value, "-1");
            }
        }
        private string s_toleranciasalida;
        public string S_ToleranciaSalida
        {
            get
            {
                return s_toleranciasalida;
            }
            set
            {
                s_toleranciasalida = IsNull(value, "-1");
            }
        }
        private System.String domingo;
        public System.String Domingo
        {
            get
            {
                return domingo;
            }
            set
            {
                domingo = value;
            }
        }
        private string d_entradamañana;
        public string D_EntradaMañana
        {
            get
            {
                return d_entradamañana;
            }
            set
            {
                d_entradamañana = IsNull(value, "");
            }
        }
        private string d_salidamañana;
        public string D_SalidaMañana
        {
            get
            {
                return d_salidamañana;
            }
            set
            {
                d_salidamañana = IsNull(value, "");
            }
        }
        private string d_entradatarde;
        public string D_EntradaTarde
        {
            get
            {
                return d_entradatarde;
            }
            set
            {
                d_entradatarde = IsNull(value, "");
            }
        }
        private string d_salidatarde;
        public string D_SalidaTarde
        {
            get
            {
                return d_salidatarde;
            }
            set
            {
                d_salidatarde = IsNull(value, "");
            }
        }
        private string d_toleranciaentrada;
        public string D_ToleranciaEntrada
        {
            get
            {
                return d_toleranciaentrada;
            }
            set
            {
                d_toleranciaentrada = IsNull(value, "-1");
            }
        }
        private string d_toleranciasalida;
        public string D_ToleranciaSalida
        {
            get
            {
                return d_toleranciasalida;
            }
            set
            {
                d_toleranciasalida = IsNull(value, "-1");
            }
        }
        private System.Int32 totalhorassemanales;
        public System.Int32 TotalHorasSemanales
        {
            get
            {
                return totalhorassemanales;
            }
            set
            {
                totalhorassemanales = value;
            }
        }
        private System.DateTime desde;
        public System.DateTime Desde
        {
            get
            {
                return desde;
            }
            set
            {
                desde = value;
            }
        }
        private System.DateTime hasta;
        public System.DateTime Hasta
        {
            get
            {
                return hasta;
            }
            set
            {
                hasta = value;
            }
        }

        private string IsNull(string expresion, string valorDefecto)
        {
            if (string.IsNullOrWhiteSpace(expresion))
                return valorDefecto;
            else
                return expresion;
        }
    }
}
