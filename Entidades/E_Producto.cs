using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Producto
    {
        private int _Id_Producto;
        private int _CantidadProducto;
        private string _NombreProducto;
        private string _DescripcionProducto;
        private int _Precio;


        public E_Producto()
        {
            _Id_Producto = 0;
            _CantidadProducto = 0;
            _NombreProducto = string.Empty;
            _DescripcionProducto = string.Empty;
            _Precio = 0;
        }


        public int Id_Producto
        {
            get { return _Id_Producto; }
            set { _Id_Producto = value; }
        }
        public int CantidadProducto
        {
            get { return _CantidadProducto; }
            set { _CantidadProducto = value; }
        }
        public string NombreProducto
        {
            get { return _NombreProducto; }
            set { _NombreProducto = value; }
        }
        public string DescripcionProducto
        {
            get { return _DescripcionProducto; }
            set { _DescripcionProducto = value; }
        }
        public int Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }
    }
}
