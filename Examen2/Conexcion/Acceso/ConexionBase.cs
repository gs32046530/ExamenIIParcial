using MySql.Data.MySqlClient;
using Conexion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Conexion.Acceso 
{
    public class ConexionBase
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2; Uid=root; Pwd=Elm@tatam123;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuario Login(string codigo, string clave)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM usuario WHERE Codigo = @Codigo AND Clave = @Clave;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.Codigo = reader[0].ToString();
                    user.Clave = reader[1].ToString();

                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return user;
        }
    }
}