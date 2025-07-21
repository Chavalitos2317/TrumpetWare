namespace TrumpetWare
{
    partial class Catalogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogos));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuTrumpet = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEmbajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepaToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTrumpet,
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(687, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuCatalogos";
            // 
            // MenuTrumpet
            // 
            this.MenuTrumpet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaEmbajadoresToolStripMenuItem,
            this.sepaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MenuTrumpet.Name = "MenuTrumpet";
            this.MenuTrumpet.Size = new System.Drawing.Size(87, 20);
            this.MenuTrumpet.Text = "&Embajadores";
            // 
            // listaEmbajadoresToolStripMenuItem
            // 
            this.listaEmbajadoresToolStripMenuItem.Name = "listaEmbajadoresToolStripMenuItem";
            this.listaEmbajadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaEmbajadoresToolStripMenuItem.Text = "Lista Embajadores";
            this.listaEmbajadoresToolStripMenuItem.Click += new System.EventHandler(this.listaEmbajadores_Click);
            // 
            // sepaToolStripMenuItem
            // 
            this.sepaToolStripMenuItem.Name = "sepaToolStripMenuItem";
            this.sepaToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "&Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productos_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.listaClientes_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de..";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercade_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrumpetWare.Properties.Resources.trummpettt;
            this.pictureBox1.Location = new System.Drawing.Point(1, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 387);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Catalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 414);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Catalogos";
            this.Text = "Catalogos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Catalogos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCatalogos_FormClosed);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       new private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuTrumpet;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator sepaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEmbajadoresToolStripMenuItem;
    }
}