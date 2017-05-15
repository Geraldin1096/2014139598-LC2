using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{
    /*
    public class CentroAtencion
    {
        public int CentroAtencionId { get; set; }

        private List<Direccion> _Direccion;
        int _codCentroAtencion;
        String _nomCentroAtencion;
        public CentroAtencion(int codDireccion, int codCentroAtencion, String nomCentroAtencion)
        {
            _Direccion = new List<Direccion>(codDireccion);

            _codCentroAtencion = codCentroAtencion;
            _nomCentroAtencion = nomCentroAtencion;
        }
        public int CodigoCentroAtencion
        {
            get { return _codCentroAtencion; }
            set { _codCentroAtencion = value; }
        }
        public String NombreCentroAtencion
        {
            get { return _nomCentroAtencion; }
            set { _nomCentroAtencion = value; }
        }
        public int CodDireccion { get; set; }
    } */
    public class CentroAtencion
    {
        public int CentroAtencionId { get; set; }

        public int codCentroAten { get; set; }
        public string sucursal { get; set; }
        public Direccion Direccion { get; set; }
        public ICollection<Evaluacion> Evaluacion { get; set; }
        public ICollection<Venta> Venta { get; set; }

        public CentroAtencion()
        {
            Evaluacion = new Collection<Evaluacion>();
            Venta = new Collection<Venta>();
        }
    }
}
