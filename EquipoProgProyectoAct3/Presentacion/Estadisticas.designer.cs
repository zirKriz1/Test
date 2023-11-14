using System.Drawing;
using System.Windows.Forms;

namespace EquipoProgProyecto.Formularios
{
    partial class Estadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticas));
            txtJugador = new TextBox();
            txtPartido = new TextBox();
            txtAsistencias = new TextBox();
            txtGoles = new TextBox();
            txtAmarillas = new TextBox();
            txtRojas = new TextBox();
            txtMinutos = new TextBox();
            label11 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lbl = new Label();
            label12 = new Label();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtJugador
            // 
            txtJugador.Location = new Point(114, 20);
            txtJugador.Margin = new Padding(3, 2, 3, 2);
            txtJugador.Name = "txtJugador";
            txtJugador.Size = new Size(191, 23);
            txtJugador.TabIndex = 0;
            // 
            // txtPartido
            // 
            txtPartido.Location = new Point(108, 58);
            txtPartido.Margin = new Padding(3, 2, 3, 2);
            txtPartido.Name = "txtPartido";
            txtPartido.Size = new Size(191, 23);
            txtPartido.TabIndex = 7;
            // 
            // txtAsistencias
            // 
            txtAsistencias.Location = new Point(115, 136);
            txtAsistencias.Margin = new Padding(3, 2, 3, 2);
            txtAsistencias.Name = "txtAsistencias";
            txtAsistencias.Size = new Size(191, 23);
            txtAsistencias.TabIndex = 12;
            // 
            // txtGoles
            // 
            txtGoles.Location = new Point(73, 97);
            txtGoles.Margin = new Padding(3, 2, 3, 2);
            txtGoles.Name = "txtGoles";
            txtGoles.Size = new Size(191, 23);
            txtGoles.TabIndex = 13;
            // 
            // txtAmarillas
            // 
            txtAmarillas.Location = new Point(159, 207);
            txtAmarillas.Margin = new Padding(3, 2, 3, 2);
            txtAmarillas.Name = "txtAmarillas";
            txtAmarillas.Size = new Size(191, 23);
            txtAmarillas.TabIndex = 14;
            // 
            // txtRojas
            // 
            txtRojas.Location = new Point(123, 172);
            txtRojas.Margin = new Padding(3, 2, 3, 2);
            txtRojas.Name = "txtRojas";
            txtRojas.Size = new Size(191, 23);
            txtRojas.TabIndex = 15;
            // 
            // txtMinutos
            // 
            txtMinutos.Location = new Point(161, 240);
            txtMinutos.Margin = new Padding(3, 2, 3, 2);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(191, 23);
            txtMinutos.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(10, 205);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(142, 21);
            label11.TabIndex = 29;
            label11.Text = "Tarjeta Amarillas:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(10, 170);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(104, 21);
            label8.TabIndex = 28;
            label8.Text = "Tarjeta Roja:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(10, 58);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(91, 21);
            label9.TabIndex = 27;
            label9.Text = "Partido ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(10, 134);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 21);
            label10.TabIndex = 26;
            label10.Text = "Asistencias:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.ForeColor = SystemColors.Control;
            lbl.Location = new Point(10, 18);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(97, 21);
            lbl.TabIndex = 25;
            lbl.Text = "Jugador ID:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(10, 95);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(56, 21);
            label12.TabIndex = 24;
            label12.Text = "Goles:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(10, 240);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(144, 21);
            label13.TabIndex = 30;
            label13.Text = "Minutos Jugados:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(402, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(454, 312);
            button1.Name = "button1";
            button1.Size = new Size(141, 47);
            button1.TabIndex = 34;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(228, 312);
            button2.Name = "button2";
            button2.Size = new Size(141, 47);
            button2.TabIndex = 33;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.Location = new Point(13, 312);
            button3.Name = "button3";
            button3.Size = new Size(141, 47);
            button3.TabIndex = 32;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = false;
            // 
            // Estadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(613, 371);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(lbl);
            Controls.Add(label12);
            Controls.Add(txtMinutos);
            Controls.Add(txtRojas);
            Controls.Add(txtAmarillas);
            Controls.Add(txtGoles);
            Controls.Add(txtAsistencias);
            Controls.Add(txtPartido);
            Controls.Add(txtJugador);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Estadisticas";
            Text = "Estadisticas Partido";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtJugador;
        private TextBox txtPartido;
        private TextBox txtAsistencias;
        private TextBox txtGoles;
        private TextBox txtAmarillas;
        private TextBox txtRojas;
        private TextBox txtMinutos;
        private Label label11;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lbl;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}