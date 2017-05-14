using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{
    public class AdministrarLinea
    {

        public int AdministrarLineaId { get; set; }

        public List<LineaTelefonica> Lineas { get; set; }

        public AdministrarLinea()
        {
            Lineas = new List<LineaTelefonica>();
        }

        public void AgregarLinea(string numero)
        {
            Lineas.Add(new LineaTelefonica(numero));
        }
    }
}
