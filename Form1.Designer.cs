namespace Laboratorio2
{
    partial class Navegador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navegador));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Regresar = new System.Windows.Forms.ToolStripButton();
            this.Adelante = new System.Windows.Forms.ToolStripButton();
            this.Recargar = new System.Windows.Forms.ToolStripButton();
            this.Cerrar = new System.Windows.Forms.ToolStripButton();
            this.Buscador = new System.Windows.Forms.ToolStripComboBox();
            this.Buscar = new System.Windows.Forms.ToolStripButton();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.historial = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 32);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(747, 433);
            this.webBrowser1.TabIndex = 1;
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Regresar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Regresar.Image")));
            this.Regresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(29, 29);
            this.Regresar.Text = "Regresar";
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // Adelante
            // 
            this.Adelante.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Adelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Adelante.Image = ((System.Drawing.Image)(resources.GetObject("Adelante.Image")));
            this.Adelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Adelante.Name = "Adelante";
            this.Adelante.Size = new System.Drawing.Size(29, 29);
            this.Adelante.Text = "Adelante";
            this.Adelante.Click += new System.EventHandler(this.Adelante_Click);
            // 
            // Recargar
            // 
            this.Recargar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Recargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Recargar.Image = ((System.Drawing.Image)(resources.GetObject("Recargar.Image")));
            this.Recargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Recargar.Name = "Recargar";
            this.Recargar.Size = new System.Drawing.Size(29, 29);
            this.Recargar.Text = "Recargar";
            this.Recargar.Click += new System.EventHandler(this.Recargar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Cerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(29, 29);
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Buscador
            // 
            this.Buscador.BackColor = System.Drawing.SystemColors.Menu;
            this.Buscador.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Buscador.ForeColor = System.Drawing.SystemColors.Menu;
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(500, 32);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(29, 29);
            this.Buscar.Text = "Buscar";
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(29, 29);
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Regresar,
            this.Adelante,
            this.Recargar,
            this.Cerrar,
            this.Buscador,
            this.Buscar,
            this.Home,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(717, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 29);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // historial
            // 
            this.historial.Location = new System.Drawing.Point(639, 51);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(100, 96);
            this.historial.TabIndex = 2;
            this.historial.Text = "";
            // 
            // Navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 465);
            this.Controls.Add(this.historial);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Navegador";
            this.Text = "Navegador";
            this.Load += new System.EventHandler(this.Navegador_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton Regresar;
        private System.Windows.Forms.ToolStripButton Adelante;
        private System.Windows.Forms.ToolStripButton Recargar;
        private System.Windows.Forms.ToolStripButton Cerrar;
        private System.Windows.Forms.ToolStripComboBox Buscador;
        private System.Windows.Forms.ToolStripButton Buscar;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.RichTextBox historial;
    }
}

