﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139598_ENT.Entities
{
    public class TipoPago
    {
        public int TipoPagoId { get; set; }



        public string FormaPago { get; set; }
        public TipoPago()
        {

        }
        public TipoPago(string tipoPago)
        {
            FormaPago = tipoPago;
        }
    }
}