﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStop.BL
{
    public class ProductosBL
    {
        Contexto _contexto;

        public ProductosBL()
        {
            _contexto = new Contexto();
        }

        public List<Producto> ObtenerProductos()
        {
            _contexto.Productos.ToList();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Zelda";
            producto1.Precio = 200;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Mario";
            producto2.Precio = 250;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Kirby";
            producto3.Precio = 300;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return listadeProductos;
        }
    }
}