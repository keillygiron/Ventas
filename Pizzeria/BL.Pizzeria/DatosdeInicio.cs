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
            var tipo1 = new Tipo();
            tipo1.Descripcion = "Pizzas";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Refrescos";
            contexto.Tipos.Add(tipo2);

            base.Seed(contexto);
        }
    }
}
