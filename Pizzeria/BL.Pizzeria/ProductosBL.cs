using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    public class ProductosBL
    {
        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripción = "Pizza Pepperoni o Jamón";
            producto1.Precio = 115;
            producto1.Tamano = "Mediana";
            producto1.Activo = true;

            ListaProductos.Add(producto1);

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripción = "Pizza Hawaiana";
            producto2.Precio = 140;
            producto2.Tamano = "Mediana";
            producto2.Activo = true;

            ListaProductos.Add(producto2);

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripción = "Pizza Suprema";
            producto3.Precio = 165;
            producto3.Tamano = "Mediana";
            producto3.Activo = true;

            ListaProductos.Add(producto3);
        }

        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Descripción { get; set; }
        public double Precio { get; set; }
        public string Tamano { get; set; }
        public bool Activo { get; set; }
    }
}
