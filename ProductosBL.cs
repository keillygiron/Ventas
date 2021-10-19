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
        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);
            if (resultado.Existoso == false)
            {
                return resultado;
            }

            if (producto.Id == 0)
            {
                producto.Id = ListaProductos.Max(item => item.Id) + 1;
            }

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()

        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    ListaProductos.Remove(producto);
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;

            }

            if (producto.Existencia < 0)
            {
                resultado.Mensaje = "La existencia debe ser ser mayor que cero";
                resultado.Exitoso = false;

            }

            if (producto.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser ser mayor que cero";
                resultado.Exitoso = false;

            }
            return resultado;
        }
    }
    public class Producto
    {
        public int Id { get; set; }
        public string Descripción { get; set; }
        public double Precio { get; set; }
        public string Tamano { get; set; }
        public bool Activo { get; set; }
        public int Existencia { get; internal set; }
        public string Descripcion { get; internal set; }
    }

    public class Resultado
    {
        public bool Existoso { get; internal set; }
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}

