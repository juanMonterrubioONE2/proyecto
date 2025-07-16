using System;
using MySqlConnector;
namespace Pry_gestor_de_mantenimiento
{
    internal class clsConexion
    {
        private readonly string cadenaConexion = "server=localhost;database=bd_gestor_mantenimiento;user=root;password=";

        public MySqlConnection AbrirConexion()
        {
            var conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos:" + ex.Message, ex);

            }
        }
    }
}
