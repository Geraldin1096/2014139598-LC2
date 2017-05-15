using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{/*
    public class EstadoEvaluacion
    {

        public int EstadoEvaluacionId { get; set; }

        public string Estado { get; set; }
        public EstadoEvaluacion()
        {

        }
        public EstadoEvaluacion(string estado)
        {
            Estado = estado;
        }
    }*/
    public class EstadoEvaluacion
    {
        public int EstadoEvaluacionId { get; set; }
        public int codEstadoEva { get; set; }
        public string nomEstadoEva { get; set; }
        public ICollection<Evaluacion> Evaluacion { get; set; }

        public EstadoEvaluacion()
        {
            Evaluacion = new Collection<Evaluacion>();
        }
    }
}
