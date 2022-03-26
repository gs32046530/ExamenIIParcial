using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2 
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void toolStripTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripEx3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        FrmProducto frmProducto = null;
        FrmProducto frmPedidos = null;


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.Show();

        }
    }
}
