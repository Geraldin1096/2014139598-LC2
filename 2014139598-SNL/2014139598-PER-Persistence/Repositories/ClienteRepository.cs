﻿using _2014139598_ENT.Entities;
using _2014139598_ENT.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_PER_Persistence.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private LineaNuevaDbContext _Context;

        public ClienteRepository(LineaNuevaDbContext context)
        {
            _Context = context;
        }
        private ClienteRepository()
        {

        }
    }
}
