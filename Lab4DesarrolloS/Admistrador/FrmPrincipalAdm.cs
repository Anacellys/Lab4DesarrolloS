using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4DesarrolloS.Admistrador
{
    public partial class FrmPrincipalAdm : Form
    {
        public FrmPrincipalAdm()
        {
            InitializeComponent();
        }

        private void stadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizar frmActualizar = new frmActualizar();
            frmActualizar.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar();
            frmAgregar.MdiParent = this;
            frmAgregar.WindowState = FormWindowState.Maximized;
            frmAgregar.Show();
        }

        private void modificarOEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificar frmMod = new frmModificar();
            frmMod .MdiParent = this;
            frmMod.WindowState = FormWindowState.Maximized;
            frmMod .Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar frmEliminar = new frmEliminar();
            frmEliminar.MdiParent = this;
            frmEliminar.WindowState = FormWindowState.Maximized;
            frmEliminar.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmVer frmVer = new frmVer();
            frmVer.MdiParent = this;
            frmVer.WindowState = FormWindowState.Maximized;
            frmVer.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar frmConsultar = new frmConsultar();
            frmConsultar.MdiParent = this;
            frmConsultar.WindowState = FormWindowState.Maximized;
            frmConsultar.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar frm = new frmEliminar();
            frm.Show();
        }
    }
}
