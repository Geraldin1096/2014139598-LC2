using _2014139598_ENT.Entities;
using _2014139598_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_PER_Persistence.Repositories
{
    class AdministradorEquipoRepository : Repository<AdministradorEquipo>, IAdministradorEquipoRepository
    {
        private readonly LineaNuevaDbContext _Context;

        private AdministradorEquipoRepository()
        {

        }
        public AdministradorEquipoRepository(LineaNuevaDbContext context)
        {
            _Context = context;

        }
        IEnumerable<AdministradorEquipo> IAdministradorEquipoRepository.GetAdministradorEquiposWithEquipoCelulars(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
