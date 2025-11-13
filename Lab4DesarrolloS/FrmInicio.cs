using Lab4DesarrolloS.Admistrador;
using Lab4DesarrolloS.Clientes;
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

namespace Lab4DesarrolloS
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string contrasena = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor ingresa usuario y contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (ConexionBD conexion = new ConexionBD())
            {
                try
                {
                    conexion.conectar();

                    string query = "SELECT tipo_usuario FROM usuarios WHERE nombre_usuario = @nombre AND contrasena = @contra;";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion.getMiConexion()))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@contra", contrasena);

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null)
                        {
                            string tipo = resultado.ToString();

                            MessageBox.Show("Inicio de sesión exitoso", "Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (tipo == "admin")
                            {
                                FrmPrincipalAdm adminForm = new FrmPrincipalAdm();
                                adminForm.Show();
                            }
                            else if (tipo == "cliente")
                            {
                                FrmPrinciplaCln clienteForm = new FrmPrinciplaCln();
                                clienteForm.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
