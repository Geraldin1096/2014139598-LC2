using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities.IRepositories
{
   public interface IUnityOfWork : IDisposable
    {
        IAdministradorEquipoRepository AdministradorEquipos { get;  }
        IAdministrarLineaRepository AdministrarLineas { get; }
        ICentroAtencionRepository CentroAtencions { get; }
        IClienteRepository Clientes { get; }
        IContratoRepository Contratos { get; }
        IDepartamentoRepository Departamentos { get; }
        IDireccionRepository Direccions { get; }
        IDistritoRepository Distritos { get; }
        IEquipoCelularRepository EquipoCelulars { get; }
        IEstadoEvaluacionRepository EstadoEvaluacions { get; }
        IEvaluacionRepository Evaluacions { get; }
        ILineaTelefonicaRepository LineaTelefonicas { get; }
        IPlanRepository Plans { get; }
        IProvinciaRepository Provincias { get; }
        ITipoEvaluacionRepository TipoEvaluacions { get; }
        ITipoLineaRepository TipoLineas { get; }
        ITipoPagoRepository TipoPagos { get; }
        ITipoPlanRepository TipoPlans { get; }
        ITipoTrabajadorRepository TipoTrabajadors { get; }
        ITrabajadorRepository Trabajadors { get; }
        IUbigeoRepository Ubigeos { get; }
        IVentaRepository Ventas { get; }


        int SaveChange();

    }
}
