using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion.Entidades
{
    public class Pedidos
    {
        public int IdFactura { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }

        public Pedidos()
        {
        }

        public Pedidos(int idFactura, string nombre, string codigo, int cantidad, decimal precio, string descripcion)
        {
            IdFactura = idFactura;
            Nombre = nombre;
            Codigo = codigo;
            Cantidad = cantidad;
            Precio = precio;
            Descripcion = descripcion;
        }
    }
}
