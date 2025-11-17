using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo4;
using Npgsql;

namespace Lab4DesarrolloS
{
    internal class Operaciones
    {
        private ConexionBD bd = new ConexionBD();

        public bool modificarMed(int id, string name, byte[] foto, float cant, float pre)
        {
            try
            {
                bd.conectar();
                if (bd.getMiConexion().State == ConnectionState.Open)
                {
                    string sql = "UPDATE medicamentos SET nombre=@nombre, imagen=@imagen, cantidad=@cantidad, precio=@precio WHERE id=@id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, bd.getMiConexion()))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nombre", name);
                        cmd.Parameters.AddWithValue("@imagen", foto);
                        cmd.Parameters.AddWithValue("@cantidad", cant);
                        cmd.Parameters.AddWithValue("@precio", pre);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
            bd.cerrarConexion();

            return false;
        }
        public bool EliminarMed(int id)
        {
            try
            {
                bd.conectar();
                if (bd.getMiConexion().State == ConnectionState.Open)
                {
                    string sql = "DELETE FROM medicamentos WHERE id = @codigo";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, bd.getMiConexion()))
                    {
                        cmd.Parameters.AddWithValue("@codigo", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            bd.cerrarConexion();
            return false;
        }
        public byte[] CargarImagen(int id)
        {
            byte[] imagen = null;

            try
            {
                bd.conectar();

                string sql = "SELECT imagen FROM medicamentos WHERE id = @id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, bd.getMiConexion()))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != DBNull.Value && resultado != null)
                    {
                        string hex = resultado.ToString();      // 🔥 viene como HEX string desde PostgreSQL
                        imagen = HexStringToBytes(hex);         // 🔥 convertir a byte[]
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar imagen: " + ex.Message);
            }
            finally
            {
                bd.cerrarConexion();
            }

            return imagen;
        }
        private byte[] HexStringToBytes(string hex)
        {
            // PostgreSQL bytea -> "\xFFD8FFE0...."
            if (hex.StartsWith("\\x"))
                hex = hex.Substring(2);

            int length = hex.Length;
            byte[] bytes = new byte[length / 2];

            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }

            return bytes;
        }
    }
}
