using System.Drawing;
using System.Windows.Forms;

namespace EquipoProgProyecto.Formularios
{
    partial class EntrenadorContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntrenadorContrato));
            dtpfine = new DateTimePicker();
            dtpinicioe = new DateTimePicker();
            label1 = new Label();
            label9 = new Label();
            lbl = new Label();
            label10 = new Label();
            txtsueldoe = new TextBox();
            txtentrenadorid = new TextBox();
            btnSalir = new Button();
            btnConfirmar = new Button();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtpfine
            // 
            dtpfine.Location = new Point(106, 127);
            dtpfine.Name = "dtpfine";
            dtpfine.Size = new Size(220, 23);
            dtpfine.TabIndex = 47;
            // 
            // dtpinicioe
            // 
            dtpinicioe.Location = new Point(126, 95);
            dtpinicioe.Name = "dtpinicioe";
            dtpinicioe.Size = new Size(217, 23);
            dtpinicioe.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 127);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 42;
            label1.Text = "Fecha Fin:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 95);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(105, 21);
            label9.TabIndex = 40;
            label9.Text = "Fecha Inicio:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(14, 21);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(120, 21);
            lbl.TabIndex = 39;
            lbl.Text = "Entrenador ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(14, 58);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(67, 21);
            label10.TabIndex = 38;
            label10.Text = "Sueldo:";
            // 
            // txtsueldoe
            // 
            txtsueldoe.Location = new Point(88, 58);
            txtsueldoe.Margin = new Padding(3, 2, 3, 2);
            txtsueldoe.Name = "txtsueldoe";
            txtsueldoe.Size = new Size(168, 23);
            txtsueldoe.TabIndex = 36;
            // 
            // txtentrenadorid
            // 
            txtentrenadorid.Location = new Point(141, 19);
            txtentrenadorid.Margin = new Padding(3, 2, 3, 2);
            txtentrenadorid.Name = "txtentrenadorid";
            txtentrenadorid.Size = new Size(168, 23);
            txtentrenadorid.TabIndex = 35;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(411, 184);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 39);
            btnSalir.TabIndex = 51;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(216, 184);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(76, 39);
            btnConfirmar.TabIndex = 50;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(17, 184);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(76, 39);
            btnVolver.TabIndex = 49;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(383, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // EntrenadorContrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 235);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnConfirmar);
            Controls.Add(btnVolver);
            Controls.Add(dtpfine);
            Controls.Add(dtpinicioe);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(lbl);
            Controls.Add(label10);
            Controls.Add(txtsueldoe);
            Controls.Add(txtentrenadorid);
            Name = "EntrenadorContrato";
            Text = "EntrenadorContrato";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label12;
        private Label label11;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label lbl;
        private Label label10;
        private TextBox txtsueldoe;
        private TextBox txtPartidos;
        private TextBox txtAsistencias;
        private TextBox txtentrenadorid;
        private Button btnSalir;
        private Button btnConfirmar;
        private Button btnVolver;
        private DateTimePicker dtpfine;
        private DateTimePicker dtpinicioe;
        private PictureBox pictureBox1;
    }
}