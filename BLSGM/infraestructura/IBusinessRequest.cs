using BLSGM.interfaces;
namespace BLSGN.infraestructura
{
    public interface IBusinessRequest
    {
        #region interfaces
        public ICargo Cargo { get; }
        public IDireccion Direccion { get; }
        public IDispositivos Dispositivos { get; }
        public IDispositivosFuncionario DispositivoFuncionario{ get; }
        public IFuncionario Funcionario { get; }
        public IFuncionarioTipoContrato FuncionarioTipoContrato{ get; }
        public IFuncionarioUnidad FuncionarioUnidad { get; }
        public IHorario Horario { get; }
        public IHorarioFuncionario HorarioFuncionario{ get; }
        public IRegistro Registro { get; }
        public IRegistroDiario RegistroDiario { get; }
        public ITipoContrato TipoContrato { get; }
        public ITipoMarca TipoMarca { get; }
        public IUnidad Unidad { get; }
        #endregion
    }
}
