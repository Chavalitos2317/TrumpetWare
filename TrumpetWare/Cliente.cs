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

namespace TrumpetWare
{
    public partial class Cliente : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        CurrencyManager manejador;
        int posicionManejador = 0;
        Estado miEstado;
        public Cliente()
        {
            InitializeComponent();
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

        private DataTable ConsultarClientes()
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;
            DataTable tabla = new DataTable();

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("Sp_ConsultarClientes", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(tabla);
            }

            return tabla;
        }
        private void AltaCliente(int id, string nombre, string telefono, string direccion)
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("Sp_AltaCliente", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion_geolocalizada", direccion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void ModificarCliente(int id, string nombre, string telefono, string direccion)
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("Sp_CambioCliente", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion_geolocalizada", direccion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void BajaCliente(int id)
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("Sp_BajaCliente", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private int ObtenerSiguienteIdCliente()
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(id_cliente), 0) + 1 FROM Comercial.Cliente", conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }



        private void Cliente_Load(object sender, EventArgs e)
        {
            dt = ConsultarClientes();

            txtClave.DataBindings.Add("Text", dt, "id_cliente");
            txtNombre.DataBindings.Add("Text", dt, "nombre");
            txtTelefono.DataBindings.Add("Text", dt, "telefono");
            txtDireccion.DataBindings.Add("Text", dt, "direccion_geolocalizada");

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
                    btnCancelar.Enabled = false;
                    btnSalir.Enabled = true;
                    break;

                default:
                    panelNavegacion.Enabled = false;
                    panelGeneral.Enabled = true;
                    btnNuevo.Enabled = false;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtTelefono.Text == "" || txtDireccion.Text == "")
                {
                    MessageBox.Show("Completa todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = txtNombre.Text;
                string telefono = txtTelefono.Text;
                string direccion = txtDireccion.Text;

                if (miEstado == Estado.Agregar)
                {
                    int nuevoId = ObtenerSiguienteIdCliente();
                    txtClave.Text = nuevoId.ToString();
                    AltaCliente(nuevoId, nombre, telefono, direccion);
                }
                else if (miEstado == Estado.Modificar)
                {
                    int id = Convert.ToInt32(txtClave.Text);
                    ModificarCliente(id, nombre, telefono, direccion);
                }

                dt = ConsultarClientes();
                manejador = (CurrencyManager)this.BindingContext[dt];
                txtTotalRegistros.Text = manejador.Count.ToString();

                establecerEstado(Estado.Consultar);
                MessageBox.Show("Guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Ya existe un cliente con ese ID.", "Clave duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (ex.Message.Contains("telefono"))
                    MessageBox.Show("El teléfono debe tener al menos 8 caracteres.", "Teléfono inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Error en base de datos: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            posicionManejador = manejador.Position;
            establecerEstado(Estado.Agregar);
            manejador.AddNew();

            int siguiente = ObtenerSiguienteIdCliente();
            txtClave.Text = siguiente.ToString();
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtClave.Text);
                BajaCliente(id);

                dt = ConsultarClientes();
                manejador = (CurrencyManager)this.BindingContext[dt];
                txtTotalRegistros.Text = manejador.Count.ToString();

                MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panelGeneral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
