﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS;

public class FACTURAcs
{

    public int Id { get; set; }

    public string IdentidadCliente { get; set; }

    public string Cliente { get; set; }
    public DateTime Fecha { get; set; }
    public decimal SubTotal { get; set; }

    public decimal ISV { get; set; }

    public decimal Total { get; set; }

}