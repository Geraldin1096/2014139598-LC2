using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{
    public class AdministrarLinea
    {

        public int AdministrarLineaId { get; set; }

        public int numeroTelefonico { get; set; }
        public DateTime fecha { get; set; }
        public string estadoLinea { get; set; }

        public LineaTelefonica LineaTelefonicas { get; set; }
        public int LineaTelefonicaId { get; set; }

        public AdministrarLinea()
        {
            LineaTelefonicas = new LineaTelefonica();
        }

    }
}
