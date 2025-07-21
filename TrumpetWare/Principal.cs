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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.txtPassword.PasswordChar = '*';

        }
 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text;

            if (usuario == "admin" && password == "123")
            {
                this.Hide(); // Oculta el login
                Catalogos catalogos = new Catalogos(); // Crea el nuevo formulario
                catalogos.Show(); // Abre formulario de catálogos
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
