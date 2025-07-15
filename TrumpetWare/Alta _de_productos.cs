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
using static System.Net.Mime.MediaTypeNames;

namespace TrumpetWare
{
    public partial class Alta_de_productos : Form
    {
        public Alta_de_productos()
        {
            InitializeComponent();
        }

        private void Alta_de_productos_Load(object sender, EventArgs e)
        {
        }  

        private void btnsalir_Click(object sender, EventArgs e)
        {
           this.Dispose();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPPublico.Text = "";
            txtPEmbajador.Text = "";
            txtCostoProduccion.Text = "";
            txtClave.Focus();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
           string connectionString = "Server=SEUGMIN-STAAA;Database=TrumpetWare;User Id=sa;Password=Seugmin;";
            using (SqlConnection con= new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Marketing.producto (Clave, Nombre, Descripcion, Precio_Publico, Precio_Embajador, Costo_Produccion) VALUES (" + txtClave.Text + ",'" + txtNombre.Text + "','" + txtDescripcion.Text + "'," + txtPPublico.Text + "," + txtPEmbajador.Text + "," + txtCostoProduccion.Text + ")", con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                cmd.ExecuteNonQuery();
            }
            
        }
    }
}
