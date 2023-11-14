using System.Drawing;
using System.Windows.Forms;

namespace EquipoProgProyecto
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preguntasFrecuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diretoresTecnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscribirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.jugadoresToolStripMenuItem,
            this.diretoresTecnicosToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.partidosToolStripMenuItem,
            this.transferenciasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.preguntasFrecuentesToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // preguntasFrecuentesToolStripMenuItem
            // 
            this.preguntasFrecuentesToolStripMenuItem.Name = "preguntasFrecuentesToolStripMenuItem";
            this.preguntasFrecuentesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.preguntasFrecuentesToolStripMenuItem.Text = "Preguntas Frecuentes";
            // 
            // jugadoresToolStripMenuItem
            // 
            this.jugadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.actualesToolStripMenuItem});
            this.jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            this.jugadoresToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.jugadoresToolStripMenuItem.Text = "Jugadores";
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            // 
            // actualesToolStripMenuItem
            // 
            this.actualesToolStripMenuItem.Name = "actualesToolStripMenuItem";
            this.actualesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.actualesToolStripMenuItem.Text = "Consultar";
            // 
            // diretoresTecnicosToolStripMenuItem
            // 
            this.diretoresTecnicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscribirToolStripMenuItem});
            this.diretoresTecnicosToolStripMenuItem.Name = "diretoresTecnicosToolStripMenuItem";
            this.diretoresTecnicosToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.diretoresTecnicosToolStripMenuItem.Text = "Diretores Tecnicos";
            // 
            // inscribirToolStripMenuItem
            // 
            this.inscribirToolStripMenuItem.Name = "inscribirToolStripMenuItem";
            this.inscribirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.inscribirToolStripMenuItem.Text = "Inscribir";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // partidosToolStripMenuItem
            // 
            this.partidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.partidosToolStripMenuItem.Name = "partidosToolStripMenuItem";
            this.partidosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.partidosToolStripMenuItem.Text = "Partidos";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas ";
            // 
            // transferenciasToolStripMenuItem
            // 
            this.transferenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaToolStripMenuItem});
            this.transferenciasToolStripMenuItem.Name = "transferenciasToolStripMenuItem";
            this.transferenciasToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.transferenciasToolStripMenuItem.Text = "Transferencias";
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partidosToolStripMenuItem1});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // partidosToolStripMenuItem1
            // 
            this.partidosToolStripMenuItem1.Name = "partidosToolStripMenuItem1";
            this.partidosToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.partidosToolStripMenuItem1.Text = "Partidos";
            this.partidosToolStripMenuItem1.Click += new System.EventHandler(this.partidosToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 293);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem preguntasFrecuentesToolStripMenuItem;
        private ToolStripMenuItem jugadoresToolStripMenuItem;
        private ToolStripMenuItem actualesToolStripMenuItem;
        private ToolStripMenuItem diretoresTecnicosToolStripMenuItem;
        private ToolStripMenuItem inscribirToolStripMenuItem;
        private ToolStripMenuItem equiposToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem partidosToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem transferenciasToolStripMenuItem;
        private ToolStripMenuItem nuevaToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem estadisticasToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem1;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem partidosToolStripMenuItem1;
    }
}