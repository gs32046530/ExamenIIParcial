using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using Conexion.Entidades;
using Conexion.Acceso;

namespace Examen2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            ConexionBase usuarioDA = new ConexionBase();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuarioTextBox.Text, ClaveTextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("El usurio no existe");
                UsuarioTextBox.Clear();
                ClaveTextBox.Clear();
                UsuarioTextBox.Focus();

                return;
            }
  
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
        }
    }
}
