using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoTiendadeRopa.Web.Models
{
    public class ProductoModel
    {
          public int id { get; set; }
          public string Descripcion { get; set; }
          public int precio { get; set; }
    }
}