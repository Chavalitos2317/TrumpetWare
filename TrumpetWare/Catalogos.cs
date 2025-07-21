using Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrumpetWare
{
    public partial class Catalogos : Form
    {
        public Catalogos()
        {
            InitializeComponent();
        }
        private void Catalogos_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Preguntar si desea salir
            DialogResult salir = MessageBox.Show("¿Deseas salir de la aplicación?",
                "TrumpetWare", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (salir == DialogResult.No)
                e.Cancel = true;

        }
        private void FrmCatalogos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Termina toda la aplicación
        }
        private void mnuCatSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercade_Click(object sender, EventArgs e)
        {
            // Mostrar la información del sistema
            String mensaje = "Aplicación TrumpetWare\n" +
                            "Autor: TBD Verano\n" +
                            "Socio inversionista: Víctor Manuel Bátiz";
            MessageBox.Show(mensaje, "TrumpetWare");
        }

        private void productos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
        }

        private void listaEmbajadores_Click(object sender, EventArgs e)
        {
            Embajadores embajadores = new Embajadores();
            embajadores.Show();
        }

        private void listaClientes_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }
    }
}
