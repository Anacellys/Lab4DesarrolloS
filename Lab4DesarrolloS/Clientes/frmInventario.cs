using Modulo4;
using Npgsql;
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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (ConexionBD conexion = new ConexionBD())
            {
                try
                {
                    conexion.conectar();

                    string query = "SELECT id, nombre, imagen, cantidad, precio FROM medicamentos;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion.getMiConexion()))
                    {
                        NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(cmd);
                        adaptador.Fill(dt);
                    }

                    dgvProduct.DataSource = dt;
                    dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvProduct.AutoResizeColumns();

                    Size preferredSize = dgvProduct.GetPreferredSize(new Size(0, 0));
                    dgvProduct.Width = preferredSize.Width;
                    dgvProduct.Left = this.ClientSize.Width / 2 - dgvProduct.Width / 2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar medicamentos: " + ex.Message);
                }
            }
        }
    }
}
