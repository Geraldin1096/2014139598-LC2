using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{/*
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }


        int _NumDocumento;
        String _TipoDocumento;
        String _FecNacimiento;

        private EstadoEvaluacion _EstadoEvaluacion;
        private TipoEvaluacion _TipoEvaluacion;
        private List<Cliente> _Cliente;
        private List<Plan> _Plan;
        private List<EquipoCelular> _EquipoCelular;
        private List<LineaTelefonica> _LineaTelefonica;
        public Evaluacion()
        {
            _EstadoEvaluacion = new EstadoEvaluacion();
            _TipoEvaluacion = new TipoEvaluacion();
            _EquipoCelular = new List<EquipoCelular>();
        }
        public Evaluacion(int numDocumento, String tipoDocumento, String fecNacimiento, List<Cliente> cliente, List<Plan> plan, List<LineaTelefonica> lineaTelefonica)
        {
            NumeroDocumento = numDocumento;
            TipoDocumento = tipoDocumento;
            FecNacimiento = fecNacimiento;
            Cliente = cliente;
            Plan = plan;
        }
        public String TipoDocumento
        {
            get { return _TipoDocumento; }
            set { _TipoDocumento = value; }
        }
        public String FecNacimiento
        {
            get { return _FecNacimiento; }
            set { _FecNacimiento = value; }
        }
        public int NumeroDocumento
        {
            get { return _NumDocumento; }
            set { _NumDocumento = value; }
        }
        public List<LineaTelefonica> LineaTelefonica
        {
            get { return _LineaTelefonica; }
            set { _LineaTelefonica = value; }
        }
        public List<Cliente> Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }
        public List<Plan> Plan
        {
            get { return _Plan; }
            set { _Plan = value; }
        }
    }*/
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }
        public int codEvaluacion { get; set; }
        public Venta Venta { get; set; }
        public CentroAtencion CentroAtencion { get; set; }
        public Trabajador Trabajador { get; set; }
        public EstadoEvaluacion EstadoEvaluacion { get; set; }
        public TipoEvaluacion TipoEvaluacion { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Plan> Plan { get; set; }
        public ICollection<EquipoCelular> EquipoCelular { get; set; }
        public ICollection<LineaTelefonica> LineaTelefonica { get; set; }

        public Evaluacion()
        {
            Plan = new Collection<Plan>();
            EquipoCelular = new Collection<EquipoCelular>();
            LineaTelefonica = new Collection<LineaTelefonica>();
        }
    }
}
