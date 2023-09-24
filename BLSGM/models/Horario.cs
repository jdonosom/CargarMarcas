using System;
using System.Collections.Generic;
using System.Linq;
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
        private System.DateTime l_entradamañana;
        public System.DateTime L_EntradaMañana
        {
            get
            {
                return l_entradamañana;
            }
            set
            {
                l_entradamañana = value;
            }
        }
        private System.DateTime l_salidamañana;
        public System.DateTime L_SalidaMañana
        {
            get
            {
                return l_salidamañana;
            }
            set
            {
                l_salidamañana = value;
            }
        }
        private System.DateTime l_entradatarde;
        public System.DateTime L_EntradaTarde
        {
            get
            {
                return l_entradatarde;
            }
            set
            {
                l_entradatarde = value;
            }
        }
        private System.DateTime l_salidatarde;
        public System.DateTime L_SalidaTarde
        {
            get
            {
                return l_salidatarde;
            }
            set
            {
                l_salidatarde = value;
            }
        }
        private System.Int32 l_toleranciaentrada;
        public System.Int32 L_ToleranciaEntrada
        {
            get
            {
                return l_toleranciaentrada;
            }
            set
            {
                l_toleranciaentrada = value;
            }
        }
        private System.Int32 l_toleranciasalida;
        public System.Int32 L_ToleranciaSalida
        {
            get
            {
                return l_toleranciasalida;
            }
            set
            {
                l_toleranciasalida = value;
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
        private System.DateTime m_entradamañana;
        public System.DateTime M_EntradaMañana
        {
            get
            {
                return m_entradamañana;
            }
            set
            {
                m_entradamañana = value;
            }
        }
        private System.DateTime m_salidamañana;
        public System.DateTime M_SalidaMañana
        {
            get
            {
                return m_salidamañana;
            }
            set
            {
                m_salidamañana = value;
            }
        }
        private System.DateTime m_entradatarde;
        public System.DateTime M_EntradaTarde
        {
            get
            {
                return m_entradatarde;
            }
            set
            {
                m_entradatarde = value;
            }
        }
        private System.DateTime m_salidatarde;
        public System.DateTime M_SalidaTarde
        {
            get
            {
                return m_salidatarde;
            }
            set
            {
                m_salidatarde = value;
            }
        }
        private System.Int32 m_toleranciaentrada;
        public System.Int32 M_ToleranciaEntrada
        {
            get
            {
                return m_toleranciaentrada;
            }
            set
            {
                m_toleranciaentrada = value;
            }
        }
        private System.Int32 m_toleranciasalida;
        public System.Int32 M_ToleranciaSalida
        {
            get
            {
                return m_toleranciasalida;
            }
            set
            {
                m_toleranciasalida = value;
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
        private System.DateTime x_entradamañana;
        public System.DateTime X_EntradaMañana
        {
            get
            {
                return x_entradamañana;
            }
            set
            {
                x_entradamañana = value;
            }
        }
        private System.DateTime x_salidamañana;
        public System.DateTime X_SalidaMañana
        {
            get
            {
                return x_salidamañana;
            }
            set
            {
                x_salidamañana = value;
            }
        }
        private System.DateTime x_entradatarde;
        public System.DateTime X_EntradaTarde
        {
            get
            {
                return x_entradatarde;
            }
            set
            {
                x_entradatarde = value;
            }
        }
        private System.DateTime x_salidatarde;
        public System.DateTime X_SalidaTarde
        {
            get
            {
                return x_salidatarde;
            }
            set
            {
                x_salidatarde = value;
            }
        }
        private System.Int32 x_toleranciaentrada;
        public System.Int32 X_ToleranciaEntrada
        {
            get
            {
                return x_toleranciaentrada;
            }
            set
            {
                x_toleranciaentrada = value;
            }
        }
        private System.Int32 x_toleranciasalida;
        public System.Int32 X_ToleranciaSalida
        {
            get
            {
                return x_toleranciasalida;
            }
            set
            {
                x_toleranciasalida = value;
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
        private System.DateTime j_entradamañana;
        public System.DateTime J_EntradaMañana
        {
            get
            {
                return j_entradamañana;
            }
            set
            {
                j_entradamañana = value;
            }
        }
        private System.DateTime j_salidamañana;
        public System.DateTime J_SalidaMañana
        {
            get
            {
                return j_salidamañana;
            }
            set
            {
                j_salidamañana = value;
            }
        }
        private System.DateTime j_entradatarde;
        public System.DateTime J_EntradaTarde
        {
            get
            {
                return j_entradatarde;
            }
            set
            {
                j_entradatarde = value;
            }
        }
        private System.DateTime j_salidatarde;
        public System.DateTime J_SalidaTarde
        {
            get
            {
                return j_salidatarde;
            }
            set
            {
                j_salidatarde = value;
            }
        }
        private System.Int32 j_toleranciaentrada;
        public System.Int32 J_ToleranciaEntrada
        {
            get
            {
                return j_toleranciaentrada;
            }
            set
            {
                j_toleranciaentrada = value;
            }
        }
        private System.Int32 j_toleranciasalida;
        public System.Int32 J_ToleranciaSalida
        {
            get
            {
                return j_toleranciasalida;
            }
            set
            {
                j_toleranciasalida = value;
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
        private System.DateTime v_entradamañana;
        public System.DateTime V_EntradaMañana
        {
            get
            {
                return v_entradamañana;
            }
            set
            {
                v_entradamañana = value;
            }
        }
        private System.DateTime v_salidamañana;
        public System.DateTime V_SalidaMañana
        {
            get
            {
                return v_salidamañana;
            }
            set
            {
                v_salidamañana = value;
            }
        }
        private System.DateTime v_entradatarde;
        public System.DateTime V_EntradaTarde
        {
            get
            {
                return v_entradatarde;
            }
            set
            {
                v_entradatarde = value;
            }
        }
        private System.DateTime v_salidatarde;
        public System.DateTime V_SalidaTarde
        {
            get
            {
                return v_salidatarde;
            }
            set
            {
                v_salidatarde = value;
            }
        }
        private System.Int32 v_toleranciaentrada;
        public System.Int32 V_ToleranciaEntrada
        {
            get
            {
                return v_toleranciaentrada;
            }
            set
            {
                v_toleranciaentrada = value;
            }
        }
        private System.Int32 v_toleranciasalida;
        public System.Int32 V_ToleranciaSalida
        {
            get
            {
                return v_toleranciasalida;
            }
            set
            {
                v_toleranciasalida = value;
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
        private System.DateTime s_entradamañana;
        public System.DateTime S_EntradaMañana
        {
            get
            {
                return s_entradamañana;
            }
            set
            {
                s_entradamañana = value;
            }
        }
        private System.DateTime s_salidamañana;
        public System.DateTime S_SalidaMañana
        {
            get
            {
                return s_salidamañana;
            }
            set
            {
                s_salidamañana = value;
            }
        }
        private System.DateTime s_entradatarde;
        public System.DateTime S_EntradaTarde
        {
            get
            {
                return s_entradatarde;
            }
            set
            {
                s_entradatarde = value;
            }
        }
        private System.DateTime s_salidatarde;
        public System.DateTime S_SalidaTarde
        {
            get
            {
                return s_salidatarde;
            }
            set
            {
                s_salidatarde = value;
            }
        }
        private System.Int32 s_toleranciaentrada;
        public System.Int32 S_ToleranciaEntrada
        {
            get
            {
                return s_toleranciaentrada;
            }
            set
            {
                s_toleranciaentrada = value;
            }
        }
        private System.Int32 s_toleranciasalida;
        public System.Int32 S_ToleranciaSalida
        {
            get
            {
                return s_toleranciasalida;
            }
            set
            {
                s_toleranciasalida = value;
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
        private System.DateTime d_entradamañana;
        public System.DateTime D_EntradaMañana
        {
            get
            {
                return d_entradamañana;
            }
            set
            {
                d_entradamañana = value;
            }
        }
        private System.DateTime d_salidamañana;
        public System.DateTime D_SalidaMañana
        {
            get
            {
                return d_salidamañana;
            }
            set
            {
                d_salidamañana = value;
            }
        }
        private System.DateTime d_entradatarde;
        public System.DateTime D_EntradaTarde
        {
            get
            {
                return d_entradatarde;
            }
            set
            {
                d_entradatarde = value;
            }
        }
        private System.DateTime d_salidatarde;
        public System.DateTime D_SalidaTarde
        {
            get
            {
                return d_salidatarde;
            }
            set
            {
                d_salidatarde = value;
            }
        }
        private System.Int32 d_toleranciaentrada;
        public System.Int32 D_ToleranciaEntrada
        {
            get
            {
                return d_toleranciaentrada;
            }
            set
            {
                d_toleranciaentrada = value;
            }
        }
        private System.Int32 d_toleranciasalida;
        public System.Int32 D_ToleranciaSalida
        {
            get
            {
                return d_toleranciasalida;
            }
            set
            {
                d_toleranciasalida = value;
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
    }
}
