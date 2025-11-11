using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4DesarrolloS.Clientes
{
    public partial class FrmPrinciplaCln : Form
    {
        public FrmPrinciplaCln()
        {
            InitializeComponent();
        }

        private void disponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario frmDisponible = new frmInventario();
            frmDisponible.MdiParent = this;
            frmDisponible.Show();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComprar frmComprar = new frmComprar();
            frmComprar.MdiParent = this;
            frmComprar.Show();
        }
    }
}
