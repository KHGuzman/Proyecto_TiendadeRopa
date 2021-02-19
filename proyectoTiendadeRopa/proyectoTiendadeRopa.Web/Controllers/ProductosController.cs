using proyectoTiendadeRopa.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyectoTiendadeRopa.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.id = 1;
            producto1.Descripcion = "Camisa roja talla M";
            producto1.precio = 200;

            var producto2 = new ProductoModel();
            producto2.id = 2;
            producto2.Descripcion = "Pantalon jean azul talla 32";
            producto2.precio = 700;

            var producto3 = new ProductoModel();
            producto3.id = 3;
            producto3.Descripcion = "Blusa roja talla S";
            producto3.precio = 600;

            var producto4 = new ProductoModel();
            producto4.id = 4;
            producto4.Descripcion = "Pantalon de tela talla 30";
            producto4.precio = 500;

            var producto5 = new ProductoModel();
            producto5.id = 5;
            producto5.Descripcion = "Tenis Nike rojos talla9";
            producto5.precio = 1200;

            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);
            listadeProductos.Add(producto5);

            return View(listadeProductos);
        }
    }
}