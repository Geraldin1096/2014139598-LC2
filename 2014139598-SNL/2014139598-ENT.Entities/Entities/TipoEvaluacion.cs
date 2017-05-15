using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{
    /*   public class TipoEvaluacion
       {
           public int TipoEvaluacionId { get; set; }


           public string DescripTipEvaluacion { get; set; }
           public TipoEvaluacion()
           {

           }
           public TipoEvaluacion(string tipoEvaluacion)
           {
               DescripTipEvaluacion = tipoEvaluacion;
           }
       }*/

    public class TipoEvaluacion
    {
        public int TipoEvaluacionId { get; set; }
        public int codTipoEva { get; set; }
        public string nomTipoEva { get; set; }
        public ICollection<Evaluacion> Evaluacion { get; set; }

        public TipoEvaluacion()
        {
            Evaluacion = new Collection<Evaluacion>();
        }

    }
}
