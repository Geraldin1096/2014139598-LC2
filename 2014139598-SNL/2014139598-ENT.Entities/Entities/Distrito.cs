﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{/*
    public class Distrito
    {
        public int DistritoId { get; set; }


        int _codigoDistrito;
        String _nombreDistrito;

        public Distrito(int codigoDistrito, String nombreDistrito)
        {
            _codigoDistrito = codigoDistrito;
            _nombreDistrito = nombreDistrito;
        }
        public int CodigoDistrito
        {
            get { return _codigoDistrito; }
            set { _codigoDistrito = value; }
        }
        public String NombreDistrito
        {
            get { return _nombreDistrito; }
            set { _nombreDistrito = value; }
        }
    }*/
    public class Distrito
    {
        public int DistritoId { get; set; }
        public int codDistrito { get; set; }
        public string nomDistrito { get; set; }
        public Ubigeo Ubigeo { get; set; }
        public Provincia Provincia { get; set; }
    }
}