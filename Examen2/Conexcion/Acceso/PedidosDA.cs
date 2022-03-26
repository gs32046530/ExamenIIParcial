using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Conexion.Entidades;


namespace Conexion.Acceso
{
    public class PedidosDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2; Uid=root; Pwd=Elm@tatam123;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable ListarPedidos()
        {
            DataTable lista = new DataTable();

            try
            {
                string sql = "SELECT * FROM pedidos;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                lista.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return lista;
        }

        public bool InsertarPedidos(Pedidos pedidos)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO pedidos VALUES (@IdFactura, @Nombre, @Codigo, @Cantidad,@Precio,@Descripcion);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdFactura", pedidos.IdFactura);
                cmd.Parameters.AddWithValue("@Nombre", pedidos.Nombre);
                cmd.Parameters.AddWithValue("@Codigo", pedidos.Codigo);
                cmd.Parameters.AddWithValue("@Cantidad", pedidos.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", pedidos.Precio);
                cmd.Parameters.AddWithValue("@Descripcion", pedidos.Nombre);


                cmd.ExecuteNonQuery();
                inserto = true;

                conn.Close();
            }
            catch (Exception)
            {
            }
            return inserto;
        }
    }
}
