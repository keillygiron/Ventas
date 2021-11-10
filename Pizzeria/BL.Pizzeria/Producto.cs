using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripción { get; set; }
        public double Precio { get; set; }
        public string Tamaño { get; set; }
        public bool Activo { get; set; }
        public int Existencia { get; internal set; }
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }
        public byte[] Foto { get; set; }
        public string Descripcion { get; internal set; }
        }
    }

