using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{
    /*  public class Ubigeo
      {
          public int UbigeoId { get; set; }


          private List<Departamento> _Departamento;
          private List<Provincia> _Provincia;
          private List<Distrito> _Distrito;

          int _codUbigeo;
          public int CodigoUbigeo
          {
              get { return _codUbigeo; }
              set { _codUbigeo = value; }
          }
          public List<Departamento> Departamento
          {
              get { return _Departamento; }
              set { _Departamento = value; }
          }
          public List<Provincia> Provincia
          {
              get { return _Provincia; }
              set { _Provincia = value; }
          }
          public List<Distrito> Distrito
          {
              get { return _Distrito; }
              set { _Distrito = value; }
          }
          public Ubigeo(int codUbigeo, List<Departamento> departamento, List<Provincia> provincia, List<Distrito> distrito)
          {
              CodigoUbigeo = codUbigeo;
              Departamento = departamento;
              Provincia = provincia;
              Distrito = distrito;
          }
      }*/
    public class Ubigeo
    {
        public int UbigeoId { get; set; }
        public int codUbigeo { get; set; }
        public Direccion Direccion { get; set; }

        public ICollection<Departamento> Departamento { get; set; }
        public ICollection<Provincia> Provincia { get; set; }
        public ICollection<Distrito> Distrito { get; set; }

        public Ubigeo()
        {
            Departamento = new Collection<Departamento>();
            Provincia = new Collection<Provincia>();
            Distrito = new Collection<Distrito>();
        }
    }
}
