using _2014139598_ENT.Entities;
using _2014139598_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_PER_Persistence.Repositories
{
    public class ProvinciaRepository : Repository<Provincia>, IProvinciaRepository
    {
        private LineaNuevaDbContext _Context;

        public ProvinciaRepository(LineaNuevaDbContext context)
        {
            _Context = context;
        }
        private ProvinciaRepository()
        {

        }
    }
}
