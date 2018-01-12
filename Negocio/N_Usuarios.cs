using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
    public class N_Usuarios
    {
        D_Usuarios objetoNegocioUsuario = new D_Usuarios();

        public DataSet Login(string Username, string Password)
        {
            return objetoNegocioUsuario.Login(Username, Password);
        }

        public int IngresarUsuario(E_Usuario objeE_Usuario)
        {
            return objetoNegocioUsuario.IngresoUsuario(objeE_Usuario);
        }

    }
}
