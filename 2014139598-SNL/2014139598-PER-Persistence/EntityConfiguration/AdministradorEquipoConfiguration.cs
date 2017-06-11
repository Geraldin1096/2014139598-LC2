using _2014139598_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_PER_Persistence.EntityConfiguration
{
    public class AdministradorEquipoConfiguration : EntityTypeConfiguration<AdministradorEquipo>
    {
        public AdministradorEquipoConfiguration()
        {
            //Table Configuration
            ToTable("AdministradorEquipo");
            HasKey(ae => ae.AdministradorEquipoId);

            //Relationships Configurations

            HasRequired(ec => ec.EquipoCelulars).WithMany(ae => ae.AdministradorEquipo).HasForeignKey(ec => ec.EquipoCelularId);




        }
    }
}
