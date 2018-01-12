using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class D_Usuarios:ConexionDB
    {

        public D_Usuarios()
        { }

        public int IngresoUsuario(E_Usuario objeE_Usuario)
        {
            int Resultado = 0;
            SqlCommand cmd = new SqlCommand("Insertar_Usuario", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", objeE_Usuario.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", objeE_Usuario.Apellido);
            cmd.Parameters.AddWithValue("@UserName", objeE_Usuario.UserName);
            cmd.Parameters.AddWithValue("@Password", objeE_Usuario.Password);
            cmd.Parameters.AddWithValue("@id_rol", objeE_Usuario.id_rol);

            try
            {
                AbrirConexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al ingresar Usuario", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return Resultado;
        }



        public DataSet Login(string Username, string Password)
        {
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                AbrirConexion();
                cmd.Connection = Conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Login";

                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                da.SelectCommand = cmd;
                da.Fill(ds);

            }
            catch (Exception ex)
            {

                throw new Exception("Problemas con Login", ex);
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
