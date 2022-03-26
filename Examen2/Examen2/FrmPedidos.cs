using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion.Acceso;
using Conexion.Entidades;

namespace Examen2
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }
         PedidosDA pedidosDA = new PedidosDA();
        Pedidos pedidos = new Pedidos();


        private void ListarPedidos()
        {
            PedidosDataGridView.DataSource = pedidosDA.ListarPedidos();
        }

       
        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            ListarPedidos();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(IdFacturaTextBox.Text))
            {
                MessageBox.Show(IdFacturaTextBox, "Ingrese el IdFactura");
                IdFacturaTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {

                MessageBox.Show(NombreTextBox, "Ingrese el Nombre del cliente");
                NombreTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(CodigoProductoTextBox.Text))
            {
                MessageBox.Show(CodigoProductoTextBox, "Ingrese el codigo del producto");
                CodigoProductoTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(CantidadTextBox.Text))
            {
                MessageBox.Show(CantidadTextBox, "Ingrese la cantidad del producto");
                CantidadTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(PrecioTextBox.Text))
            {
                MessageBox.Show(PrecioTextBox, "Ingrese el precio del producto");
                PrecioTextBox.Focus();
                return;
            }

            pedidos.IdFactura = Convert.ToInt32(IdFacturaTextBox.Text);
            pedidos.Nombre = NombreTextBox.Text;
            pedidos.Codigo = CodigoProductoTextBox.Text;
            pedidos.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            pedidos.Precio = Convert.ToDecimal(PrecioTextBox.Text);


            bool inserto = pedidosDA.InsertarPedidos(pedidos);
            if (inserto)
            {
                MessageBox.Show("Pedido creado");
                ListarPedidos();
            }
            else
            {
                MessageBox.Show("El pedido no se pudo Crear");
            }


        }

       
    }
}
