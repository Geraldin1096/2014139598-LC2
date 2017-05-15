using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{
    /*  public class Provincia
      {
          public int ProvinciaId { get; set; }


          private List<Distrito> _Distrito;
          int _codProvincia;
          String _nomProvincia;
          public Provincia(int codDistrito, int codProvincia, String nomProvincia)
          {
              _codProvincia = codDistrito;
              _nomProvincia = nomProvincia;

              _Distrito = new List<Distrito>(codDistrito);
          }
          public int CodigoProvincia
          {
              get { return _codProvincia; }
              set { _codProvincia = value; }
          }
          public String NombreProvincia
          {
              get { return _nomProvincia; }
              set { _nomProvincia = value; }
          }
          public Distrito CodigoDistrito { get; set; }
      }*/
    public class Provincia
    {
        public int ProvinciaId { get; set; 
        public int codProvincia { get; set; }
        public string nomProvincia { get; set; }
        public Departamento Departamento { get; set; }
        public Ubigeo Ubigeo { get; set; }
        public ICollection<Distrito> Distrito { get; set; }

        public Provincia()
        {
            Distrito = new Collection<Distrito>();
        }
    }
}
