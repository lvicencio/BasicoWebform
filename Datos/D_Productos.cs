using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class D_Productos:ConexionDB
    {
        public D_Productos()
        { }


        public int abcProducto(string pAccion, E_Producto objeE_Producto)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("abcProducto", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", pAccion);
            cmd.Parameters.AddWithValue("@IdProducto", objeE_Producto.Id_Producto);
            cmd.Parameters.AddWithValue("@CantidadProducto", objeE_Producto.CantidadProducto);
            cmd.Parameters.AddWithValue("@NombreProducto", objeE_Producto.NombreProducto);
            cmd.Parameters.AddWithValue("@DescripcionProducto", objeE_Producto.DescripcionProducto);
            cmd.Parameters.AddWithValue("@Precio", objeE_Producto.Precio);

            try
            {
                AbrirConexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al manipular datos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return Resultado;
        }


        public DataSet ListadoProductos()
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListadoProductos";

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {

                throw new Exception("Datos Productos", e);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }
            return ds;
        }

        public DataSet SeleccionaProducto(int pIdProducto)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SeleccionaProducto";

                cmd.Parameters.AddWithValue("@IdProducto", pIdProducto);

                da.SelectCommand = cmd;
                da.Fill(ds);

            }
            catch (Exception ex)
            {

                throw new Exception("Datos Producto seleccion", ex);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }

            return ds;
        }


        public DataSet BuscarProducto(string NombreProducto)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarProducto";

                cmd.Parameters.AddWithValue("@NombreProducto", NombreProducto);

                da.SelectCommand = cmd;
                da.Fill(ds);

            }
            catch (Exception ex)
            {

                throw new Exception("Datos Producto seleccion", ex);
            }
            finally
            {
                Conexion.Close();
                cmd.Dispose();
            }

            return ds;
        }


    }
}
