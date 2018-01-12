using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;


namespace Negocio
{
    
    public class N_Productos
    {
        D_Productos objNegProducto = new D_Productos();

        public int abcProducto(string pAccion, E_Producto objeE_Producto)
        {
            return objNegProducto.abcProducto(pAccion, objeE_Producto);
        }

        public DataSet ListadoProductos()
        {
            return objNegProducto.ListadoProductos();
        }

        public DataSet SeleccionaProducto(int pIdProducto)
        {
            return objNegProducto.SeleccionaProducto(pIdProducto);
        }

        public DataSet BuscarProducto(string NombreProducto)
        {
            return objNegProducto.BuscarProducto(NombreProducto);
        }

    }
}
