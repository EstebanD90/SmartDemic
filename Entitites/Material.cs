﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Material
    {
        public Guid id { get; set; }
        public string descripcion { get; set; }
        public double cantidad { get; set; }
        public double precio { get; set; }
        public string proveedor { get; set; }
        public bool estado { get; set; }
    }
}