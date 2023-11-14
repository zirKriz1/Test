using System.Drawing;
using System.Windows.Forms;

namespace EquipoProgProyecto.Formularios
{
    partial class JugadorContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JugadorContrato));
            btnVolver = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnConfirmar = new Button();
            btnSalir = new Button();
            label2 = new Label();
            label3 = new Label();
            txtGoles = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtAsistencias = new TextBox();
            txtAmarillas = new TextBox();
            txtPartidos = new TextBox();
            txtRojas = new TextBox();
            cboPosicion = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(10, 286);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(95, 43);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(91, 24);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(10, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(241, 286);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(95, 43);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(465, 286);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 43);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 56);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Goles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 94);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 7;
            label3.Text = "Asistencias";
            // 
            // txtGoles
            // 
            txtGoles.Location = new Point(91, 56);
            txtGoles.Margin = new Padding(3, 2, 3, 2);
            txtGoles.Name = "txtGoles";
            txtGoles.Size = new Size(168, 23);
            txtGoles.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 128);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 9;
            label4.Text = "Amarillas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 163);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 10;
            label5.Text = "Rojas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 194);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 11;
            label6.Text = "Partidos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 229);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 12;
            label7.Text = "Posicíon";
            // 
            // txtAsistencias
            // 
            txtAsistencias.Location = new Point(91, 94);
            txtAsistencias.Margin = new Padding(3, 2, 3, 2);
            txtAsistencias.Name = "txtAsistencias";
            txtAsistencias.Size = new Size(168, 23);
            txtAsistencias.TabIndex = 13;
            // 
            // txtAmarillas
            // 
            txtAmarillas.Location = new Point(91, 128);
            txtAmarillas.Margin = new Padding(3, 2, 3, 2);
            txtAmarillas.Name = "txtAmarillas";
            txtAmarillas.Size = new Size(168, 23);
            txtAmarillas.TabIndex = 14;
            // 
            // txtPartidos
            // 
            txtPartidos.Location = new Point(91, 194);
            txtPartidos.Margin = new Padding(3, 2, 3, 2);
            txtPartidos.Name = "txtPartidos";
            txtPartidos.Size = new Size(168, 23);
            txtPartidos.TabIndex = 16;
            // 
            // txtRojas
            // 
            txtRojas.Location = new Point(91, 163);
            txtRojas.Margin = new Padding(3, 2, 3, 2);
            txtRojas.Name = "txtRojas";
            txtRojas.Size = new Size(168, 23);
            txtRojas.TabIndex = 17;
            // 
            // cboPosicion
            // 
            cboPosicion.FormattingEnabled = true;
            cboPosicion.Location = new Point(91, 229);
            cboPosicion.Margin = new Padding(3, 2, 3, 2);
            cboPosicion.Name = "cboPosicion";
            cboPosicion.Size = new Size(168, 23);
            cboPosicion.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // JugadorContrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 340);
            Controls.Add(pictureBox1);
            Controls.Add(cboPosicion);
            Controls.Add(txtRojas);
            Controls.Add(txtPartidos);
            Controls.Add(txtAmarillas);
            Controls.Add(txtAsistencias);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtGoles);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btnConfirmar);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnVolver);
            Margin = new Padding(3, 2, 3, 2);
            Name = "JugadorContrato";
            Text = "Jugador Contrato";
            Load += JugadorContrato_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnConfirmar;
        private Button btnSalir;
        private Label label2;
        private Label label3;
        private TextBox txtGoles;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAsistencias;
        private TextBox txtAmarillas;
        private TextBox txtPartidos;
        private TextBox txtRojas;
        private ComboBox cboPosicion;
        private PictureBox pictureBox1;
    }
}