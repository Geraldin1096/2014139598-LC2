using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{
    /* public class Venta
     {
         public int VentaId { get; set; }

         int _codVenta;
         String _modalidad;
         String _fechaVanta;
         Double _montoTotal;

         private List<LineaTelefonica> _LineaTelefonica;
         private List<Contrato> _Contrato;
         private List<Evaluacion> _Evaluacion;
         private List<Cliente> _Cliente;
         private TipoPago _TipoPago;
         public Venta()
         {
             _LineaTelefonica = new List<LineaTelefonica>();
             _Contrato = new List<Contrato>();
             _Evaluacion = new List<Evaluacion>();
             _Cliente = new List<Cliente>();
         }
         public Venta(int codVenta, String modalidad, String fechaVanta, Double montoTotal, TipoPago tipoPago)
         {
             CodigoVenta = codVenta;
             Modalidad = modalidad;
             FechaVanta = fechaVanta;
             MontoTotal = montoTotal;
             TiposPagos = tipoPago;
         }
         public int CodigoVenta
         {
             get { return _codVenta; }
             set { _codVenta = value; }
         }
         public String Modalidad
         {
             get { return _modalidad; }
             set { _modalidad = value; }
         }
         public String FechaVanta
         {
             get { return _fechaVanta; }
             set { _fechaVanta = value; }
         }
         public Double MontoTotal
         {
             get { return _montoTotal; }
             set { _montoTotal = value; }
         }
         public TipoPago TiposPagos
         {
             get { return _TipoPago; }
             set { _TipoPago = value; }
         }
     }*/
    public class Venta
    {
        public int VentaId { get; set; }
        public int codVenta { get; set; }
        public Evaluacion Evaluacion { get; set; }
        public Contrato Contrato { get; set; }
        public CentroAtencion CentroAtencion { get; set; }
        public Cliente Cliente { get; set; }
        public TipoPago TipoPago { get; set; }
        public ICollection<LineaTelefonica> LineaTelefonica { get; set; }

        public Venta()
        {
            LineaTelefonica = new Collection<LineaTelefonica>();
        }
    }
}
