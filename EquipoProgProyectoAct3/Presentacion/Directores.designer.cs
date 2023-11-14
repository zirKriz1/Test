using System.Drawing;
using System.Windows.Forms;

namespace EquipoProgProyecto.Formularios
{
    partial class Directores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Directores));
            this.la = new System.Windows.Forms.Label();
            this.txtnombreentrenador = new System.Windows.Forms.TextBox();
            this.cboLocal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textexperiencia = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.la.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.la.ForeColor = System.Drawing.SystemColors.Control;
            this.la.Location = new System.Drawing.Point(11, 26);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(156, 21);
            this.la.TabIndex = 10;
            this.la.Text = "Nombre Completo:";
            // 
            // txtnombreentrenador
            // 
            this.txtnombreentrenador.Location = new System.Drawing.Point(148, 28);
            this.txtnombreentrenador.Name = "txtnombreentrenador";
            this.txtnombreentrenador.Size = new System.Drawing.Size(193, 20);
            this.txtnombreentrenador.TabIndex = 9;
            // 
            // cboLocal
            // 
            this.cboLocal.FormattingEnabled = true;
            this.cboLocal.Location = new System.Drawing.Point(77, 121);
            this.cboLocal.Name = "cboLocal";
            this.cboLocal.Size = new System.Drawing.Size(193, 21);
            this.cboLocal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Club:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pais:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(11, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha Nacimiento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Experiencias:";
            // 
            // textexperiencia
            // 
            this.textexperiencia.Location = new System.Drawing.Point(128, 229);
            this.textexperiencia.Name = "textexperiencia";
            this.textexperiencia.Size = new System.Drawing.Size(193, 20);
            this.textexperiencia.TabIndex = 15;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalir.Location = new System.Drawing.Point(412, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 33);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmar.Location = new System.Drawing.Point(232, 285);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(139, 33);
            this.btnConfirmar.TabIndex = 18;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LimeGreen;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Location = new System.Drawing.Point(34, 285);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(139, 33);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Directores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(595, 328);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textexperiencia);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.la);
            this.Controls.Add(this.txtnombreentrenador);
            this.Controls.Add(this.cboLocal);
            this.Controls.Add(this.label1);
            this.Name = "Directores";
            this.Text = "Directores";
            this.Load += new System.EventHandler(this.Directores_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label la;
        private TextBox txtnombreentrenador;
        private ComboBox cboLocal;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textexperiencia;
        private Button btnSalir;
        private Button btnConfirmar;
        private Button btnVolver;
        private PictureBox pictureBox1;
    }
}