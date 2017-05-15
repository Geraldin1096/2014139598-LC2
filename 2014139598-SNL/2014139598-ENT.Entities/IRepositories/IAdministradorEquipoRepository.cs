﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities.IRepositories
{
    public interface IAdministradorEquipoRepository : IRepository  <AdministradorEquipo> {

        IEnumerable<AdministradorEquipo> GetAdministradorEquiposWithEquipoCelulars(int pageIndex, int pageSize);
    }
}
