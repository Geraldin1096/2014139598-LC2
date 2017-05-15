﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{/*
    public class Direccion
    {
        public int DireccionId { get; set; }


        private List<Ubigeo> _Ubigeo;
        int _codDireccion;
        String _nomDireccion;
        public Direccion(int codUbigeo, int codDireccion, String nomDireccion)
        {
            _Ubigeo = new List<Ubigeo>(codUbigeo);

            _codDireccion = codDireccion;
            _nomDireccion = nomDireccion;
        }
        public int CodigoDireccion
        {
            get { return _codDireccion; }
            set { _codDireccion = value; }
        }
        public String NombreDireccion
        {
            get { return _nomDireccion; }
            set { _nomDireccion = value; }
        }
        public int CodigoUbigeo { get; set; }
    }*/
    public class Direccion
    {
        public int DireccionId { get; set; }

        public int codDireccion { get; set; }
        public string nombre { get; set; }
        public CentroAtencion CentroAtencion { get; set; }
        public ICollection<Ubigeo> Ubigeo { get; set; }

        public Direccion()
        {
            Ubigeo = new Collection<Ubigeo>();
        }
    }
}