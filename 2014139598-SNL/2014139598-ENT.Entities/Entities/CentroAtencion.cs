using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{
    public class CentroAtencion
    {
        public int CentroAtencionId { get; set; }

        public string nombreCeAtencion { get; set; }

        public Direccion Direccions { get; set; }
        public int DireccionId { get; set; }
        public Evaluacion Evaluacion { get; set; }

        public CentroAtencion()
        {
            Direccions = new Direccion();
        }
    }
}
