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
    public partial class frmVer : Form
    {
        public frmVer()
        {
            InitializeComponent();
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
                            dgvVisualizacion.DataSource = dt;


                            dgvVisualizacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        }
                    }

                    if (dt.Columns.Contains("imagen"))
                    {
                        foreach (DataGridViewRow row in dgvVisualizacion.Rows)
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

        private void dgvEliminacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
