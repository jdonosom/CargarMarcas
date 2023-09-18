using SGFBussinesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFBussinesLayer.Infraestructura
{
    public interface IBusinessRequest
    {
        #region Interfaces
        public ICredenciales Credenciales { get; }
        public IBodega Bodega { get; }
        public IBoleta Boleta { get; }
        public IBoletaDetalle BoletaDetalle { get; }
        public ICaja Caja { get; }
        public ICliente Cliente { get; }
        public IClienteListaPrecio ClienteListaPrecio { get; }
        public IContrato Contrato { get; }
        public IDocumentoDetalle DocumentoDetalle { get; }
        public IDocumentoReferencia DocumentoReferencia { get; }
        public IDocumento Documento { get; }
        public IEmpresa Empresa { get; }
        public IEmpresas Empresas { get; }
        public IEmpresaUser EmpresaUser { get; }
        public IFacturacion Facturacion { get; }
        public ICompra Compra { get; }
        public IFolioDisponible FolioDisponible { get; }
        public IFormaPago FormaPago { get; }
        public IImpuesto Impuesto { get; }
        public IKardex Kardex { get; }
        public IKardexImpuesto KardexImpuesto { get; }
        public IKardexMovimientos KardexMovimientos { get; }
        public IListaPrecio ListaPrecio { get; }
        public ILista Lista { get; }
        public ILog Log { get; }
        public ILogOn LogOn { get; }
        public IParametro Parametro { get; }
        public ITabla Tabla { get; }
        public ITipoMovimiento TipoMovimiento { get; }
        public IUsuario Usuario { get; }
        public IVendedor Vendedor { get; }
        #endregion
    }
}
