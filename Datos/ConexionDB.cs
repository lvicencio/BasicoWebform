using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace Datos
{
    public class ConexionDB
    {
        public SqlConnection Conexion;
        public ConexionDB()
        {
            Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }

        public void AbrirConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Broken || Conexion.State == ConnectionState.Closed)
                {
                    Conexion.Open();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al abrir conexion", e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al cerrar la conexion", e);
            }
        }
    }
}
