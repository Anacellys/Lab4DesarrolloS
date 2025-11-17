using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo4;
using Npgsql;

namespace Lab4DesarrolloS.Admistrador
{
    public partial class frmEliminar : Form
    {
        Operaciones op = new Operaciones();
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmModificar frm = new frmModificar();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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
                            dgvEliminacion.DataSource = dt;


                            dgvEliminacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        }
                    }

                    if (dt.Columns.Contains("imagen"))
                    {
                        foreach (DataGridViewRow row in dgvEliminacion.Rows)
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

        private void dgvEliminacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                var result = MessageBox.Show("¿Desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvEliminacion.Rows[e.RowIndex].Cells[0].Value);

                    if (op.EliminarMed(id))
                    {
                        MessageBox.Show("Medicamento eliminado correctamente");
                        dgvEliminacion.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el medicamento");
                    }
                }
            }
        }

        private void dgvEliminacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
