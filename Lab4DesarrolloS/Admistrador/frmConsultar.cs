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

namespace Lab4DesarrolloS.Admistrador
{
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
            this.Load += FrmConsultar_Load;
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (ConexionBD bd = new ConexionBD())
                {
                    bd.conectar();

                    string sql = @"
                SELECT 
                    u.nombre_usuario AS cliente,
                    m.nombre AS medicamento,
                    dp.cantidad,
                    dp.subtotal,
                    p.total AS total_pedido,
                    p.fecha
                FROM pedidos p
                JOIN usuarios u ON u.id = p.id_cliente
                JOIN detalle_pedido dp ON dp.id_pedido = p.id
                JOIN medicamentos m ON m.id = dp.id_medicamento
                ORDER BY p.fecha DESC;
            ";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, bd.getMiConexion()))
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }

                    bd.cerrarConexion();
                }

                dgvProduct.DataSource = tabla;
                dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar pedidos: " + ex.Message);
            }
        }
    }
}
