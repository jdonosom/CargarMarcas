﻿using BLSGM.interfaces;

namespace BLSGM.infraestructura
{
    public class BusinessRequest
    {

        #region Propiedades 
        public ICargo Cargo { get; }
        public IDireccion Direccion { get; }
        public IDispositivos Dispositivos { get; }
        public IDispositivosFuncionario DispositivosFuncionario { get; }
        public IFuncionario Funcionario { get; }
        public IFuncionarioTipoContrato FuncionarioTipoContrato { get; }
        public IFuncionarioUnidad FuncionarioUnidad { get; }
        public IHorario Horario { get; }
        public IHorarioFuncionario HorarioFuncionario { get; }
        public IRegistro Registro { get; }
        public IRegistroDiario RegistroDiario { get; }
        public ITipoContrato TipoContrato { get; }
        public ITipoMarca TipoMarca { get; }
        public IUnidad Unidad { get; }
        #endregion

        public BusinessRequest(
              ICargo cargo
            , IDireccion direccion
            , IDispositivos dispositivos
            , IDispositivosFuncionario dispositivosFuncionario
            , IFuncionario funcionario
            , IFuncionarioTipoContrato funcionarioTipoContrato
            , IFuncionarioUnidad funcionarioUnidad
            , IHorario horario
            , IHorarioFuncionario horarioFuncionario
            , IRegistro registro
            , IRegistroDiario registroDiario
            , ITipoContrato tipoContrato
            , ITipoMarca tipoMarca
            , IUnidad unidad
            )
        {

            this.Cargo = cargo;
            this.Direccion = direccion;
            this.Dispositivos = dispositivos;
            this.DispositivosFuncionario = dispositivosFuncionario;
            this.Funcionario = funcionario;
            this.FuncionarioTipoContrato = funcionarioTipoContrato;
            this.FuncionarioUnidad = funcionarioUnidad;
            this.Horario = horario;
            this.HorarioFuncionario = horarioFuncionario;
            this.Registro = registro;
            this.RegistroDiario = registroDiario;
            this.TipoContrato = tipoContrato;
            this.TipoMarca = tipoMarca;
            this.Unidad = unidad;
        }
    }
}
