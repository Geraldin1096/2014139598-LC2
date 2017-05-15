
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{
    /*   public class TipoPlan
       {
           public int TipoPlanId { get; set; }
           public string DescripcionTipoPlan { get; set; }
           public TipoPlan()
           {

           }
           public TipoPlan(string descripcionTipoPlan)
           {
               DescripcionTipoPlan = descripcionTipoPlan;
           }
       }*/
    public class TipoPlan
    {
        public int TipoPlanId { get; set; }
        public int codTipoPlan { get; set; }
        public string nomTipoPlan { get; set; }
        public ICollection<Plan> Plan { get; set; }

        public TipoPlan()
        {
            Plan = new Collection<Plan>();
        }
    }
}
