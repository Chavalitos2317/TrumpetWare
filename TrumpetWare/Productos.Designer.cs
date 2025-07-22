namespace Libreria
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBotones = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panelNavegacion = new System.Windows.Forms.Panel();
            this.txtTotalRegistros = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.txtCostoProduccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioEmbajador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecioPublico = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelBotones.SuspendLayout();
            this.panelNavegacion.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.button1);
            this.panelBotones.Controls.Add(this.btnSalir);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnModificar);
            this.panelBotones.Controls.Add(this.btnNuevo);
            this.panelBotones.Location = new System.Drawing.Point(0, 250);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(891, 85);
            this.panelBotones.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(548, 30);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(368, 30);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(192, 30);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(16, 30);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 28);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.Controls.Add(this.txtTotalRegistros);
            this.panelNavegacion.Controls.Add(this.txtClave);
            this.panelNavegacion.Controls.Add(this.lblDe);
            this.panelNavegacion.Controls.Add(this.lblClave);
            this.panelNavegacion.Controls.Add(this.btnImprimir);
            this.panelNavegacion.Controls.Add(this.btnUltimo);
            this.panelNavegacion.Controls.Add(this.btnSiguiente);
            this.panelNavegacion.Controls.Add(this.btnAnterior);
            this.panelNavegacion.Controls.Add(this.btnPrimero);
            this.panelNavegacion.Location = new System.Drawing.Point(0, 1);
            this.panelNavegacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(1069, 78);
            this.panelNavegacion.TabIndex = 0;
            // 
            // txtTotalRegistros
            // 
            this.txtTotalRegistros.Location = new System.Drawing.Point(529, 25);
            this.txtTotalRegistros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalRegistros.Name = "txtTotalRegistros";
            this.txtTotalRegistros.ReadOnly = true;
            this.txtTotalRegistros.Size = new System.Drawing.Size(132, 22);
            this.txtTotalRegistros.TabIndex = 5;
            this.txtTotalRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(352, 23);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(132, 22);
            this.txtClave.TabIndex = 3;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(495, 27);
            this.lblDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(23, 16);
            this.lblDe.TabIndex = 4;
            this.lblDe.Text = "de";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(267, 28);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(77, 16);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "ID Producto";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(891, 22);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 28);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(781, 22);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(100, 28);
            this.btnUltimo.TabIndex = 7;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(672, 22);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 28);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(142, 21);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 28);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(34, 21);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(100, 28);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.txtCostoProduccion);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.txtPrecioEmbajador);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Controls.Add(this.txtNombre);
            this.panelGeneral.Controls.Add(this.txtDescripcion);
            this.panelGeneral.Controls.Add(this.txtPrecioPublico);
            this.panelGeneral.Controls.Add(this.lblDireccion);
            this.panelGeneral.Controls.Add(this.lblCiudad);
            this.panelGeneral.Controls.Add(this.lblNombre);
            this.panelGeneral.Location = new System.Drawing.Point(0, 76);
            this.panelGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(908, 166);
            this.panelGeneral.TabIndex = 1;
            this.panelGeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGeneral_Paint);
            // 
            // txtCostoProduccion
            // 
            this.txtCostoProduccion.Location = new System.Drawing.Point(745, 123);
            this.txtCostoProduccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCostoProduccion.Name = "txtCostoProduccion";
            this.txtCostoProduccion.Size = new System.Drawing.Size(103, 22);
            this.txtCostoProduccion.TabIndex = 16;
            this.txtCostoProduccion.Text = "$0.00";
            this.txtCostoProduccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Costo Producción:";
            // 
            // txtPrecioEmbajador
            // 
            this.txtPrecioEmbajador.Location = new System.Drawing.Point(476, 123);
            this.txtPrecioEmbajador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioEmbajador.Name = "txtPrecioEmbajador";
            this.txtPrecioEmbajador.Size = new System.Drawing.Size(103, 22);
            this.txtPrecioEmbajador.TabIndex = 14;
            this.txtPrecioEmbajador.Text = "$0.00";
            this.txtPrecioEmbajador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Precio Embajador:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(203, 20);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(203, 60);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(301, 22);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtPrecioPublico
            // 
            this.txtPrecioPublico.Location = new System.Drawing.Point(203, 123);
            this.txtPrecioPublico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioPublico.Name = "txtPrecioPublico";
            this.txtPrecioPublico.Size = new System.Drawing.Size(103, 22);
            this.txtPrecioPublico.TabIndex = 10;
            this.txtPrecioPublico.Text = "$0.00";
            this.txtPrecioPublico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(71, 64);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(82, 16);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Descripción:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(71, 127);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(97, 16);
            this.lblCiudad.TabIndex = 9;
            this.lblCiudad.Text = "Precio Público:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(75, 23);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 345);
            this.ControlBox = false;
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelNavegacion);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Productos";
            this.Text = "Sección Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panelBotones.ResumeLayout(false);
            this.panelNavegacion.ResumeLayout(false);
            this.panelNavegacion.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panelNavegacion;
        private System.Windows.Forms.TextBox txtTotalRegistros;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecioPublico;
        private System.Windows.Forms.TextBox txtPrecioEmbajador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostoProduccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}