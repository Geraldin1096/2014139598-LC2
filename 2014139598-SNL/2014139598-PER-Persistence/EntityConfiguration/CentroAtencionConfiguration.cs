using _2014139598_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_PER_Persistence.EntityConfiguration
{
    public class CentroAtencionConfiguration : EntityTypeConfiguration<CentroAtencion>
    {
        public CentroAtencionConfiguration()
        {
            //Table Configuration
            ToTable("CentroAtencion");
            HasKey(ca => ca.CentroAtencionId);

            //Relationships Configurations

            HasRequired(di => di.Direccions).WithRequiredPrincipal(di => di.CentroAtencion);
        }
    }
}
