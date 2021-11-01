using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    public class ProductosBL
    {

        contexto _contexto;
        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new contexto();
            ListaProductos = new BindingList<Producto>();

               }

        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();
            return ListaProductos;
        }
        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);
            if (resultado.Existoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

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
                    _contexto.SaveChanges();
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

             if (producto. TipoId == 0)
                {
                    resultado.Mensaje = "Selecccione un Tipo";
                    resultado.Exitoso = false;
                }
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
        public int TipoId { get; set; }
        public Tipo Tipo { get; set;} 
        public byte [] Foto { get; set;}
        public string Descripcion { get; internal set; }
    }

    public class Resultado
    {
        public bool Existoso { get; internal set; }
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}

