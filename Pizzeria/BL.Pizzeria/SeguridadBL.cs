using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Pizzeria
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contraseña)
        {
            if (usuario == "jgarcia" && contraseña == "214")
            {
                return true;
            }
            else
            {
                if (usuario == "jcastro" && contraseña == "512")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
