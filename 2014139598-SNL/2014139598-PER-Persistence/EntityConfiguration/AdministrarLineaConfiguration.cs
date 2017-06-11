using _2014139598_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_PER_Persistence.EntityConfiguration
{
    public class AdministrarLineaConfiguration : EntityTypeConfiguration<AdministrarLinea>
    {
        public AdministrarLineaConfiguration()
        {
            
                //Table Configuration
                ToTable("AdministradorLinea");
                HasKey(al => al.AdministrarLineaId);

                HasRequired(lt => lt.LineaTelefonicas).WithMany(al => al.AdministrarLinea).HasForeignKey(lt => lt.LineaTelefonicaId);
            


        }
    }
}
