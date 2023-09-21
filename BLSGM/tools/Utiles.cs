using BLSGM.infraestructura;
using Microsoft.Extensions.Configuration;

namespace BLSGM.Tools
{
    public class Utiles
    {
        private readonly IConfiguration cfg;
        private readonly BusinessRequest Bl;

        public Utiles(
                IConfiguration cfg,
                BusinessRequest bl
            )
        {
            this.cfg = cfg;
            this.Bl = bl;
        }

        public string ObtenerNombreMaquina
        {
            get { return Environment.MachineName; }

        }

        /// <summary>
        /// Obtener el ambiente de operacion SII
        /// </summary>
        /// <returns>Retorna cadena con el ambiente configurado</returns>
        public string Environ
        {
            get
            {
                try
                {

                    return cfg.GetSection("SII:Environ").Value;

                }
                catch (Exception)
                {

                    return null;

                }
            }
        }


        /// <summary>
        /// Evalua si el dato es null
        /// </summary>
        /// <param name="o">El parametro a evaluar</param>
        /// <returns>Retorna true en caso de ser nulo o false en otro caso</returns>
        public bool IsNull(object o)
        {

            return o == null ? true : false;

        }

        /// <summary>
        /// Retorna el Rut del Emisor
        /// </summary>
        /// <returns></returns>
        public string GetRUTEmisor
        {
            get
            {

                try
                {

                    return cfg.GetSection("Empresa:RutEmpresa").Value;

                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Obtiene valor que indica si se realizan los envios al SII
        /// </summary>
        /// <returns>Retorna true, si se deben enviar los DTE al SII, false en caso contrario</returns>
        public bool PermitirEnvioSII
        {
            get
            {
                try
                {

                    return cfg.GetSection("App.FlagEnvio").Value.Equals(1);

                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public string ObtenerRutaDTE
        {
            get
            {
                try
                {
                    return cfg.GetSection("App:DTEPath").Value;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }



        /// <summary>
        /// Obtiene el Rut del emisor desde la configuración
        /// </summary>
        /// <returns>Retorna un string con el rut del emisor</returns>
        public string ObtenerRUTEmpresa
        {
            get
            {
                try
                {
                    return cfg.GetSection("Empresa:RutEmpresa").Value;
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
        /// <summary>
        /// Obtiene la ruta base en que se dejaran los DTE
        /// </summary>
        /// <returns>Retorna una cadena con la ruta a la carpeta contenedora.</returns>
        public string GetBasePathDTE
        {
            get
            {
                try
                {

                    return cfg.GetSection("App:DTEPath").Value;

                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Obtiene la bodega en que el sistema operará
        /// </summary>
        /// <returns>Retorna el código de la bodega donde se operará</returns>
        public int ObtenerBodega
        {
            get
            {
                try
                {

                    return Convert.ToInt32(cfg.GetSection("App:BodegaAfecta").Value);

                }
                catch (Exception)
                {

                    return -1;

                }
            }
        }


        /// <summary>
        /// Obtiene los códigos de actividades economicas desde la configuración
        /// </summary>
        /// <returns>Retorna una List con los codigos de actividades</returns>
        public List<int> ObtenerCodigosActividades
        {
            get
            {
                try
                {
                    return cfg.GetSection("Empresa:CodigosActividades")
                         .GetChildren()
                         .ToList()
                         .Select(x => Convert.ToInt32(x.Value))
                         .ToList();

                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
        /// <summary>
        /// Obtiene una lista de sucursales desde la configuración
        /// </summary>
        /// <returns>Retorna una List con las sucursales</returns>
        public List<string> ObtenerSucursales
        {
            get
            {
                try
                {

                    return cfg.GetSection("Sucursales")
                        .GetChildren()
                        .ToList()
                        .Select(x => x.Value)
                        .ToList();

                }
                catch (Exception)
                {

                    return null;
                }
            }
        }
        /// <summary>
        /// Obtiene la Oficina SII desde la configuración
        /// </summary>
        /// <returns>Retorna una cadena con la Odicina</returns>
        public string ObtenerOficinaSII
        {
            get
            {
                try
                {
                    return cfg.GetSection("SII:OficinaSII").Value;

                }
                catch (Exception)
                {

                    return null;

                }
            }
        }


        /// <summary>
        /// Obtiene el numero de resolución desde la configuración
        /// </summary>
        /// <returns>Retorna numero de resolución</returns>
        public int ObtenerNumeroResolucion
        {
            get
            {
                try
                {

                    return Convert.ToInt32(cfg.GetSection("Empresa:NumeroResolucion").Value);

                }
                catch (Exception)
                {

                    return 0;

                }
            }
        }

        /// <summary>
        /// Obtiene la fecha de resolución desde la configuración
        /// </summary>
        /// <returns>Retorna la fecha de resolución</returns>
        public DateTime? ObtenerFechaResolucion
        {
            get
            {
                try
                {

                    return Convert.ToDateTime(cfg.GetSection("Empresa:FechaResolucion").Value);


                }
                catch (Exception)
                {

                    return null;

                }
            }
        }

        /// <summary>
        /// Obtener la Web pie de pagina
        /// </summary>
        /// <returns>Retorna una cadena con la web</returns>
        public string ObtenerWebVerificacion
        {
            get
            {
                try
                {

                    return cfg.GetSection("SII:WebVerificacion").Value;

                }
                catch (Exception)
                {
                    return null;
                }
            }

        }


        /// <summary>
        /// Obtiene el nombre del archivo de certificado desde la configuración
        /// </summary>
        /// <returns>Retorna el nombre del archivo</returns>
        public string GetArchivoCertificado
        {
            get
            {
                try
                {

                    return cfg.GetSection("Certificado.Nombre").Value;

                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

        /// <summary>
        /// Obtiene el nombre de la impresora de documentos
        /// </summary>
        /// <returns>Retorna el nombre de la impresora</returns>
        public string ObtenerImpresoraDoc
        {
            get
            {
                try
                {

                    return cfg.GetSection("App:ImpresoraRPT").Value;

                }
                catch (Exception)
                {

                    return null;

                }
            }
        }

        /// <summary>
        /// Obtiene el nombre de la impresora del POS
        /// </summary>
        /// <returns>Retorna el nombre de la impresota del POS</returns>
        public string ObtenerImpresoraPOS
        {
            get
            {
                try
                {

                    return cfg.GetSection("App:ImpresoraSII").Value;

                }
                catch (Exception)
                {

                    return null;

                }
            }
        }
    }
}

