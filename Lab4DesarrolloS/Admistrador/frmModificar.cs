using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo4;
using Npgsql;

namespace Lab4DesarrolloS.Admistrador
{
    public partial class frmModificar : Form
    {
        Operaciones op = new Operaciones();
        int id = 0;
        public frmModificar()
        {
            InitializeComponent();
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvEliminacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvModificacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvModificacion.Rows[e.RowIndex];

                id = Convert.ToInt32(fila.Cells["id"].Value);
                txtName.Text = fila.Cells["nombre"].Value.ToString();
                txtCant.Text = fila.Cells["cantidad"].Value.ToString();
                txtP.Text = fila.Cells["precio"].Value.ToString();
                byte[] img = op.CargarImagen(id);

                if (img != null)
                {
                    using (MemoryStream ms = new MemoryStream(img))
                    {
                        picMedi.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picMedi.Image = null;
                }
            }
        }

        private void btnMuestra_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (ConexionBD bd = new ConexionBD())
            {
                try
                {
                    bd.conectar();
                    string query = "SELECT * FROM medicamentos";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, bd.getMiConexion()))
                    {
                        using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd))
                        {
                            dataAdapter.Fill(dt);
                            dgvModificacion.DataSource = dt;

                           
                            dgvModificacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        }
                    }

                    if (dt.Columns.Contains("imagen"))
                    {
                        foreach (DataGridViewRow row in dgvModificacion.Rows)
                        {
                            if (row.Cells["imagen"].Value != null && row.Cells["imagen"].Value != DBNull.Value)
                            {
                                string hex = row.Cells["imagen"].Value.ToString();

                                if (hex.Length > 20)
                                {
                                    row.Cells["imagen"].Value = hex.Substring(0, 20) + "...";
                                }
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            string name; float cant, pre;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            picMedi.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            name = txtName.Text;
            cant = float.Parse(txtCant.Text);
            pre = float.Parse(txtP.Text);
           if(op.modificarMed(id,name,ms.GetBuffer(), cant, pre))
            {
                MessageBox.Show("Medicamento actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar el medicamento");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult rs = op.ShowDialog();
            if (rs == DialogResult.OK) { 
            picMedi.Image = Image.FromFile(op.FileName);
            }
        }
    }
}
