﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IARBA
    {
        double CalcularImpuesto();

        double Impuesto { get; set; }
    }
}