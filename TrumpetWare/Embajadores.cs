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
    enum Estado { Agregar, Modificar, Consultar }
    public partial class Embajadores : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        CurrencyManager manejador;
        int posicionManejador = 0;
        Estado miEstado;
        public Embajadores()
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

        private DataTable ConsultarEmbajadores()
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;
            DataTable tabla = new DataTable();

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("Sp_ConsultarEmbajadores", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(tabla);
            }

            return tabla;
        }

        private void AltaEmbajador(int id, string nombre, string nivel, double ventas, int idRegion)
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("Sp_AltaEmbajador", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_embajador", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@nivel", nivel);
                cmd.Parameters.AddWithValue("@ventas", ventas);
                cmd.Parameters.AddWithValue("@id_region", idRegion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        private void ModificarEmbajador(int id, string nombre, string nivel, double ventas, int idRegion)
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("Sp_CambioEmbajador", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_embajador", id);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@nivel", nivel);
                cmd.Parameters.AddWithValue("@ventas", ventas);
                cmd.Parameters.AddWithValue("@id_region", idRegion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void BajaEmbajador(int id)
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("Sp_BajaEmbajador", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_embajador", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private int ObtenerSiguienteIdEmbajador()
        {
            string conexionStr = TrumpetWare.Properties.Settings.Default.ConexionBD;

            using (SqlConnection conn = new SqlConnection(conexionStr))
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(id_embajador), 0) + 1 FROM Comercial.Embajador", conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }


        private void Embajadores_Load(object sender, EventArgs e)
        {
            dt = ConsultarEmbajadores();

            // Enlazar controles
            txtClave.DataBindings.Add("Text", dt, "id_embajador");
            txtNombre.DataBindings.Add("Text", dt, "nombre");
            txtNivel.DataBindings.Add("Text", dt, "nivel");
            txtVentas.DataBindings.Add("Text", dt, "ventas");
            txtIdRegion.DataBindings.Add("Text", dt, "id_region");

            // CurrencyManager
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
        // Métodos de eventos de conversion
        private void DecimalAString(object sender, ConvertEventArgs cEA)
        {

            // Verificar que el tipo deseado sea String
            if (cEA.DesiredType != typeof(String))
                return;

            // Utilizar el método Format de la clase String para dar formato de moneda
            cEA.Value = String.Format("{0:C}", (decimal)cEA.Value);
        }

        private void StringADecimal(object sender, ConvertEventArgs cEA)
        {
            

            // Verificar que el tipo deseado sea decimal
            if (cEA.DesiredType != typeof(decimal))
                return;

            // Utilizar el método Parse de la clase Decimal para quitar formato de moneda
            cEA.Value = Decimal.Parse(cEA.Value.ToString(), System.Globalization.NumberStyles.Currency);
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
                if (txtNombre.Text == "" || txtNivel.Text == "" || txtVentas.Text == "" || txtIdRegion.Text == "")
                {
                    MessageBox.Show("Completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nombre = txtNombre.Text;
                string nivel = txtNivel.Text;
                double ventas = Convert.ToDouble(txtVentas.Text);
                int idRegion = Convert.ToInt32(txtIdRegion.Text);

                if (miEstado == Estado.Agregar)
                {
                    int nuevoId = ObtenerSiguienteIdEmbajador();
                    txtClave.Text = nuevoId.ToString();
                    AltaEmbajador(nuevoId, nombre, nivel, ventas, idRegion);
                }
                else if (miEstado == Estado.Modificar)
                {
                    int id = Convert.ToInt32(txtClave.Text);
                    ModificarEmbajador(id, nombre, nivel, ventas, idRegion);
                }

                dt = ConsultarEmbajadores();
                manejador = (CurrencyManager)this.BindingContext[dt];
                txtTotalRegistros.Text = manejador.Count.ToString();

                establecerEstado(Estado.Consultar);
                MessageBox.Show("Guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("FK_Embajador"))
                {
                    MessageBox.Show("La región seleccionada no existe. Verifica el ID de región.", "Error de integridad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

            // Generar el siguiente ID embajador disponible
            int siguiente = ObtenerSiguienteIdEmbajador();
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
            if (MessageBox.Show("¿Estás seguro de eliminar este embajador?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(txtClave.Text);
                    BajaEmbajador(id);

                    dt = ConsultarEmbajadores();
                    manejador = (CurrencyManager)this.BindingContext[dt];
                    txtTotalRegistros.Text = manejador.Count.ToString();

                    MessageBox.Show("Embajador eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panelGeneral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
