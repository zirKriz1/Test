using System.Drawing;
using System.Windows.Forms;

namespace EquipoProgProyecto.Formularios
{
    partial class Transferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transferencias));
            cboClubVendedor = new ComboBox();
            cboClubComprador = new ComboBox();
            cboTipoTransfe = new ComboBox();
            txtValor = new TextBox();
            btnConfirmar = new Button();
            btnSalir = new Button();
            label11 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lbl = new Label();
            label12 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cboClubVendedor
            // 
            cboClubVendedor.FormattingEnabled = true;
            cboClubVendedor.Location = new Point(148, 144);
            cboClubVendedor.Margin = new Padding(3, 2, 3, 2);
            cboClubVendedor.Name = "cboClubVendedor";
            cboClubVendedor.Size = new Size(261, 23);
            cboClubVendedor.TabIndex = 3;
            // 
            // cboClubComprador
            // 
            cboClubComprador.FormattingEnabled = true;
            cboClubComprador.Location = new Point(160, 94);
            cboClubComprador.Margin = new Padding(3, 2, 3, 2);
            cboClubComprador.Name = "cboClubComprador";
            cboClubComprador.Size = new Size(261, 23);
            cboClubComprador.TabIndex = 4;
            // 
            // cboTipoTransfe
            // 
            cboTipoTransfe.FormattingEnabled = true;
            cboTipoTransfe.Location = new Point(116, 225);
            cboTipoTransfe.Margin = new Padding(3, 2, 3, 2);
            cboTipoTransfe.Name = "cboTipoTransfe";
            cboTipoTransfe.Size = new Size(261, 23);
            cboTipoTransfe.TabIndex = 11;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(85, 185);
            txtValor.Margin = new Padding(3, 2, 3, 2);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(261, 23);
            txtValor.TabIndex = 12;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(366, 283);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(136, 35);
            btnConfirmar.TabIndex = 13;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(518, 283);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 35);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(13, 266);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(58, 21);
            label11.TabIndex = 36;
            label11.Text = "Fecha:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(13, 223);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(96, 21);
            label8.TabIndex = 35;
            label8.Text = "Tipo Venta:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(13, 96);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(140, 21);
            label9.TabIndex = 34;
            label9.Text = "Club Comprador:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(13, 183);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(65, 21);
            label10.TabIndex = 33;
            label10.Text = "Monto:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.ForeColor = SystemColors.Control;
            lbl.Location = new Point(13, 46);
            lbl.Margin = new Padding(4, 0, 4, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(97, 21);
            lbl.TabIndex = 32;
            lbl.Text = "Jugador ID:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(13, 142);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(128, 21);
            label12.TabIndex = 31;
            label12.Text = "Club Vendedor:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(78, 266);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 23);
            dateTimePicker1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(460, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // Transferencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(lbl);
            Controls.Add(label12);
            Controls.Add(btnSalir);
            Controls.Add(btnConfirmar);
            Controls.Add(txtValor);
            Controls.Add(cboTipoTransfe);
            Controls.Add(cboClubComprador);
            Controls.Add(cboClubVendedor);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Transferencias";
            Text = "Transferencias";
            Load += Transferencias_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboClubVendedor;
        private ComboBox cboClubComprador;
        private ComboBox cboTipoTransfe;
        private TextBox txtValor;
        private Button btnConfirmar;
        private Button btnSalir;
        private Label label11;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lbl;
        private Label label12;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
    }
}