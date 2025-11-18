using Modulo4;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab4DesarrolloS.Clientes
{
    public partial class frmComprar : Form
    {
        public frmComprar()
        {
            InitializeComponent();
            CargarProductos(); // Cargar automáticamente al abrir
        }
        // carritooo 
        //
        List<CarritoItem> carrito = new List<CarritoItem>();

        public class CarritoItem
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; } = 1;
        }

        // ============================================================
        //   FUNCIÓN PARA CREAR UNA TARJETA TIPO TIENDA
        // ============================================================
        private void AgregarProducto(string nombre, decimal precio, int stock, Image imagen)
        {
            Panel card = new Panel();
            card.Width = 180;
            card.Height = 260;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(10);
            card.BackColor = Color.White;

            // IMAGEN DEL PRODUCTO
            PictureBox pic = new PictureBox();
            pic.Width = 160;
            pic.Height = 120;
            pic.Image = imagen;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Top = 10;
            pic.Left = 10;

            // NOMBRE
            Label lblNombre = new Label();
            lblNombre.Text = nombre;
            lblNombre.Width = 160;
            lblNombre.Top = 140;
            lblNombre.Left = 10;
            lblNombre.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // PRECIO
            Label lblPrecio = new Label();
            lblPrecio.Text = precio.ToString("C2");
            lblPrecio.Width = 160;
            lblPrecio.Top = 170;
            lblPrecio.Left = 10;
            lblPrecio.ForeColor = Color.Green;
            lblPrecio.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // STOCK
            Label lblStock = new Label();
            lblStock.Text = "Stock: " + stock;
            lblStock.Width = 160;
            lblStock.Top = 190;
            lblStock.Left = 10;
            lblStock.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblStock.ForeColor = Color.Black;

            // BOTÓN AGREGAR
            Button btnAdd = new Button();
            btnAdd.Text = "Añadir al carrito";
            btnAdd.Width = 150;
            btnAdd.Top = 220;
            btnAdd.Left = 10;

            card.Controls.Add(pic);
            card.Controls.Add(lblNombre);
            card.Controls.Add(lblPrecio);
            card.Controls.Add(lblStock);
            card.Controls.Add(btnAdd);

            flp_Articulos.Controls.Add(card);
        }


        // ============================================================
        //     CARGAR PRODUCTOS DESDE POSTGRESQL
        // ============================================================
        private void CargarProductos()
        {
            using (ConexionBD bd = new ConexionBD())
            {
                try
                {
                    bd.conectar();
                    string query = "SELECT nombre, precio, cantidad, imagen FROM medicamentos";


                    using (NpgsqlCommand cmd =
                           new NpgsqlCommand(query, bd.getMiConexion()))
                    using (NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string nombre = dr["nombre"].ToString();
                            decimal precio = Convert.ToDecimal(dr["precio"]);
                            int stock = Convert.ToInt32(dr["cantidad"]);


                            //-------------------------------------------------------------
                            // Cargar imagen correctamente sin importar si es bytea/string/null
                            //-------------------------------------------------------------
                            Image img = null;
                            var valor = dr["imagen"];

                            if (valor == DBNull.Value)
                            {
                                img = Properties.Resources.no_image;
                            }
                            else if (valor is byte[] bytes)
                            {
                                // Imagen almacenada como BYTEA
                                using (MemoryStream ms = new MemoryStream(bytes))
                                {
                                    img = Image.FromStream(ms);
                                }
                            }
                            else if (valor is string ruta && File.Exists(ruta))
                            {
                                // Imagen almacenada como ruta de archivo (por si acaso)
                                img = Image.FromFile(ruta);
                            }
                            else
                            {
                                // Cualquier caso extraño → usar default
                                img = Properties.Resources.no_image;
                            }


                            AgregarProducto(nombre, precio, stock, img);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error cargando productos: " + ex.Message);
                }
            }
        }
    }
}

