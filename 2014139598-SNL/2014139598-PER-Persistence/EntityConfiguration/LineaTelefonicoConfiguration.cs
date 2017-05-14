using _2014139598_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_PER_Persistence.EntityConfiguration
{
    public class LineaTelefonicaConfiguration : EntityTypeConfiguration<LineaTelefonica>
    {
        public LineaTelefonicaConfiguration()
        {
            //Table Configuration
            ToTable("LineaTelefonica");
            HasKey(lt => lt.LineaTelefonicaId);

            //Relationships Configurations


        }
    }
}
