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
    public partial class frmAgregar : Form
    {
        Operaciones op = new Operaciones();
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAgregar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string name; float cant, pre;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            picMedi.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            name = txtName.Text;
            cant = float.Parse(txtCant.Text);
            pre = float.Parse(txtP.Text);
            if (op.agregar(name, ms.GetBuffer(), cant, pre))
            {
                MessageBox.Show("Medicamento agregado correctamente");
            }
            else
            {
                MessageBox.Show("Error al agregar el medicamento");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult rs = op.ShowDialog();
            if (rs == DialogResult.OK)
            {
                picMedi.Image = Image.FromFile(op.FileName);
            }
        }
    }
}
