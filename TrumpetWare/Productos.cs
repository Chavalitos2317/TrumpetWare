using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrumpetWare.Properties;

namespace Libreria
{
    enum Estado { Agregar, Modificar, Consultar }
    public partial class Productos : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        CurrencyManager manejador;
        int posicionManejador = 0;
        Estado miEstado;
        public Productos()
        {
            InitializeComponent();
        }

        private void AltaProducto(int clave, string nombre, string descripcion, double precioPublico, double precioEmbajador, double costoProduccion)
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("Sp_AltaProducto", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@clave", clave);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@precio_publico", precioPublico);
                cmd.Parameters.AddWithValue("@precio_embajador", precioEmbajador);
                cmd.Parameters.AddWithValue("@costo_produccion", costoProduccion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void ModificarProducto(int clave, string nombre, string descripcion, double precioPublico, double precioEmbajador, double costoProduccion)
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("Sp_CambioProducto", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@clave", clave);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@precio_publico", precioPublico);
                cmd.Parameters.AddWithValue("@precio_embajador", precioEmbajador);
                cmd.Parameters.AddWithValue("@costo_produccion", costoProduccion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private DataTable ConsultarProducto(int? clave = null)
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;
            DataTable tabla = new DataTable();

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("Sp_ConsultarProducto", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clave", (object)clave ?? DBNull.Value);

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(tabla);
            }

            return tabla;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar formulario
            this.Close();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            dt = ConsultarProducto(); // Usamos el SP en lugar del DataAdapter

            // Enlazamos los controles igual
            txtClave.DataBindings.Add("Text", dt, "clave");
            txtNombre.DataBindings.Add("Text", dt, "nombre");
            txtDescripcion.DataBindings.Add("Text", dt, "descripcion");
            txtPrecioPublico.DataBindings.Add("Text", dt, "precio_publico");
            txtPrecioEmbajador.DataBindings.Add("Text", dt, "precio_embajador");
            txtCostoProduccion.DataBindings.Add("Text", dt, "costo_produccion");

            manejador = (CurrencyManager)this.BindingContext[dt];
            txtTotalRegistros.Text = manejador.Count.ToString();

            establecerEstado(Estado.Consultar);
        }
        private void establecerEstado(Estado cual)
        {
            miEstado = cual;

            // Habilitar o Deshabilitar los componentes dependiendo del estado
            switch (miEstado)
            {
                case Estado.Consultar:
                    panelNavegacion.Enabled = true;
                    panelGeneral.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = true;
                    btnGuardar.Enabled = false;
           
                    btnSalir.Enabled = true;
                    break;

                default:
                    panelNavegacion.Enabled = false;
                    panelGeneral.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = true;
                 
                    btnSalir.Enabled = false;
                    break;
            }

        }
       
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            manejador.Position = 0;
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (manejador.Position != 0)
                manejador.Position--;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (manejador.Position != manejador.Count - 1)
                manejador.Position++;
        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            manejador.Position = manejador.Count - 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            establecerEstado(Estado.Modificar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            manejador.CancelCurrentEdit();

            if (miEstado == Estado.Agregar)
            {
                manejador.Position = posicionManejador;
            }

            establecerEstado(Estado.Consultar);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            posicionManejador = manejador.Position;
            establecerEstado(Estado.Agregar);
            manejador.AddNew();
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            // Cambiar el registro actual, según el valor proporcionado
            if (e.KeyCode == Keys.Enter)
            {
                int nuevaPosicion = Convert.ToInt32(txtClave.Text);
                posicionManejador = manejador.Position;
                manejador.CancelCurrentEdit();

                // Validar que el nuevo número se encuentre
                // en el rango de filas existentes
                if ((nuevaPosicion >= 1) && (nuevaPosicion <= manejador.Count))
                    manejador.Position = nuevaPosicion - 1;
                else
                    manejador.Position = posicionManejador;

                txtClave.Text = (manejador.Position + 1).ToString();
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            manejador.CancelCurrentEdit();
            txtClave.Text = (manejador.Position + 1).ToString();
        }
        private void BajaProducto(int clave)
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("Sp_BajaProducto", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clave", clave);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas eliminar el producto?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int clave = Convert.ToInt32(txtClave.Text);
                BajaProducto(clave);

                dt = ConsultarProducto();
                manejador = (CurrencyManager)this.BindingContext[dt];
                txtTotalRegistros.Text = manejador.Count.ToString();

                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtDescripcion.Text == "" ||
                    txtPrecioPublico.Text == "" || txtPrecioEmbajador.Text == "" || txtCostoProduccion.Text == "")
                {
                    MessageBox.Show("Completa todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                double precioPublico = Convert.ToDouble(txtPrecioPublico.Text);
                double precioEmbajador = Convert.ToDouble(txtPrecioEmbajador.Text);
                double costo = Convert.ToDouble(txtCostoProduccion.Text);

                if (miEstado == Estado.Agregar)
                {
                    int nuevaClave = ObtenerSiguienteClaveDisponible();
                    txtClave.Text = nuevaClave.ToString();

                    AltaProducto(nuevaClave, nombre, descripcion, precioPublico, precioEmbajador, costo);
                }
                else if (miEstado == Estado.Modificar)
                {
                    int clave = Convert.ToInt32(txtClave.Text);
                    ModificarProducto(clave, nombre, descripcion, precioPublico, precioEmbajador, costo);
                }

                dt = ConsultarProducto();
                manejador = (CurrencyManager)this.BindingContext[dt];
                txtTotalRegistros.Text = manejador.Count.ToString();

                establecerEstado(Estado.Consultar);
                MessageBox.Show("Guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Ya existe un producto con esta clave.", "Clave duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (ex.Message.Contains("precio"))
                    MessageBox.Show("Verifica que los precios sean mayores a cero y consistentes.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Error de base de datos: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int ObtenerSiguienteClaveDisponible()
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(clave), 0) + 1 FROM Marketing.Producto", conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }


    }
}

