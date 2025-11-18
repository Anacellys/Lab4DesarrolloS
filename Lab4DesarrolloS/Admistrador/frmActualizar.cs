using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo4;
using Npgsql;

namespace Lab4DesarrolloS.Admistrador
{
    public partial class frmActualizar : Form
    {
        ConexionBD bd = new ConexionBD();
        Operaciones op = new Operaciones();
        int id = 0;
        public frmActualizar()
        {
            InitializeComponent();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            try
            {
                bd.conectar();

                if (bd.getMiConexion().State == ConnectionState.Open)
                {
                    string query = "select id,nombre,cantidad from medicamentos;";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, bd.getMiConexion()))
                    {
                        NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd);
                        dataAdapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dgvVisualizacion.DataSource = dt;
                            dgvVisualizacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron resultados");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al consultar la base de datos \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado\n" + ex.Message);
            }
        }

        private void dgvVisualizacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow fila = dgvVisualizacion.Rows[e.RowIndex];
                id = Convert.ToInt32(fila.Cells["id"].Value);
                txtName.Text = fila.Cells["nombre"].Value.ToString();
                txtCant.Text = fila.Cells["cantidad"].Value.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            float cant;
            cant = float.Parse(txtCant.Text);
            if (op.ActualizarCant(id, cant))
            {
                MessageBox.Show("Cantidad Actualizada Correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar la cantidad");
            }
        }
    }
}
