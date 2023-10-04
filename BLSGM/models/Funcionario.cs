using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
#nullable disable
    public partial class Funcionario
    {
        private System.Int32 idempleado;
        public System.Int32 IdEmpleado
        {
            get
            {
                return idempleado;
            }
            set
            {
                idempleado = value;
            }
        }
        private System.String rut;
        public System.String Rut
        {
            get
            {
                return rut;
            }
            set
            {
                rut = value;
            }
        }
        private System.String nombres;
        public System.String Nombres
        {
            get
            {
                return nombres;
            }
            set
            {
                nombres = value;
            }
        }
        private System.String apellidopaterno;
        public System.String ApellidoPaterno
        {
            get
            {
                return apellidopaterno;
            }
            set
            {
                apellidopaterno = value;
            }
        }
        private System.String apellidomaterno;
        public System.String ApellidoMaterno
        {
            get
            {
                return apellidomaterno;
            }
            set
            {
                apellidomaterno = value;
            }
        }
        private System.Byte[] foto;
        public System.Byte[] Foto
        {
            get
            {
                return foto;
            }
            set
            {
                foto = value;
            }
        }
        private System.String email;
        public System.String Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        private System.String nombreCompleto;
        public System.String NombreCompleto
        {
            get
            {
                return $"{apellidopaterno.TrimEnd()} {apellidomaterno.TrimEnd()} {nombres.TrimEnd()}";
            }
        }
    }
}
