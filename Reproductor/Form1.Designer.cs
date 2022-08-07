
namespace Reproductor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumeroVolumen = new System.Windows.Forms.Label();
            this.TiempoFinal = new System.Windows.Forms.Label();
            this.TiempoInicial = new System.Windows.Forms.Label();
            this.Volumen = new XComponent.SliderBar.MACTrackBar();
            this.Duracion = new XComponent.SliderBar.MACTrackBar();
            this.btnVolumen = new System.Windows.Forms.Button();
            this.Retornar = new System.Windows.Forms.Button();
            this.Iniciar = new System.Windows.Forms.Button();
            this.Adelantar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reproductorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1102, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reproductorToolStripMenuItem
            // 
            this.reproductorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iToolStripMenuItem,
            this.pausaToolStripMenuItem,
            this.detenerToolStripMenuItem});
            this.reproductorToolStripMenuItem.Name = "reproductorToolStripMenuItem";
            this.reproductorToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.reproductorToolStripMenuItem.Text = "Reproductor";
            // 
            // iToolStripMenuItem
            // 
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iToolStripMenuItem.Text = "Iniciar";
            // 
            // pausaToolStripMenuItem
            // 
            this.pausaToolStripMenuItem.Name = "pausaToolStripMenuItem";
            this.pausaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pausaToolStripMenuItem.Text = "Pausa ";
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detenerToolStripMenuItem.Text = "Detener";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.NumeroVolumen);
            this.panel1.Controls.Add(this.TiempoFinal);
            this.panel1.Controls.Add(this.TiempoInicial);
            this.panel1.Controls.Add(this.Volumen);
            this.panel1.Controls.Add(this.Duracion);
            this.panel1.Controls.Add(this.btnVolumen);
            this.panel1.Controls.Add(this.Retornar);
            this.panel1.Controls.Add(this.Iniciar);
            this.panel1.Controls.Add(this.Adelantar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 579);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 97);
            this.panel1.TabIndex = 1;
            // 
            // NumeroVolumen
            // 
            this.NumeroVolumen.AutoSize = true;
            this.NumeroVolumen.Location = new System.Drawing.Point(914, 53);
            this.NumeroVolumen.Name = "NumeroVolumen";
            this.NumeroVolumen.Size = new System.Drawing.Size(13, 13);
            this.NumeroVolumen.TabIndex = 10;
            this.NumeroVolumen.Text = "0";
            // 
            // TiempoFinal
            // 
            this.TiempoFinal.AutoSize = true;
            this.TiempoFinal.Location = new System.Drawing.Point(1062, 26);
            this.TiempoFinal.Name = "TiempoFinal";
            this.TiempoFinal.Size = new System.Drawing.Size(28, 13);
            this.TiempoFinal.TabIndex = 9;
            this.TiempoFinal.Text = "0:00";
            // 
            // TiempoInicial
            // 
            this.TiempoInicial.AutoSize = true;
            this.TiempoInicial.Location = new System.Drawing.Point(12, 26);
            this.TiempoInicial.Name = "TiempoInicial";
            this.TiempoInicial.Size = new System.Drawing.Size(28, 13);
            this.TiempoInicial.TabIndex = 8;
            this.TiempoInicial.Text = "0:00";
            // 
            // Volumen
            // 
            this.Volumen.BackColor = System.Drawing.Color.Transparent;
            this.Volumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Volumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.Volumen.IndentHeight = 6;
            this.Volumen.Location = new System.Drawing.Point(927, 45);
            this.Volumen.Maximum = 100;
            this.Volumen.Minimum = 0;
            this.Volumen.Name = "Volumen";
            this.Volumen.Size = new System.Drawing.Size(103, 28);
            this.Volumen.TabIndex = 7;
            this.Volumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.Volumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.Volumen.TickHeight = 1;
            this.Volumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Volumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.Volumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.Volumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Volumen.TrackLineHeight = 3;
            this.Volumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Volumen.Value = 0;
            this.Volumen.Visible = false;
            this.Volumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.Volumen_ValueChanged);
            this.Volumen.MouseLeave += new System.EventHandler(this.Volumen_MouseLeave);
            // 
            // Duracion
            // 
            this.Duracion.BackColor = System.Drawing.Color.Transparent;
            this.Duracion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.Duracion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.Duracion.IndentHeight = 6;
            this.Duracion.Location = new System.Drawing.Point(0, 0);
            this.Duracion.Maximum = 100;
            this.Duracion.Minimum = 0;
            this.Duracion.Name = "Duracion";
            this.Duracion.Size = new System.Drawing.Size(1102, 28);
            this.Duracion.TabIndex = 6;
            this.Duracion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.Duracion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.Duracion.TickHeight = 1;
            this.Duracion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Duracion.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.Duracion.TrackerSize = new System.Drawing.Size(16, 16);
            this.Duracion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Duracion.TrackLineHeight = 3;
            this.Duracion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.Duracion.Value = 0;
            this.Duracion.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.Duracion_ValueChanged);
            // 
            // btnVolumen
            // 
            this.btnVolumen.BackgroundImage = global::Reproductor.Properties.Resources.ajuste_de_volumen;
            this.btnVolumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolumen.FlatAppearance.BorderSize = 0;
            this.btnVolumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumen.Location = new System.Drawing.Point(868, 42);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(43, 35);
            this.btnVolumen.TabIndex = 5;
            this.btnVolumen.UseVisualStyleBackColor = true;
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click);
            // 
            // Retornar
            // 
            this.Retornar.BackgroundImage = global::Reproductor.Properties.Resources.hacia_atras;
            this.Retornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Retornar.FlatAppearance.BorderSize = 0;
            this.Retornar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retornar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Retornar.Location = new System.Drawing.Point(456, 31);
            this.Retornar.Name = "Retornar";
            this.Retornar.Size = new System.Drawing.Size(59, 49);
            this.Retornar.TabIndex = 4;
            this.Retornar.UseVisualStyleBackColor = true;
            this.Retornar.Click += new System.EventHandler(this.Retornar_Click);
            // 
            // Iniciar
            // 
            this.Iniciar.BackColor = System.Drawing.SystemColors.Control;
            this.Iniciar.BackgroundImage = global::Reproductor.Properties.Resources.tocar;
            this.Iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Iniciar.FlatAppearance.BorderSize = 0;
            this.Iniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Iniciar.ForeColor = System.Drawing.Color.Black;
            this.Iniciar.Location = new System.Drawing.Point(521, 26);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(65, 59);
            this.Iniciar.TabIndex = 3;
            this.Iniciar.UseVisualStyleBackColor = false;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // Adelantar
            // 
            this.Adelantar.BackgroundImage = global::Reproductor.Properties.Resources.hacia_adelante;
            this.Adelantar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Adelantar.FlatAppearance.BorderSize = 0;
            this.Adelantar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Adelantar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adelantar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Adelantar.Location = new System.Drawing.Point(592, 31);
            this.Adelantar.Name = "Adelantar";
            this.Adelantar.Size = new System.Drawing.Size(65, 49);
            this.Adelantar.TabIndex = 0;
            this.Adelantar.UseVisualStyleBackColor = true;
            this.Adelantar.Click += new System.EventHandler(this.Adelantar_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(12, 34);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(0, 13);
            this.Titulo.TabIndex = 11;
            // 
            // Media
            // 
            this.Media.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(0, 24);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(1102, 555);
            this.Media.TabIndex = 2;
            // 
            // Tiempo
            // 
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 676);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproductorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer Media;
        private XComponent.SliderBar.MACTrackBar Duracion;
        private System.Windows.Forms.Button btnVolumen;
        private System.Windows.Forms.Button Retornar;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Button Adelantar;
        private XComponent.SliderBar.MACTrackBar Volumen;
        private System.Windows.Forms.Label NumeroVolumen;
        private System.Windows.Forms.Label TiempoFinal;
        private System.Windows.Forms.Label TiempoInicial;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Label Titulo;
    }
}

