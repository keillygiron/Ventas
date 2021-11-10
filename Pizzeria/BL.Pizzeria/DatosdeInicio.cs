using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<contexto>
    {
        protected override void Seed(contexto contexto)
        {
            Cliente a = new Cliente();
            a.Nombre = "Héctor";
            a.Teléfono = "754933";

            Cliente b = new Cliente();
            b.Nombre = "Carla";
            b.Teléfono = "584519";

            contexto.Clientes.Add(a);
            contexto.Clientes.Add(b);

            Producto c = new Producto(); // descripción, tipo, precio, tamaño
            c.Precio = 150;
            c.Descripción = "Pizza Deluxe";
            c.Tamaño = "Mediana";

            Producto d = new Producto(); // descripción, tipo, precio, tamaño
            d.Precio = 180;
            d.Descripción = "Pizza Hawaiana";
            d.Tamaño = "Mediana";

            Producto e = new Producto(); // descripción, tipo, precio, tamaño
            e.Precio = 200;
            e.Descripción = "Pizza Random 1";
            e.Tamaño = "Mediana";

            Producto f = new Producto(); // descripción, tipo, precio, tamaño
            f.Precio = 150;
            f.Descripción = "Pizza Random 2";
            f.Tamaño = "Mediana";

            Producto g = new Producto(); // descripción, tipo, precio, tamaño
            g.Precio = 180;
            g.Descripción = "Pizza Random 3";
            g.Tamaño = "Mediana";

            Producto h = new Producto(); // descripción, tipo, precio, tamaño
            h.Precio = 180;
            h.Descripción = "Pizza Random 4";
            h.Tamaño = "Mediana";

            contexto.Productos.Add(c);
            contexto.Productos.Add(d);
            contexto.Productos.Add(e);
            contexto.Productos.Add(f);
            contexto.Productos.Add(g);
            contexto.Productos.Add(h);

            base.Seed(contexto);
        }
    }
}
