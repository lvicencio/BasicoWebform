using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Usuario
    {
        private string _Nombre;
        private string _Apellido;
        private string _UserName;
        private string _Password;
        private int _id_rol;

      
        public E_Usuario()
        {
            _Nombre = string.Empty;
            _Apellido = string.Empty;
            _UserName = string.Empty;
            _Password = string.Empty;
            _id_rol = 0;
        }


        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public int id_rol
        {
            get { return _id_rol; }
            set { _id_rol = value; }
        }

    }
}
