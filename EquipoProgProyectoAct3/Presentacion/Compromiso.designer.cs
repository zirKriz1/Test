using System.Drawing;
using System.Windows.Forms;

namespace EquipoProgProyecto.Formularios
{
    partial class Compromiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compromiso));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLocal = new System.Windows.Forms.ComboBox();
            this.txtGolesVisitante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboVisitante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGolesVisitantes = new System.Windows.Forms.TextBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTemporada = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpfechapartido = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 553);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local:";
            // 
            // cboLocal
            // 
            this.cboLocal.FormattingEnabled = true;
            this.cboLocal.Location = new System.Drawing.Point(78, 47);
            this.cboLocal.Margin = new System.Windows.Forms.Padding(4);
            this.cboLocal.Name = "cboLocal";
            this.cboLocal.Size = new System.Drawing.Size(224, 29);
            this.cboLocal.TabIndex = 2;
            // 
            // txtGolesVisitante
            // 
            this.txtGolesVisitante.Location = new System.Drawing.Point(82, 149);
            this.txtGolesVisitante.Margin = new System.Windows.Forms.Padding(4);
            this.txtGolesVisitante.Name = "txtGolesVisitante";
            this.txtGolesVisitante.Size = new System.Drawing.Size(224, 29);
            this.txtGolesVisitante.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(18, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Visitante:";
            // 
            // cboVisitante
            // 
            this.cboVisitante.FormattingEnabled = true;
            this.cboVisitante.Location = new System.Drawing.Point(104, 96);
            this.cboVisitante.Margin = new System.Windows.Forms.Padding(4);
            this.cboVisitante.Name = "cboVisitante";
            this.cboVisitante.Size = new System.Drawing.Size(224, 29);
            this.cboVisitante.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(18, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Goles \r\nLocal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(18, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "Goles\r\nVisitante:";
            // 
            // txtGolesVisitantes
            // 
            this.txtGolesVisitantes.Location = new System.Drawing.Point(104, 215);
            this.txtGolesVisitantes.Margin = new System.Windows.Forms.Padding(4);
            this.txtGolesVisitantes.Name = "txtGolesVisitantes";
            this.txtGolesVisitantes.Size = new System.Drawing.Size(224, 29);
            this.txtGolesVisitantes.TabIndex = 8;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPartido.Location = new System.Drawing.Point(18, 13);
            this.lblPartido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(89, 21);
            this.lblPartido.TabIndex = 9;
            this.lblPartido.Text = "Partido N°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(20, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha:";
            // 
            // cboTemporada
            // 
            this.cboTemporada.FormattingEnabled = true;
            this.cboTemporada.Location = new System.Drawing.Point(128, 313);
            this.cboTemporada.Margin = new System.Windows.Forms.Padding(4);
            this.cboTemporada.Name = "cboTemporada";
            this.cboTemporada.Size = new System.Drawing.Size(224, 29);
            this.cboTemporada.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(20, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Temporada:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.btnVolver.Location = new System.Drawing.Point(8, 410);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(141, 47);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(308, 410);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(141, 47);
            this.btnConfirmar.TabIndex = 15;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(610, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(141, 47);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dtpfechapartido
            // 
            this.dtpfechapartido.Location = new System.Drawing.Point(82, 266);
            this.dtpfechapartido.Name = "dtpfechapartido";
            this.dtpfechapartido.Size = new System.Drawing.Size(232, 29);
            this.dtpfechapartido.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(430, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Compromiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(766, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpfechapartido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboTemporada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.txtGolesVisitantes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboVisitante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGolesVisitante);
            this.Controls.Add(this.cboLocal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Compromiso";
            this.Text = "Compromiso";
            this.Load += new System.EventHandler(this.Compromiso_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox cboLocal;
        private TextBox txtGolesVisitante;
        private Label label2;
        private ComboBox cboVisitante;
        private Label label3;
        private Label label4;
        private TextBox txtGolesVisitantes;
        private Label lblPartido;
        private Label label5;
        private ComboBox cboTemporada;
        private Label label6;
        private Button btnVolver;
        private Button btnConfirmar;
        private Button btnSalir;
        private DateTimePicker dtpfechapartido;
        private PictureBox pictureBox1;
    }
}