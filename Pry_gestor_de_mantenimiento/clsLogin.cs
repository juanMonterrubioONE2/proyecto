using System;
using MySqlConnector;
using System.Windows.Forms;
namespace Pry_gestor_de_mantenimiento
{
    internal class clsLogin
    {
        private string usuario;
        private string password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public static string rol;
        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {

                    string sql = "select vchrol from tblusuarios,tblroles where vchcorreo=@correo and vchpassword=MD5(@password) AND tblusuarios.intidrol=tblroles.intidrol;";
                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@correo", usuario);
                        consulta.Parameters.AddWithValue("@password", password);
                        //si existe el usuario obtenemos el rol
                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                rol = resultado.GetString("vchrol");
                                MessageBox.Show("Tu perfil es: " + rol);
                                return true;
                            }
                            else
                            {
                                throw new Exception("Error en credenciales");
                            }

                        }//liberar la lectura de registros
                    }//liberar consulta a los usuarios
                }//liberar conexion 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
